// Decompiled with JetBrains decompiler
// Type: BouncingForm.Form1
// Assembly: BouncingForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 70EF9BDA-F99B-498E-AD3F-2E6BE04A9BA7
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\BadJoke\BouncingForm\BouncingForm.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace BouncingForm;

public class Form1 : Form
{
  private Point p;
  private Random rand = new Random();
  private IContainer components;
  private PictureBox pictureBox1;
  private Timer bounceEffect;
  private Timer cursorBounce;
  private Timer randomTitle;

  public Form1() => this.InitializeComponent();

  private void Form1_Load(object sender, EventArgs e)
  {
    this.bounceEffect.Start();
    this.cursorBounce.Start();
    this.randomTitle.Start();
  }

  private void bounceEffect_Tick(object sender, EventArgs e)
  {
    this.p.X = this.rand.Next(1366);
    this.p.Y = this.rand.Next(768 /*0x0300*/);
    this.Location = this.p;
  }

  private void cursorBounce_Tick(object sender, EventArgs e)
  {
    this.p.X = this.rand.Next(1366);
    this.p.Y = this.rand.Next(768 /*0x0300*/);
    Cursor.Position = this.p;
  }

  private void randomTitle_Tick(object sender, EventArgs e) => this.Text = characterGenerator.gen();

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
    this.bounceEffect = new Timer(this.components);
    this.cursorBounce = new Timer(this.components);
    this.randomTitle = new Timer(this.components);
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    this.SuspendLayout();
    this.pictureBox1.Dock = DockStyle.Fill;
    this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(0, 0);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(251, 228);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
    this.pictureBox1.TabIndex = 0;
    this.pictureBox1.TabStop = false;
    this.bounceEffect.Interval = 500;
    this.bounceEffect.Tick += new EventHandler(this.bounceEffect_Tick);
    this.cursorBounce.Interval = 10;
    this.cursorBounce.Tick += new EventHandler(this.cursorBounce_Tick);
    this.randomTitle.Interval = 2000;
    this.randomTitle.Tick += new EventHandler(this.randomTitle_Tick);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(251, 228);
    this.Controls.Add((Control) this.pictureBox1);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (Form1);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Troll haha lolz";
    this.Load += new EventHandler(this.Form1_Load);
    ((ISupportInitialize) this.pictureBox1).EndInit();
    this.ResumeLayout(false);
  }
}
