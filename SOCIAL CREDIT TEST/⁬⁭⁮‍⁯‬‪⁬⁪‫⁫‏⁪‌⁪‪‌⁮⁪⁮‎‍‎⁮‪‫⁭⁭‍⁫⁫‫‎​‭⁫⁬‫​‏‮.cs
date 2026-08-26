// Decompiled with JetBrains decompiler
// Type: ⁬⁭⁮‍⁯‬‪⁬⁪‫⁫‏⁪‌⁪‪‌⁮⁪⁮‎‍‎⁮‪‫⁭⁭‍⁫⁫‫‎​‭⁫⁬‫​‏‮
// Assembly: SOCIAL CREDIT TEST, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A9FFD1C6-DD6B-47BE-B937-02E8EB54F42C
// Assembly location: C:\Users\adriel\Downloads\SOCIAL CREDIT TEST.exe

using System;
using System.Drawing;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
public class \u206C⁭⁮‍⁯‬‪⁬⁪‫⁫‏⁪‌⁪‪‌⁮⁪⁮‎‍‎⁮‪‫⁭⁭‍⁫⁫‫‎​‭⁫⁬‫​‏‮
{
  private const int \u202B‎⁯‍‌‌⁭⁭⁬‮⁮‪‬‪⁭⁮‏⁬‮‎‫‮‬⁭‫‬‌⁯‮⁮⁮⁫‫⁪‌‌‫​‬⁮‮ = 0;
  private const int \u206F‭‏‌‪‭‪‫⁭⁫‪⁮⁪‎⁯⁫​‫‍⁬‬‎‏⁯⁯⁬‬‏‭‏⁮‍​⁮⁬‪⁬⁮⁯‎‮ = 1;
  private SoundPlayer \u200E‫‌⁪⁫⁫‏‫‎‫‮⁫⁯‭⁯‎⁪⁪‮⁯⁮‬‌⁭​⁬‪‫⁬⁮⁬⁬‬⁬‎‎‍‎⁬‎‮;

  [DllImport("user32.dll", EntryPoint = "GetDC", SetLastError = true)]
  private static extern IntPtr \u202C‍⁪‫‫⁭⁫‪‫‌‍‎‫⁮⁪⁬​‫⁫‮‍‌⁮‫‎‍​‬‎​‭‮⁫⁪⁮⁪​‪⁮⁭‮(IntPtr _param0);

  [DllImport("User32.dll", EntryPoint = "ReleaseDC")]
  private static extern int \u206B⁭⁫‍⁬‬⁮‫‏⁪‬‪‭​⁭⁮‌⁪‌​⁭⁪⁮‌‭⁮⁪‭‏‍⁫‭⁮⁮⁯‏‎‮⁭‮(
    IntPtr _param0,
    IntPtr _param1);

  [DllImport("gdi32.dll", EntryPoint = "Rectangle")]
  private static extern bool \u200F‌‬‬‌​⁬⁬‍⁬‮⁫⁭⁫‭⁭⁬‏⁮‪​‪⁯​‫‬⁯‍‮‪‎‍‫‌⁮‎‌‌​⁯‮(
    IntPtr _param0,
    int _param1,
    int _param2,
    int _param3,
    int _param4);

  [DllImport("gdi32.dll", EntryPoint = "CreateSolidBrush")]
  private static extern IntPtr \u200D⁯‭⁫‍⁫‍‎‏⁫‏‍‮‏‎‏‪⁯​⁫⁭⁬‫⁫‍‏⁭​‍‫‬⁭‮⁫⁯‭‫‮⁬‌‮(uint _param0);

