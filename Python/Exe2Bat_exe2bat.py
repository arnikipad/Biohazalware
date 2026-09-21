"""Interactive menu toolkit for creating Windows batch wrappers.

This is a Python 3 rewrite of the original Exe2Bat utility.
It supports:
- menu-driven use
- CLI usage
- standard certutil mode
- ZIP mode
- XP-compatible JScript mode

Usage:
    python exe2bat.py
    python exe2bat.py input.exe output.bat payload.exe --zip
    python exe2bat.py input.exe output.bat payload.exe --xp
"""

from __future__ import annotations

import argparse
import base64
import sys
import tempfile
from pathlib import Path
import zipfile

DEFAULT_BASE64_NAME = "x"
DEFAULT_JS_NAME = "x.js"
DEFAULT_ZIP_NAME = "z.zip"


def batch_escape(value: str) -> str:
    """Escape characters that have special meaning in a batch file."""
    for character in '^<|>&"':
        value = value.replace(character, "^" + character)
    return value.replace("%", "%%")


def write_script(script: str, path: str) -> str:
    """Return batch commands that write script to path."""
    lines = script.splitlines() or [""]
    commands = []
    for index, line in enumerate(lines):
        operator = ">" if index == 0 else ">>"
        commands.append(f'echo {batch_escape(line)}{operator}{path}')
    return "\r\n".join(commands) + "\r\n"


def make_javascript(base64_name: str, exe_name: str, zip_mode: bool) -> str:
    """Create the JScript used in script-based extraction modes."""
    if zip_mode:
        return (
            'f=new ActiveXObject("Scripting.FileSystemObject");'
            f'i=f.getFile("{base64_name}").openAsTextStream();\n'
            'x=new ActiveXObject("MSXml2.DOMDocument").createElement("Base64Data");'
            'x.dataType="bin.base64";\n'
            'x.text=i.readAll();'
            'o=new ActiveXObject("ADODB.Stream");'
            'o.type=1;o.open();o.write(x.nodeTypedValue);\n'
            f'z=f.getAbsolutePathName("{DEFAULT_ZIP_NAME}");'
            'o.saveToFile(z);'
            's=new ActiveXObject("Shell.Application");\n'
            's.namespace(26).copyHere(s.namespace(z).items());'
            'o.close();i.close();'
        )

    return (
        'i=WScript.createObject("Scripting.FileSystemObject")'
        f'.getFile("{base64_name}").openAsTextStream();\n'
        'x=WScript.createObject("Msxml2.DOMDocument").createElement("Base64Data");'
        'x.dataType="bin.base64";\n'
        'x.text=i.readAll();'
        'o=WScript.createObject("ADODB.Stream");'
        'o.type=1;o.open();o.write(x.nodeTypedValue);\n'
        f'o.saveToFile("{exe_name}");o.close();i.close();'
    )


