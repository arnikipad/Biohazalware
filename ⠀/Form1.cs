// Decompiled with JetBrains decompiler
// Type: HC.Form1
// Assembly: ⠀, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D0708EAF-DBFF-4047-8796-B1F7AB78F6FA
// Assembly location: \\VBOXSVR\B4s3\Private\⠀.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace HC;

public class Form1 : Form
{
  private double ti;
  private IContainer components;
  private PictureBox pictureBox1;
  private Timer timer1;
  private Timer timer2;

  public Form1() => this.InitializeComponent();

  private void OpenNewForm()
  {
    Form1 form1_1 = new Form1();
    form1_1.StartPosition = FormStartPosition.Manual;
    Form1 form1_2 = form1_1;
    Point location = this.Location;
    int x = location.X;
    location = this.Location;
    int y = location.Y - form1_1.Height;
    Point point = new Point(x, y);
    form1_2.Location = point;
    form1_1.Show();
  }

  private void Form1_Load(object sender, EventArgs e)
  {
    if (Application.OpenForms.Count >= 10)
      return;
    this.OpenNewForm();
  }

  private void timer1_Tick(object sender, EventArgs e)
  {
    Random random = new Random();
    int width = this.Width;
    int height = this.Height;
    int[] source = new int[width * height];
    for (int index = 0; index < source.Length; ++index)
    {
      ++this.ti;
      int ti = (int) this.ti;
      source[index] = (int) ((double) ((ti & ti / 1 & ti / 2) * ti) / 1000.0 % 2.0);
    }
    Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppRgb);
    BitmapData bitmapdata = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.WriteOnly, bitmap.PixelFormat);
    Marshal.Copy(source, 0, bitmapdata.Scan0, source.Length);
    bitmap.UnlockBits(bitmapdata);
    this.pictureBox1.Image = (Image) bitmap;
  }

  private void timer2_Tick(object sender, EventArgs e) => this.Size = new Size(300, 150);

  private void pictureBox1_Click(object sender, EventArgs e)
  {
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
    this.pictureBox1 = new PictureBox();
    this.timer1 = new Timer(this.components);
    this.timer2 = new Timer(this.components);
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    this.SuspendLayout();
    this.pictureBox1.Location = new Point(0, 0);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(403, 95);
    this.pictureBox1.TabIndex = 0;
    this.pictureBox1.TabStop = false;
    this.timer1.Enabled = true;
    this.timer1.Tick += new EventHandler(this.timer1_Tick);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
    this.ClientSize = new Size(387, 94);
    this.Controls.Add((Control) this.pictureBox1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (Form1);
    this.ShowIcon = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "⠀";
    ((ISupportInitialize) this.pictureBox1).EndInit();
    this.ResumeLayout(false);
  }
}
