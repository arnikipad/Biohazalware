// Decompiled with JetBrains decompiler
// Type: Zika.Form2
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

public class Form2 : Form
{
  private Graphics g;
  private Bitmap b;
  private float w;
  private float h;
  private Random r = new Random();
  private int x;
  private IContainer components;
  private Timer timer1;
  private Timer timer2;

  public Form2() => this.InitializeComponent();

  private void Form2_Load(object sender, EventArgs e)
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
    Graphics graphics = Graphics.FromImage((Image) bitmap);
    Rectangle bounds2 = Screen.PrimaryScreen.Bounds;
    int x = bounds2.X;
    bounds2 = Screen.PrimaryScreen.Bounds;
    int y = bounds2.Y;
    bounds2 = Screen.PrimaryScreen.Bounds;
    Size size = bounds2.Size;
    graphics.CopyFromScreen(x, y, 0, 0, size, CopyPixelOperation.SourceCopy);
    this.g = this.CreateGraphics();
    this.b = bitmap;
    this.w = (float) bitmap.Width;
    this.h = (float) bitmap.Height;
    this.g.CompositingQuality = CompositingQuality.HighSpeed;
  }

  private void timer1_Tick(object sender, EventArgs e)
  {
    if ((double) this.x >= (double) this.w / 2.0)
      return;
    this.g.DrawImageUnscaledAndClipped((Image) this.b, new Rectangle(this.x >> 1, this.x >> 1, (int) ((double) this.w - (double) (this.x << 1)), (int) ((double) this.h - (double) (this.x << 1))));
    this.g.RotateTransform(-0.01f);
    ++this.x;
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
    this.DoubleBuffered = true;
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (Form2);
    this.ShowIcon = false;
    this.ShowInTaskbar = false;
    this.Text = nameof (Form2);
    this.Load += new EventHandler(this.Form2_Load);
    this.ResumeLayout(false);
  }
}
