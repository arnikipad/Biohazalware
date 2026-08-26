// Decompiled with JetBrains decompiler
// Type: ⁯‍‌⁫⁪‮⁪‏‫‫‍‪‏⁭⁫‎‍⁬​⁫⁫‭‫‍⁮‬‫⁭⁫⁮‍‌⁫⁭⁪‮‮‎‫⁮‮
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
public class \u206F‍‌⁫⁪‮⁪‏‫‫‍‪‏⁭⁫‎‍⁬​⁫⁫‭‫‍⁮‬‫⁭⁫⁮‍‌⁫⁭⁪‮‮‎‫⁮‮
{
  private SoundPlayer \u206B‫‎⁯‪‌⁪‏‎‭⁯‍⁭⁯​‭⁭⁪​⁯​‫‍‏‏⁬‫​⁯⁫‍​⁫‫⁪⁭‎‍‎⁮‮;
  private string[] \u200B​‭⁮⁮‪⁮‪‌‎‭⁪​‬‮‫‍⁮‭⁬‌⁪‍‭⁯⁬⁫⁯‎⁭‬‏‌‌‍‮‍‫⁪⁭‮;
  private string[] \u200D‫⁮⁭‫‌‎⁮‍​‭‭⁮‮⁭‮‎⁮⁫‮‌⁫‫‬‪⁫‎‫‎‪‫‭‎‎⁪‌‮⁪‌‮;

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

  [DllImport("user32.dll", EntryPoint = "InvalidateRect")]
  private static extern bool \u200C⁬‫‌​‬‫‍⁮‬⁭⁯‬⁪‎⁪‎‪‍‪‏‬⁮⁭⁪⁭‏‫‬⁮‭⁬‭⁯‌‮⁮⁪⁯‎‮(
    IntPtr _param0,
    IntPtr _param1,
    bool _param2);

  public void \u206B‭⁪⁭‌‮⁮​‌‌⁫⁯‍‌⁬⁭‭‎⁬‭‫‬⁭‍⁮‫‎​‭​⁬‍‮‌‬‎‫‮⁯⁬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u206B‪⁮⁬​‎⁫‭‫‏‫⁫‌‎‏‫‏‭⁯‮‍‏⁬‏‏​‪⁬‌‫⁮⁮⁯⁬⁪⁫‎‍‌⁯‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public \u206F‍‌⁫⁪‮⁪‏‫‫‍‪‏⁭⁫‎‍⁬​⁫⁫‭‫‍⁮‬‫⁭⁫⁮‍‌⁫⁭⁪‮‮‎‫⁮‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static Random \u206D‍​‎‌‪‬⁬⁫⁯⁮‏‌⁬⁭‮⁫⁪‬‌‬‭‫​‍⁭‎‌⁪⁪‬⁯‌‌⁪‎⁮‍‮‬‮() => new Random();

  static void \u206D‪⁯‭‭​⁭⁫⁫‏‌‪⁬​‮⁯⁯‍⁯⁭⁪⁯‌‭⁮‮⁬‭‫⁯‪⁮⁫⁮⁮​⁫⁭‏⁭‮([In] int obj0) => Thread.Sleep(obj0);

  static Form \u202B​‏⁪⁯‌‏⁮⁬‍⁫⁫⁯‫​‫⁯⁫‌​‬‬‌‌​‌‍⁫⁭​⁯⁬‪‭‪​‎⁪⁯‌‮() => Form.ActiveForm;

  static void \u200C⁫‎‬‫⁫‪‭​‪‍‌‌‪‌‪⁮‍‮⁫⁯‭​‭‮‏⁪⁯⁬⁮‮‬‎‎⁯⁬‪​‪‮‮([In] Control obj0) => obj0.Hide();

  static Thread \u206B⁭‬‌‍‮‫⁬​⁭‪‏‮‭‎‭‌‪‌‬⁭‏​⁯⁪‪⁪‏⁯⁪‌⁫‬‏‍‎⁭‌​‍‮([In] ThreadStart obj0)
  {
    return new Thread(obj0);
  }

  static void \u200B​​‭⁯⁪⁪⁬⁬‮​‍‫‭⁬‪‌‎⁯‏‍⁪‎⁪⁯​‏‌​⁮⁬‏​⁮⁮​‎‎‌‮([In] Thread obj0) => obj0.Start();

  static SoundPlayer \u202E‫‏⁫‌⁭​‮‮‎⁭‪‭‮⁫⁭​‏⁭‪‮⁮‌‍⁮‫​⁫⁫‍⁮‮‬⁯‍⁮‬⁯​‏‮([In] string obj0)
  {
    return new SoundPlayer(obj0);
  }

  static void \u202B⁪⁭‎⁭⁭‮⁬‬⁭⁪⁫‍⁫⁮⁪‍‪‍‎⁭‫‫‬‎‬⁭⁭‎​⁬‏‬⁯‬‎⁮⁭‪⁫‮([In] SoundPlayer obj0) => obj0.Play();

  static Screen \u200B⁯‭⁫⁮‬⁭⁬‌⁮‍‍​⁭​⁭‮​‪‬‭‍⁫‮‍‭⁬‭⁯‮‮‎⁯‍‪‭‭⁯‮‌‮() => Screen.PrimaryScreen;

  static Rectangle \u202E​‎‏‫⁬⁭⁯‮⁫⁯‍‎‍⁪⁪‬‌⁪⁬⁭⁭‭‏‮‬‏⁫⁮‏⁪⁪‏‎‬‏⁮⁬‏⁫‮([In] Screen obj0) => obj0.Bounds;
}
