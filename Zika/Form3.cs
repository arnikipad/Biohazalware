// Decompiled with JetBrains decompiler
// Type: Zika.Form3
// Assembly: Zika, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C7CE6D81-E560-4B98-8463-4AED586D3B4E
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\GDI\Zika\Zika.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

#nullable disable
namespace Zika;

public class Form3 : Form
{
  private Graphics g;
  private Bitmap b;
  private int w;
  private int h;
  private Random r = new Random();
  private int x;
  private IContainer components;
  private Timer timer1;
  private Timer timer2;

  public Form3() => this.InitializeComponent();

  private void Form3_Load(object sender, EventArgs e)
  {
    this.Top = 0;
    this.Left = 0;
    this.TopMost = true;
    this.Width = Screen.PrimaryScreen.Bounds.Width;
    this.Height = Screen.PrimaryScreen.Bounds.Height;
    Rectangle bounds1 = Screen.PrimaryScreen.Bounds;
    int width = bounds1.Width;
    bounds1 = Screen.PrimaryScreen.Bounds;
    int height = bounds1.Height;
    Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
    Graphics graphics1 = Graphics.FromImage((Image) bitmap);
    Graphics graphics2 = graphics1;
    Rectangle bounds2 = Screen.PrimaryScreen.Bounds;
    int x = bounds2.X;
    bounds2 = Screen.PrimaryScreen.Bounds;
    int y = bounds2.Y;
    bounds2 = Screen.PrimaryScreen.Bounds;
    Size size = bounds2.Size;
    graphics2.CopyFromScreen(x, y, 0, 0, size, CopyPixelOperation.SourceCopy);
    this.g = this.CreateGraphics();
    this.b = bitmap;
    this.w = bitmap.Width;
    this.h = bitmap.Height;
    this.g.CompositingQuality = CompositingQuality.HighSpeed;
    int num1 = 0;
    for (int index1 = 1; index1 < 16 /*0x10*/; ++index1)
    {
      int num2 = 0;
      for (int index2 = 0; index2 < this.w; ++index2)
      {
        int blue;
        int green;
        int red;
        if (index1 > 0 && num2 > num1 && index1 % index2 != 0)
        {
          int num3;
          blue = num3 = 0;
          green = num3;
          red = num3;
        }
        else
        {
          red = (int) byte.MaxValue - this.r.Next(0, 4 * index1) / (4 * index1 - 1) * (int) byte.MaxValue;
          green = (int) byte.MaxValue - this.r.Next(0, 4 * index1) / (4 * index1 - 1) * (int) byte.MaxValue;
          blue = (int) byte.MaxValue - this.r.Next(0, 4 * index1) / (4 * index1 - 1) * (int) byte.MaxValue;
        }
        graphics1.DrawLine(new Pen(Color.FromArgb(red, green, blue)), index2, this.h - num2, index2, this.h);
        num2 = num2 + this.r.Next(0, 2 * index1) / (2 * index1 - 1) + this.r.Next(0, 2);
      }
      if (index1 == 1)
        num1 = num2;
    }
  }

  private void timer1_Tick(object sender, EventArgs e)
  {
    if (this.x >= this.w)
      return;
    this.g.DrawImage((Image) this.b, new Rectangle(0, 0, this.w - this.x, this.h - this.x), new Rectangle(0, 0, this.w - this.x, this.h - this.x), GraphicsUnit.Pixel);
    this.g.RotateTransform(-0.7f);
    this.g.DrawImage((Image) this.b, new Rectangle(0, this.h - this.x, this.w - this.x, this.h - this.x), new Rectangle(0, this.h - this.x, this.w - this.x, this.h - this.x), GraphicsUnit.Pixel);
    this.g.RotateTransform(0.7f);
    this.g.DrawImage((Image) this.b, new Rectangle(this.w - this.x, 0, this.w - this.x, this.h - this.x), new Rectangle(this.w - this.x, 0, this.w - this.x, this.h - this.x), GraphicsUnit.Pixel);
    this.g.RotateTransform(0.7f);
    this.g.DrawImage((Image) this.b, new Rectangle(this.w - this.x, this.h - this.x, this.w - this.x, this.h - this.x), new Rectangle(this.w - this.x, this.h - this.x, this.w - this.x, this.h - this.x), GraphicsUnit.Pixel);
    this.g.RotateTransform(-0.7f);
    this.x += 9;
  }

  private void timer2_Tick(object sender, EventArgs e) => this.Close();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    this.timer1 = new Timer(this.components);
    this.timer2 = new Timer(this.components);
    this.SuspendLayout();
    this.timer1.Enabled = true;
    this.timer1.Interval = 50;
    this.timer1.Tick += new EventHandler(this.timer1_Tick);
    this.timer2.Enabled = true;
    this.timer2.Interval = 5000;
    this.timer2.Tick += new EventHandler(this.timer2_Tick);
    this.AutoScaleDimensions = new SizeF(6f, 12f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Black;
    this.ClientSize = new Size(284, 241);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (Form3);
    this.ShowIcon = false;
    this.ShowInTaskbar = false;
    this.Text = nameof (Form3);
    this.Load += new EventHandler(this.Form3_Load);
    this.ResumeLayout(false);
  }
}
