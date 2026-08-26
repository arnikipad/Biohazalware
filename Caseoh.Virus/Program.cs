// Decompiled with JetBrains decompiler
// Type: Caseoh_Virus.Program
// Assembly: Caseoh Virus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2670CA6-E3F2-4FDC-91C6-6AAE58ABEC3C
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Trojan\Caseoh.Virus\Caseoh.Virus.exe

using System;
using System.Windows.Forms;

#nullable disable
namespace Caseoh_Virus;

internal static class Program
{
  [STAThread]
  private static void Main()
  {
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);
    Application.Run((Form) new Form1());
  }
}
