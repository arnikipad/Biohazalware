// Decompiled with JetBrains decompiler
// Type: Scorpion_Virus_3.My.MySettingsProperty
// Assembly: Scorpion Virus 3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 972D4062-A93E-4DCA-92BE-D2183A70246A
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Ransomware\Scorpion Virus 3.1\Scorpion Virus 3.1.7z\Scorpion Virus 3.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace Scorpion_Virus_3.My;

[DebuggerNonUserCode]
[HideModuleName]
[CompilerGenerated]
[StandardModule]
internal sealed class MySettingsProperty
{
  [HelpKeyword("My.Settings")]
  internal static MySettings Settings
  {
    get
    {
      MySettings settings = MySettings.Default;
      return settings;
    }
  }
}
