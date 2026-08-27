// Decompiled with JetBrains decompiler
// Type: Zika.Form8
// Assembly: Zika, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C7CE6D81-E560-4B98-8463-4AED586D3B4E
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\GDI\Zika\Zika.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace Zika;

public class Form8 : Form
{
  private IContainer components;
  private Timer timer1;
  private Label label1;

  public Form8() => this.InitializeComponent();

  private void timer1_Tick(object sender, EventArgs e) => this.Close();

  private void Form8_Load(object sender, EventArgs e)
  {
    this.Top = 0;
    this.Left = 0;
    this.Width = Screen.PrimaryScreen.Bounds.Width;
    this.Height = Screen.PrimaryScreen.Bounds.Height;
    string str = "";
    Random random = new Random();
    for (int index = 0; index < Screen.PrimaryScreen.Bounds.Width * Screen.PrimaryScreen.Bounds.Height / 50; ++index)
    {
      int num = random.Next(0, 190);
      if (num >= 95)
        num += 33;
      int utf32 = num + 33;
      str += char.ConvertFromUtf32(utf32);
    }
    this.label1.Text = str;
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
    this.label1 = new Label();
    this.SuspendLayout();
    this.timer1.Enabled = true;
    this.timer1.Interval = 15000;
    this.timer1.Tick += new EventHandler(this.timer1_Tick);
    this.label1.BackColor = Color.Transparent;
    this.label1.Dock = DockStyle.Fill;
    this.label1.Font = new Font("Consolas", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label1.ForeColor = Color.Silver;
    this.label1.Location = new Point(0, 0);
    this.label1.Name = "label1";
    this.label1.Size = new Size(284, 261);
    this.label1.TabIndex = 0;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Black;
    this.ClientSize = new Size(284, 261);
    this.Controls.Add((Control) this.label1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (Form8);
    this.ShowIcon = false;
    this.ShowInTaskbar = false;
    this.Text = nameof (Form8);
    this.TopMost = true;
    this.Load += new EventHandler(this.Form8_Load);
    this.ResumeLayout(false);
  }
}
