// Decompiled with JetBrains decompiler
// Type: Zika.Form7
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

public class Form7 : Form
{
  private int counter;
  private SoundPlayer s = new SoundPlayer();
  private IContainer components;
  private Timer timer1;

  public Form7() => this.InitializeComponent();

  private void Form7_Load(object sender, EventArgs e)
  {
    this.Top = 0;
    this.Left = 0;
    this.Width = Screen.PrimaryScreen.Bounds.Width;
    this.Height = Screen.PrimaryScreen.Bounds.Height;
    this.s = new SoundPlayer((Stream) Resources.beep);
  }

  private void timer1_Tick(object sender, EventArgs e)
  {
    this.s.Play();
    if (this.counter % 2 == 0)
      this.BackColor = Color.White;
    else
      this.BackColor = Color.Black;
    ++this.counter;
    if (this.counter != 24)
      return;
    this.s.Stop();
    this.Close();
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
    this.timer1 = new Timer(this.components);
    this.SuspendLayout();
    this.timer1.Enabled = true;
    this.timer1.Interval = 500;
    this.timer1.Tick += new EventHandler(this.timer1_Tick);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Black;
    this.ClientSize = new Size(284, 261);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (Form7);
    this.ShowIcon = false;
    this.ShowInTaskbar = false;
    this.Text = nameof (Form7);
    this.TopMost = true;
    this.Load += new EventHandler(this.Form7_Load);
    this.ResumeLayout(false);
  }
}