  [DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
  private static extern IntPtr \u206C⁭⁪‭⁮⁪‮​⁪‎‬⁮⁮⁭‬‪⁭‫‫‮⁪⁭‫‪⁬⁫‫‍‭‎‪⁫​‎⁭‭⁭​‬⁯‮();

  [DllImport("user32.dll", EntryPoint = "GetWindowDC")]
  private static extern IntPtr \u202B⁪‪​‮‏⁪‬⁭⁫‬‏⁬⁯⁬⁮⁬​‌⁭⁯⁮​‭⁬‍⁭⁯‭​‫⁯⁭‏‪‏⁭⁪​‎‮(IntPtr _param0);

  [DllImport("gdi32.dll", EntryPoint = "DeleteDC")]
  public static extern bool \u202E⁭⁮‪‭‎⁯‮‫‎‍‎⁮⁫‫‪⁯‌⁭⁭‍⁭⁮⁯⁮‍‪‌⁪​‬​‎​‪‪⁪‌⁯‌‮(IntPtr _param0);

  [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
  [return: MarshalAs(UnmanagedType.Bool)]
  public static extern bool \u202E‪⁯⁭⁮⁬‫⁪⁬‍​⁯‭​⁮‪‭⁬‮‬⁬⁫⁬‭‮‏‪‭‍⁮‬‫‪‌⁬‎⁬‌⁭‮‮(IntPtr _param0);

  [DllImport("gdi32.dll", EntryPoint = "SelectObject")]
  public static extern IntPtr \u200D⁫‬​⁬‫‎‪‮‎⁯⁫​​‮‭‎⁪⁫‪⁭‏⁯‮‌⁭‬‌​⁫⁮⁫‬⁭⁭‮‪⁪⁫‮‮(
    IntPtr _param0,
    IntPtr _param1);

  [DllImport("gdi32.dll", EntryPoint = "GdiAlphaBlend")]
  public static extern bool \u206A‭‭‬‪⁯​‮⁬⁮⁬⁪​‮⁮‮‭⁪‏⁯‏‪⁪‏‪⁭‫‌‫‏‪‬⁪‫‫‎‎‏⁮‫‮(
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
    \u206C⁭⁮‍⁯‬‪⁬⁪‫⁫‏⁪‌⁪‪‌⁮⁪⁮‎‍‎⁮‪‫⁭⁭‍⁫⁫‫‎​‭⁫⁬‫​‏‮.\u202C‪⁭⁯⁫‬‪‌⁯⁬‮‬⁪‎‫‎‎‭⁪⁯‭⁪‫‏‫‏‬‎‎‮⁭‭⁯‬‫‌⁬‏‫‍‮ _param10);

  [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleDC", SetLastError = true)]
  private static extern IntPtr \u202E⁯‪⁬⁬​⁪‮‭‍‏‏‮‎⁮⁫⁫⁭‭‮‌‮​‪‌⁪⁪‏‮‏⁭‌‎‬⁫​⁪⁭⁮‌‮(IntPtr _param0);

  [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleBitmap")]
  private static extern IntPtr \u202D‭‎‍⁪‮⁭‭​‭‍‏⁮⁬‏⁬⁭‮​‪⁮⁬‮‬‏‌‍​⁫​‮‬‮⁫‭‫⁮⁬‌⁬‮(
    IntPtr _param0,
    int _param1,
    int _param2);

  [DllImport("gdi32.dll", EntryPoint = "BitBlt", SetLastError = true)]
  [return: MarshalAs(UnmanagedType.Bool)]
  private static extern bool \u202D‏‮‬⁪⁯​‌‪‭⁬‮‬​⁯‎⁯⁯‮⁫⁯‍⁫​‎⁪⁬‌​​⁯‭⁪⁮‌‫⁮‎⁭⁭‮(
    IntPtr _param0,
    int _param1,
    int _param2,
    int _param3,
    int _param4,
    IntPtr _param5,
    int _param6,
    int _param7,
    \u206C⁭⁮‍⁯‬‪⁬⁪‫⁫‏⁪‌⁪‪‌⁮⁪⁮‎‍‎⁮‪‫⁭⁭‍⁫⁫‫‎​‭⁫⁬‫​‏‮.\u200C⁭‮⁫⁪‬‏⁫‫‪‍‏⁬⁮‪‍⁭‬‎‮‏‌⁪​⁪‭‫‍‭‏​‎‌‏‏⁪‫⁫⁭‎‮ _param8);

  public void \u202D⁯​⁭‭⁯‎⁭‮⁮⁬⁮‎⁮‪‫⁮⁫⁭‏‭‫‮⁭​‎⁪‎‌⁪⁪⁬‪​⁯⁭⁮⁯⁭‮‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u202E‪‍​⁮‪⁬​⁪‌⁮‎⁮​⁫⁮⁪⁭⁮‏‬⁭‪‪⁪‫⁭‭‍‫‍‌​‏‌‭⁭⁪‮⁫‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public \u206C⁭⁮‍⁯‬‪⁬⁪‫⁫‏⁪‌⁪‪‌⁮⁪⁮‎‍‎⁮‪‫⁭⁭‍⁫⁫‫‎​‭⁫⁬‫​‏‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static Random \u202B⁫‭‍‫‪⁯‎‪⁫⁪⁪​​‏‌⁪​⁫⁯⁫⁭‎‏⁪⁯​‬⁫⁭‏‎⁫‎⁬⁯⁬⁭⁬⁯‮() => new Random();

  static void \u206C⁪⁯⁮‍‫‬⁭‭‏⁭‬⁮⁮⁪⁫‫‎‮‫⁮​‫⁫⁭⁬‫‌⁯⁯⁪‏‪⁭⁮‭⁬⁮⁪‏‮([In] int obj0) => Thread.Sleep(obj0);

  static Form \u200D⁬⁮⁭‫⁯‏⁯‍​‌‏⁭‮⁪⁭‪⁫⁯‎⁯⁯‏‮​‏​‌‎‎​‪​‫‪‫⁮‌‫‎‮() => Form.ActiveForm;

  static void \u202D‍‍​‎‮⁭⁭‮⁯‬⁯‍⁭⁬⁮‎⁭⁬‭‎⁭‏‮‭⁭‪⁭⁫‎⁪⁬⁯‬‏⁬⁮‏⁬‮‮([In] Control obj0) => obj0.Hide();

  static Screen \u206A‪‮⁪‪⁭‏⁮⁮​‍⁯‏⁯​⁮‌​‍‎⁭‏‬⁪⁭‪‮‮‪⁭⁭‎⁮⁫⁬⁮⁬‫‪⁪‮() => Screen.PrimaryScreen;

  static Rectangle \u200F‌‏‬‏⁫‫‎‪⁮‬‬⁪‫​⁫‏‌⁫‌⁬‭⁫⁪‬⁮‍‎‮⁯⁫⁮‍‌⁯⁯‍⁭‮⁯‮([In] Screen obj0) => obj0.Bounds;

  static SoundPlayer \u206D‭‌‭⁮​​​⁬⁪​‏⁫⁫​‎‫​​⁫‮⁬‌⁪‌‌⁮‌‌‬‬⁬‭⁪​‭⁫⁫⁪⁯‮([In] string obj0)
  {
    return new SoundPlayer(obj0);
  }

  static void \u206B⁪‮⁮‬‮⁫​‫⁪‏​​‭⁬‎‎‎⁬‍‭‬​‎‎​‍​‬‎‭⁬⁪⁬​‌⁯⁯‪‌‮([In] SoundPlayer obj0) => obj0.Play();

  static int \u200F⁫⁪‌⁪‬‭‬⁬‭⁬⁫⁮‪⁫⁪‮‌‭‭‮⁭‫⁮‬‮‬‏‌‮‏‪​‫⁭​⁭‮⁮⁯‮([In] Random obj0, [In] int obj1, [In] int obj2)
  {
    return obj0.Next(obj1, obj2);
  }

  private enum \u200C⁭‮⁫⁪‬‏⁫‫‪‍‏⁬⁮‪‍⁭‬‎‮‏‌⁪​⁪‭‫‍‭‏​‎‌‏‏⁪‫⁫⁭‎‮ : uint
  {
    BLACKNESS = 66, // 0x00000042
    NOTSRCERASE = 1114278, // 0x001100A6
    NOTSRCCOPY = 3342344, // 0x00330008
    SRCERASE = 4457256, // 0x00440328
    DSTINVERT = 5570569, // 0x00550009
    PATINVERT = 5898313, // 0x005A0049
    SRCINVERT = 6684742, // 0x00660046
    SRCAND = 8913094, // 0x008800C6
    MERGEPAINT = 12255782, // 0x00BB0226
    MERGECOPY = 12583114, // 0x00C000CA
    SRCCOPY = 13369376, // 0x00CC0020
    SRCPAINT = 15597702, // 0x00EE0086
    PATCOPY = 15728673, // 0x00F00021
    PATPAINT = 16452105, // 0x00FB0A09
    WHITENESS = 16711778, // 0x00FF0062
    CAPTUREBLT = 1073741824, // 0x40000000
  }

  public struct \u202C‪⁭⁯⁫‬‪‌⁯⁬‮‬⁪‎‫‎‎‭⁪⁯‭⁪‫‏‫‏‬‎‎‮⁭‭⁯‬‫‌⁬‏‫‍‮
  {
    private byte \u202D‍⁯‫‪⁯‭‏‪‭‫​‮‌‌‪‏⁮⁯‬‫‎‌‎‏⁪‏‪‏‬⁪‎‫‌⁮‮⁬‭⁬⁫‮;
    private byte \u206B‬‮‮‬⁪‍⁫⁮‬⁭⁫⁯‫‏‌⁮⁫⁯​⁬⁪‍⁪‎‭⁭‭⁪‌‎⁫⁮​‭‭‌‌‎‮‮;
    private byte \u206D⁭‮‬⁮‎‪‎‭⁪⁮⁭‌​‪‫⁯⁮‍⁭⁮‭‭​‪⁮‭⁪‭⁬⁮⁭⁫​‎‮⁯‌⁬‮;
    private byte \u200B⁬‫‭⁫‏‫‬‬​‫‎⁫‫‏​​‎⁮⁫‎‎‎‎​⁬⁫‏⁬⁮⁯⁬‬​‬⁮‬⁫‪⁪‮;

    public \u202C‪⁭⁯⁫‬‪‌⁯⁬‮‬⁪‎‫‎‎‭⁪⁯‭⁪‫‏‫‏‬‎‎‮⁭‭⁯‬‫‌⁬‏‫‍‮(
      byte op,
      byte flags,
      byte alpha,
      byte format)
    {
      // ISSUE: unable to decompile the method.
    }
  }
}
