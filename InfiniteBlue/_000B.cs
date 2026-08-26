// Decompiled with JetBrains decompiler
// Type: A.
// Assembly: InfiniteBlue, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 75787C59-6E69-48EC-8991-CFBDA71A3167
// Assembly location: C:\Users\adriel\Downloads\InfiniteBlue.exe

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace A;

internal abstract class \u000B
{
  public static int \u001D = Screen.PrimaryScreen.Bounds.Width;
  public static int \u0012 = Screen.PrimaryScreen.Bounds.Height;
  protected static Random \u001D = new Random();
  protected Thread \u001D;

  [DllImport("User32.dll", EntryPoint = "GetDC")]
  protected static extern IntPtr \u0012(IntPtr _param0);

  [DllImport("User32.dll", EntryPoint = "ReleaseDC")]
  protected static extern void \u0012(IntPtr _param0, IntPtr _param1);

  [DllImport("user32.dll", EntryPoint = "RedrawWindow")]
  protected static extern bool \u0012(
    IntPtr _param0,
    IntPtr _param1,
    IntPtr _param2,
    \u000B.\u001A _param3);

  [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
  protected static extern IntPtr \u0012(
    int _param0,
    int _param1,
    int _param2,
    int _param3,
    int _param4,
    int _param5);

  [DllImport("gdi32.dll", EntryPoint = "StretchBlt")]
  protected static extern bool \u0012(
    IntPtr _param0,
    int _param1,
    int _param2,
    int _param3,
    int _param4,
    IntPtr _param5,
    int _param6,
    int _param7,
    int _param8,
    int _param9,
    CopyPixelOperation _param10);

  [DllImport("gdi32.dll", EntryPoint = "CombineRgn")]
  protected static extern int \u0012(
    IntPtr _param0,
    IntPtr _param1,
    IntPtr _param2,
    \u000B.\u000A _param3);

  [DllImport("gdi32.dll", EntryPoint = "InvertRgn")]
  protected static extern bool \u0012(IntPtr _param0, IntPtr _param1);

  [DllImport("gdi32.dll", EntryPoint = "CreateSolidBrush")]
  protected static extern IntPtr \u0012(uint _param0);

  [DllImport("gdi32.dll", EntryPoint = "SelectObject")]
  protected static extern IntPtr \u0010([In] IntPtr _param0, [In] IntPtr _param1);

  [DllImport("gdi32.dll", EntryPoint = "PatBlt")]
  protected static extern bool \u0012(
    IntPtr _param0,
    int _param1,
    int _param2,
    int _param3,
    int _param4,
    CopyPixelOperation _param5);

  [DllImport("gdi32.dll", EntryPoint = "BitBlt")]
  protected static extern bool \u0010(
    [In] IntPtr _param0,
    int _param1,
    int _param2,
    int _param3,
    int _param4,
    [In] IntPtr _param5,
    int _param6,
    int _param7,
    CopyPixelOperation _param8);

  [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
  protected static extern bool \u0012([In] IntPtr _param0);

  [DllImport("gdi32.dll", EntryPoint = "PlgBlt")]
  protected static extern bool \u0012(
    IntPtr _param0,
    Point[] _param1,
    IntPtr _param2,
    int _param3,
    int _param4,
    int _param5,
    int _param6,
    IntPtr _param7,
    int _param8,
    int _param9);

  [DllImport("gdi32.dll", EntryPoint = "CreatePatternBrush")]
  protected static extern IntPtr \u0010(IntPtr _param0);

  protected static double \u000A(
    double _param0,
    double _param1,
    double _param2,
    double _param3,
    double _param4)
  {
    return \u001F\u0012.\u001D(_param0, _param1, _param2, _param3, _param4);
  }

  public void \u0010() => \u0018\u0012.\u001D(this);

  private void \u000A() => \u000D\u0012.\u001D(this);

  public void \u001A() => \u000E\u0012.\u001D(this);

  protected abstract void \u001D(IntPtr _param1);

  protected enum \u000A
  {
    \u000B = 1,
    \u001D = 1,
    \u0012 = 2,
    \u0010 = 3,
    \u000A = 4,
    \u0008 = 5,
    \u001A = 5,
  }

  [Flags]
  protected enum \u001A : uint
  {
    \u001D = 1,
    \u0012 = 2,
    \u0010 = 4,
    \u000A = 8,
    \u001A = 16, // 0x00000010
    \u000B = 32, // 0x00000020
    \u0008 = 64, // 0x00000040
    \u0019 = 128, // 0x00000080
    \u0009 = 256, // 0x00000100
    \u0020 = 512, // 0x00000200
    \u0015 = 1024, // 0x00000400
    \u0005 = 2048, // 0x00000800
  }
}
