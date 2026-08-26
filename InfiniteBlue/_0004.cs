// Decompiled with JetBrains decompiler
// Type: A.
// Assembly: InfiniteBlue, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 75787C59-6E69-48EC-8991-CFBDA71A3167
// Assembly location: C:\Users\adriel\Downloads\InfiniteBlue.exe

using System;
using System.Runtime.InteropServices;
using System.Text;

#nullable disable
namespace A;

internal sealed class \u0004
{
  internal static uint \u001D;
  internal static uint \u0012;
  internal static int \u001D;
  private static bool \u001D;

  [DllImport("kernel32.dll", EntryPoint = "SetLastError")]
  internal static extern void \u001D(uint _param0);

  [DllImport("kernel32.dll", EntryPoint = "CloseHandle")]
  internal static extern int \u001D(IntPtr _param0);

  [DllImport("kernel32.dll", EntryPoint = "OpenProcess")]
  internal static extern IntPtr \u0012(uint _param0, int _param1, uint _param2);

  [DllImport("kernel32.dll", EntryPoint = "GetCurrentProcessId")]
  internal static extern uint \u001D();

  [DllImport("kernel32.dll", EntryPoint = "LoadLibrary", CharSet = CharSet.Auto, SetLastError = true)]
  internal static extern IntPtr \u001D(string _param0);

  [DllImport("kernel32.dll", EntryPoint = "GetProcAddress", CharSet = CharSet.Ansi)]
  internal static extern \u0004.\u0001 \u001D(IntPtr _param0, string _param1);

  [DllImport("kernel32.dll", EntryPoint = "GetProcAddress", CharSet = CharSet.Ansi)]
  internal static extern \u0004.\u000F \u001D(IntPtr _param0, string _param1);

  [DllImport("kernel32.dll", EntryPoint = "GetProcAddress", CharSet = CharSet.Ansi)]
  internal static extern \u0004.\u0003 \u001D(IntPtr _param0, string _param1);

  [DllImport("kernel32.dll", EntryPoint = "GetProcAddress", CharSet = CharSet.Ansi)]
  internal static extern \u0004.\u001B \u001D(IntPtr _param0, string _param1);

  [DllImport("kernel32.dll", EntryPoint = "GetProcAddress", CharSet = CharSet.Ansi)]
  internal static extern \u0004.\u0014 \u001D(IntPtr _param0, string _param1);

  [DllImport("kernel32.dll", EntryPoint = "GetProcAddress", CharSet = CharSet.Ansi)]
  internal static extern \u0004.\u0007 \u001D(IntPtr _param0, string _param1);

  private static int \u001D(IntPtr _param0, IntPtr _param1)
  {
    return \u0016\u0010.\u001D(_param0, _param1);
  }

  [DllImport("user32.dll", EntryPoint = "GetClassName", CharSet = CharSet.Auto)]
  internal static extern int \u001D(IntPtr _param0, StringBuilder _param1, int _param2);

  internal static string \u0012(IntPtr _param0) => \u001E\u0010.\u001D(_param0);

  internal static void \u001D() => \u0011\u0010.\u001D();

  internal static bool \u001D() => \u0013\u0010.\u001D();

  [StructLayout(LayoutKind.Sequential)]
  internal sealed class \u0002
  {
    internal IntPtr \u001D;
    internal IntPtr \u0012;
    internal IntPtr \u0010;
    internal IntPtr \u000A;
    internal IntPtr \u001A;
    internal IntPtr \u000B;
  }

  internal delegate int \u0001(
    IntPtr ProcessHandle,
    int ProcessInformationClass,
    \u0004.\u0002 ProcessInformation,
    uint ProcessInformationLength,
    out uint ReturnLength);

  internal delegate int \u000F(
    IntPtr ProcessHandle,
    int ProcessInformationClass,
    out uint debugPort,
    uint ProcessInformationLength,
    out uint ReturnLength);

  internal delegate int \u001B();

  internal delegate void \u0014([MarshalAs(UnmanagedType.LPStr)] string lpOutputString);

  internal delegate int \u0003(IntPtr hProcess, ref int pbDebuggerPresent);

  internal delegate int \u001C(IntPtr wnd, IntPtr lParam);

  internal delegate int \u0007(\u0004.\u001C lpEnumFunc, IntPtr lParam);
}