def create_wrapper(input_path: Path, output_path: Path, exe_name: str,
                   zip_mode: bool = False, xp_mode: bool = False) -> int:
    """Create a batch wrapper and return the output length."""
    if not input_path.is_file():
        raise FileNotFoundError(f"Input file not found: {input_path}")

    if not exe_name or Path(exe_name).name != exe_name:
        raise ValueError("Target filename must be a simple file name, not a path.")

    temp_zip = None
    source_path = input_path

    try:
        if zip_mode:
            temp_zip = tempfile.NamedTemporaryFile(suffix=".zip", delete=False)
            temp_zip.close()
            with zipfile.ZipFile(temp_zip.name, "w", zipfile.ZIP_DEFLATED) as archive:
                archive.write(input_path, exe_name)
            source_path = Path(temp_zip.name)

        raw_data = source_path.read_bytes()
        encoded = base64.b64encode(raw_data).decode("ascii")

        output = "@echo off\r\nsetlocal\r\n\r\n"
        output += write_script(encoded, DEFAULT_BASE64_NAME)

        use_script = zip_mode or xp_mode
        if use_script:
            output += "\r\n"
            output += write_script(make_javascript(DEFAULT_BASE64_NAME, exe_name, zip_mode),
                                   DEFAULT_JS_NAME)

        output += "\r\n"
        output += f'set "v=%APPDATA%\\{exe_name}"\r\n'
        output += 'del "%v%" >NUL 2>NUL\r\n'

        if use_script:
            output += f'cscript //nologo "{DEFAULT_JS_NAME}" >NUL 2>NUL\r\n'
            output += f'del "{DEFAULT_JS_NAME}" >NUL 2>NUL\r\n'
        else:
            output += f'certutil -decode "{DEFAULT_BASE64_NAME}" "%v%" >NUL 2>NUL\r\n'

        if xp_mode:
            output += f'move /Y "{exe_name}" "%v%" >NUL 2>NUL\r\n'
        if zip_mode:
            output += f'del "{DEFAULT_ZIP_NAME}" >NUL 2>NUL\r\n'

        output += f'del "{DEFAULT_BASE64_NAME}" >NUL 2>NUL\r\n'
        output += 'start "" "%v%"\r\n'
        output += 'endlocal\r\n'

        output_path.parent.mkdir(parents=True, exist_ok=True)
        output_path.write_text(output, encoding="ascii", newline="")
        return len(output)

    finally:
        if temp_zip is not None:
            Path(temp_zip.name).unlink(missing_ok=True)


def prompt(message: str, default: str = "") -> str:
    suffix = f" [{default}]" if default else ""
    answer = input(f"{message}{suffix}: ").strip()
    return answer or default


def run_menu() -> int:
    print("\nExe2Bat Menu Toolkit")
    print("Create a Windows .bat wrapper from a source file.\n")

    input_path = Path(prompt("Input file"))
    output_path = Path(prompt("Output .bat file", str(input_path.with_suffix(".bat"))))
    exe_name = prompt("Filename inside the wrapper", input_path.name)

    print("\nPackaging mode:")
    print("  1) Standard")
    print("  2) ZIP mode")
    print("  3) ZIP + XP JScript")
    print("  4) XP JScript")
    choice = prompt("Choose", "1")

    mode_map = {
        "1": (False, False),
        "2": (True, False),
        "3": (True, True),
        "4": (False, True),
    }

    if choice not in mode_map:
        print("Invalid choice.", file=sys.stderr)
        return 2

    zip_mode, xp_mode = mode_map[choice]

    try:
        count = create_wrapper(input_path, output_path, exe_name, zip_mode, xp_mode)
    except (FileNotFoundError, OSError, ValueError) as exc:
        print(f"Error: {exc}", file=sys.stderr)
        return 1

    print(f"\nCreated {output_path} ({count} characters).")
    return 0


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(description="Create a Windows batch wrapper.")
    parser.add_argument("input", nargs="?", type=Path, help="source file to package")
    parser.add_argument("output", nargs="?", type=Path, help="output .bat path")
    parser.add_argument("filename", nargs="?", help="filename to recreate on target")
    parser.add_argument("--zip", action="store_true", help="package the input in a ZIP archive")
    parser.add_argument("--xp", action="store_true", help="use XP-compatible JScript extraction")
    return parser.parse_args()


def main() -> int:
    args = parse_args()

    if args.input is None and args.output is None and args.filename is None:
        return run_menu()

    if None in (args.input, args.output, args.filename):
        print("Usage: python exe2bat.py <input> <output> <filename> [--zip] [--xp]",
              file=sys.stderr)
        return 2

    try:
        count = create_wrapper(args.input, args.output, args.filename, args.zip, args.xp)
    except (FileNotFoundError, OSError, ValueError) as exc:
        print(f"Error: {exc}", file=sys.stderr)
        return 1

    print(f"Created {args.output} ({count} characters).")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())