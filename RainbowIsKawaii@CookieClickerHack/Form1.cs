// Decompiled with JetBrains decompiler
// Type: CookieClicker_Hack2017.Form1
// Assembly: CookieClicker_Hack2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B73F46C-B45D-4F1F-8EA2-FFEC6388E296
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\BadJoke\RainbowIsKawaii@CookieClickerHack\RainbowIsKawaii@CookieClickerHack.exe

using CookieClicker_Hack2017.My;
using Microsoft.VisualBasic;
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
public class Form1 : Form
{
  private IContainer components;

  public Form1()
  {
    this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
    this.Load += new EventHandler(this.Form1_Load);
    this.InitializeComponent();
  }

  private void Form1_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = true;

  private void Button1_Click(object sender, EventArgs e)
  {
    MyProject.Forms.attackstart.Show();
    this.Hide();
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    int num = (int) Interaction.MsgBox((object) "you are already stupid lmao");
    MyProject.Forms.attackstart.Show();
    this.Hide();
  }

  private void Form1_Load(object sender, EventArgs e) => this.TopMost = true;

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
    this.Panel1 = new Panel();
    this.Panel2 = new Panel();
    this.Panel3 = new Panel();
    this.Panel4 = new Panel();
    this.Panel5 = new Panel();
    this.Panel6 = new Panel();
    this.Panel7 = new Panel();
    this.Panel8 = new Panel();
    this.Panel9 = new Panel();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Button1 = new Button();
    this.Button2 = new Button();
    this.Panel1.SuspendLayout();
    this.Panel2.SuspendLayout();
    this.Panel3.SuspendLayout();
    this.Panel5.SuspendLayout();
    this.Panel9.SuspendLayout();
    this.SuspendLayout();
    this.Panel1.BackColor = Color.Crimson;
    this.Panel1.Controls.Add((Control) this.Label4);
    this.Panel1.Controls.Add((Control) this.Label2);
    this.Panel1.Location = new Point(12, 92);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(555, 109);
    this.Panel1.TabIndex = 0;
    this.Panel2.BackColor = Color.BlueViolet;
    this.Panel2.Controls.Add((Control) this.Label1);
    this.Panel2.Controls.Add((Control) this.Panel3);
    this.Panel2.Location = new Point(-55, 3);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(537, 96 /*0x60*/);
    this.Panel2.TabIndex = 1;
    this.Panel3.BackColor = Color.Lime;
    this.Panel3.Controls.Add((Control) this.Label3);
    this.Panel3.Location = new Point(42, 48 /*0x30*/);
    this.Panel3.Name = "Panel3";
    this.Panel3.Size = new Size(459, 73);
    this.Panel3.TabIndex = 1;
    this.Panel4.BackColor = Color.Orange;
    this.Panel4.Location = new Point(488, 3);
    this.Panel4.Name = "Panel4";
    this.Panel4.Size = new Size(555, 109);
    this.Panel4.TabIndex = 1;
    this.Panel5.BackColor = Color.Purple;
    this.Panel5.Controls.Add((Control) this.Panel7);
    this.Panel5.Controls.Add((Control) this.Panel6);
    this.Panel5.Location = new Point(-4, 165);
    this.Panel5.Name = "Panel5";
    this.Panel5.Size = new Size(402, 109);
    this.Panel5.TabIndex = 1;
    this.Panel6.BackColor = Color.Purple;
    this.Panel6.Location = new Point(406, 39);
    this.Panel6.Name = "Panel6";
    this.Panel6.Size = new Size(402, 109);
    this.Panel6.TabIndex = 2;
    this.Panel7.BackColor = Color.Orchid;
    this.Panel7.Location = new Point(16 /*0x10*/, 42);
    this.Panel7.Name = "Panel7";
    this.Panel7.Size = new Size(555, 109);
    this.Panel7.TabIndex = 1;
    this.Panel8.BackColor = Color.Lavender;
    this.Panel8.Location = new Point(405, 207);
    this.Panel8.Name = "Panel8";
    this.Panel8.Size = new Size(186, 109);
    this.Panel8.TabIndex = 2;
    this.Panel9.BackColor = Color.LightSteelBlue;
    this.Panel9.Controls.Add((Control) this.Button2);
    this.Panel9.Controls.Add((Control) this.Button1);
    this.Panel9.Location = new Point(12, 280);
    this.Panel9.Name = "Panel9";
    this.Panel9.Size = new Size(470, 109);
    this.Panel9.TabIndex = 3;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 48f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(129, 23);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(164, 73);
    this.Label1.TabIndex = 2;
    this.Label1.Text = "ARE";
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 48f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label2.Location = new Point(336, -66);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(164, 73);
    this.Label2.TabIndex = 3;
    this.Label2.Text = "ARE";
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 27.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label3.Location = new Point(360, 0);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(99, 42);
    this.Label3.TabIndex = 3;
    this.Label3.Text = "YOU";
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Fuchsia;
    this.Label4.Font = new Font("Microsoft Sans Serif", 48f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.Lime;
    this.Label4.Location = new Point(121, -3);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(310, 73);
    this.Label4.TabIndex = 4;
    this.Label4.Text = "STUPID?";
    this.Button1.Location = new Point(114, 3);
    this.Button1.Name = "Button1";
    this.Button1.Size = new Size(88, 20);
    this.Button1.TabIndex = 0;
    this.Button1.Text = "Yes yes!";
    this.Button1.UseVisualStyleBackColor = true;
    this.Button2.Location = new Point(373, 2);
    this.Button2.Name = "Button2";
    this.Button2.Size = new Size(94, 23);
    this.Button2.TabIndex = 1;
    this.Button2.Text = "Heck no.";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Pink;
    this.ClientSize = new Size(563, 306);
    this.ControlBox = false;
    this.Controls.Add((Control) this.Panel9);
    this.Controls.Add((Control) this.Panel8);
    this.Controls.Add((Control) this.Panel5);
    this.Controls.Add((Control) this.Panel4);
    this.Controls.Add((Control) this.Panel1);
    this.Controls.Add((Control) this.Panel2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (Form1);
    this.Text = "are you????!?!?!??";
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    this.Panel2.ResumeLayout(false);
    this.Panel2.PerformLayout();
    this.Panel3.ResumeLayout(false);
    this.Panel3.PerformLayout();
    this.Panel5.ResumeLayout(false);
    this.Panel9.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel2")]
  internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel3")]
  internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel4")]
  internal virtual Panel Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel5")]
  internal virtual Panel Panel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel7")]
  internal virtual Panel Panel7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel6")]
  internal virtual Panel Panel6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel8")]
  internal virtual Panel Panel8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel9")]
  internal virtual Panel Panel9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button Button2
  {
    get => this._Button2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button2_Click);
      Button button2_1 = this._Button2;
      if (button2_1 != null)
        button2_1.Click -= eventHandler;
      this._Button2 = value;
      Button button2_2 = this._Button2;
      if (button2_2 == null)
        return;
      button2_2.Click += eventHandler;
    }
  }

  internal virtual Button Button1
  {
    get => this._Button1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button1_Click);
      Button button1_1 = this._Button1;
      if (button1_1 != null)
        button1_1.Click -= eventHandler;
      this._Button1 = value;
      Button button1_2 = this._Button1;
      if (button1_2 == null)
        return;
      button1_2.Click += eventHandler;
    }
  }
}
