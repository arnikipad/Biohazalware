// Decompiled with JetBrains decompiler
// Type: CookieClicker_Hack2017.attacjstart5
// Assembly: CookieClicker_Hack2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B73F46C-B45D-4F1F-8EA2-FFEC6388E296
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\BadJoke\RainbowIsKawaii@CookieClickerHack\RainbowIsKawaii@CookieClickerHack.exe

using CookieClicker_Hack2017.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace CookieClicker_Hack2017;

[DesignerGenerated]
public class attacjstart5 : Form
{
  private IContainer components;
  private Random somerandomt;

  public attacjstart5()
  {
    this.Load += new EventHandler(this.attacjstart5_Load);
    this.FormClosing += new FormClosingEventHandler(this.attackstart_FormClosing);
    this.somerandomt = new Random();
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    this.Panel4 = new Panel();
    this.Panel3 = new Panel();
    this.Panel2 = new Panel();
    this.Label1 = new Label();
    this.Panel8 = new Panel();
    this.Panel5 = new Panel();
    this.Panel6 = new Panel();
    this.Panel1 = new Panel();
    this.Timer1 = new Timer(this.components);
    this.Panel2.SuspendLayout();
    this.Panel8.SuspendLayout();
    this.Panel5.SuspendLayout();
    this.SuspendLayout();
    this.Panel4.BackColor = Color.Red;
    this.Panel4.Location = new Point(357, -2);
    this.Panel4.Name = "Panel4";
    this.Panel4.Size = new Size(191, 249);
    this.Panel4.TabIndex = 23;
    this.Panel3.BackColor = Color.MediumAquamarine;
    this.Panel3.Location = new Point(-9, 107);
    this.Panel3.Name = "Panel3";
    this.Panel3.Size = new Size(151, 249);
    this.Panel3.TabIndex = 22;
    this.Panel2.BackColor = Color.MediumSpringGreen;
    this.Panel2.Controls.Add((Control) this.Label1);
    this.Panel2.Location = new Point(160 /*0xA0*/, -2);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(191, 249);
    this.Panel2.TabIndex = 21;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.ForestGreen;
    this.Label1.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.Red;
    this.Label1.Location = new Point(3, 39);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(167, 58);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "try to close me \r\nlmao";
    this.Panel8.BackColor = Color.LightSlateGray;
    this.Panel8.Controls.Add((Control) this.Panel5);
    this.Panel8.Controls.Add((Control) this.Panel1);
    this.Panel8.Location = new Point(-21, -2);
    this.Panel8.Name = "Panel8";
    this.Panel8.Size = new Size(186, 109);
    this.Panel8.TabIndex = 20;
    this.Panel5.BackColor = Color.DarkOrchid;
    this.Panel5.Controls.Add((Control) this.Panel6);
    this.Panel5.Cursor = Cursors.Arrow;
    this.Panel5.ForeColor = SystemColors.ControlDarkDark;
    this.Panel5.Location = new Point(15, 17);
    this.Panel5.Name = "Panel5";
    this.Panel5.Size = new Size(76, 109);
    this.Panel5.TabIndex = 5;
    this.Panel6.BackColor = Color.SteelBlue;
    this.Panel6.Location = new Point(143, 14);
    this.Panel6.Name = "Panel6";
    this.Panel6.Size = new Size(186, 109);
    this.Panel6.TabIndex = 4;
    this.Panel1.BackColor = Color.SteelBlue;
    this.Panel1.Location = new Point(143, 14);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(186, 109);
    this.Panel1.TabIndex = 4;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(396, 209);
    this.Controls.Add((Control) this.Panel4);
    this.Controls.Add((Control) this.Panel3);
    this.Controls.Add((Control) this.Panel2);
    this.Controls.Add((Control) this.Panel8);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (attacjstart5);
    this.ShowInTaskbar = false;
    this.Text = "can't close me!!\"";
    this.Panel2.ResumeLayout(false);
    this.Panel2.PerformLayout();
    this.Panel8.ResumeLayout(false);
    this.Panel5.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("Panel4")]
  internal virtual Panel Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel3")]
  internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel2")]
  internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel8")]
  internal virtual Panel Panel8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel5")]
  internal virtual Panel Panel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel6")]
  internal virtual Panel Panel6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Timer Timer1
  {
    get => this._Timer1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
      Timer timer1_1 = this._Timer1;
      if (timer1_1 != null)
        timer1_1.Tick -= eventHandler;
      this._Timer1 = value;
      Timer timer1_2 = this._Timer1;
      if (timer1_2 == null)
        return;
      timer1_2.Tick += eventHandler;
    }
  }

  private void attacjstart5_Load(object sender, EventArgs e)
  {
    this.TopMost = true;
    this.Timer1.Start();
  }

  private void Timer1_Tick(object sender, EventArgs e)
  {
    if (this.DesktopLocation == new Point(this.somerandomt.Next(1, 1000), this.somerandomt.Next(1, 500)))
      this.DesktopLocation = new Point(this.somerandomt.Next(1, 1000), this.somerandomt.Next(1, 500));
    else
      this.DesktopLocation = new Point(this.somerandomt.Next(1, 1000), this.somerandomt.Next(1, 500));
  }

  private void attackstart_FormClosing(object sender, FormClosingEventArgs e)
  {
    MyProject.Forms.attackstart6.Show();
    e.Cancel = true;
  }
}
