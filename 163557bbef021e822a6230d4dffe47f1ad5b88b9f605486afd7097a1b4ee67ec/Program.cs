// Decompiled with JetBrains decompiler
// Type: WinLocker.Program
// Assembly: WinLocker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8062B160-3B56-4AD0-BF31-7B20DC77D323
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Ransomware\WinLocker\163557bbef021e822a6230d4dffe47f1ad5b88b9f605486afd7097a1b4ee67ec.exe

using System;
using System.Windows.Forms;

#nullable disable
namespace WinLocker;

internal static class Program
{
  [STAThread]
  private static void Main()
  {
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);
    Application.Run((Form) new Locked());
  }
}
