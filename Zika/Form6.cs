// Decompiled with JetBrains decompiler
// Type: Zika.Form6
// Assembly: Zika, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C7CE6D81-E560-4B98-8463-4AED586D3B4E
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\GDI\Zika\Zika.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;
using Zika.Properties;

#nullable disable
namespace Zika;

public class Form6 : Form
{
  private SoundPlayer s = new SoundPlayer();
  private long inodes;
  private long in2;
  private Random r;
  private int w;
  private int h;
  private IContainer components;
  private Label label1;
  private Label label2;
  private ProgressBar progressBar1;
  private PictureBox pictureBox1;
  private Timer timer1;
  private Timer timer2;

  public Form6() => this.InitializeComponent();

  private void Form6_Load(object sender, EventArgs e)
  {
    this.inodes = (long) new Random().Next(100000, 400000);
    this.progressBar1.Minimum = 0;
    this.progressBar1.Maximum = 100;
    this.progressBar1.Value = 0;
    this.r = new Random();
    this.label2.Text = this.inodes.ToString() + " index bit";
    this.w = Screen.PrimaryScreen.Bounds.Width;
    this.h = Screen.PrimaryScreen.Bounds.Height;
    this.Top = this.h / 2 - 35;
    this.Left = this.w / 2 - 210;
    this.s = new SoundPlayer((Stream) Resources.NavaShield_Delete_C);
    this.s.PlayLooping();
  }

  private void timer1_Tick(object sender, EventArgs e)
  {
    this.in2 += (long) this.r.Next(400, 2000);
    this.label2.Text = this.in2.ToString() + " index bit";
    try
    {
      this.progressBar1.Value = (int) (100L * this.in2 / this.inodes);
    }
    catch (Exception ex)
    {
    }
    if (this.in2 < this.inodes)
      return;
    this.BackColor = Color.FromArgb(51, 110, 165);
    this.label1.Visible = false;
    this.label2.Visible = false;
    this.pictureBox1.Visible = false;
    this.progressBar1.Visible = false;
    this.timer1.Stop();
    this.timer2.Stop();
  }

  private void Form6_FormClosing(object sender, FormClosingEventArgs e)
  {
    this.s.Stop();
    Form1.f6open = false;
  }

  private void timer2_Tick(object sender, EventArgs e)
  {
    this.Top = Math.Max(this.Top - 1, 0);
    this.Left = Math.Max(this.Left - 1, 0);
    this.Width = Math.Min(this.Width + 2, this.w);
    this.Height = Math.Min(this.Height + 2, this.h);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form6));
    this.label1 = new Label();
    this.label2 = new Label();
    this.progressBar1 = new ProgressBar();
    this.pictureBox1 = new PictureBox();
    this.timer1 = new Timer(this.components);
    this.timer2 = new Timer(this.components);
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    this.SuspendLayout();
    this.label1.Anchor = AnchorStyles.None;
    this.label1.AutoSize = true;
    this.label1.Location = new Point(71, 11);
    this.label1.Name = "label1";
    this.label1.Size = new Size(156, 12);
    this.label1.TabIndex = 0;
    this.label1.Text = "Disk drive C: is being deleted";
    this.label2.Anchor = AnchorStyles.None;
    this.label2.Location = new Point(267, 11);
    this.label2.Name = "label2";
    this.label2.Size = new Size(144 /*0x90*/, 12);
    this.label2.TabIndex = 1;
    this.label2.Text = "0 index bit";
    this.label2.TextAlign = ContentAlignment.TopRight;
    this.progressBar1.Anchor = AnchorStyles.None;
    this.progressBar1.Location = new Point(74, 35);
    this.progressBar1.Name = "progressBar1";
    this.progressBar1.Size = new Size(337, 19);
    this.progressBar1.TabIndex = 2;
    this.pictureBox1.Anchor = AnchorStyles.None;
    this.pictureBox1.BackgroundImageLayout = ImageLayout.Center;
    this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(4, 4);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(64 /*0x40*/, 59);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pictureBox1.TabIndex = 3;
    this.pictureBox1.TabStop = false;
    this.timer1.Enabled = true;
    this.timer1.Interval = 2000;
    this.timer1.Tick += new EventHandler(this.timer1_Tick);
    this.timer2.Enabled = true;
    this.timer2.Interval = 400;
    this.timer2.Tick += new EventHandler(this.timer2_Tick);
    this.AutoScaleDimensions = new SizeF(6f, 12f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(420, 65);
    this.Controls.Add((Control) this.pictureBox1);
    this.Controls.Add((Control) this.progressBar1);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.label1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (Form6);
    this.ShowIcon = false;
    this.ShowInTaskbar = false;
    this.Text = nameof (Form6);
    this.FormClosing += new FormClosingEventHandler(this.Form6_FormClosing);
    this.Load += new EventHandler(this.Form6_Load);
    ((ISupportInitialize) this.pictureBox1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
