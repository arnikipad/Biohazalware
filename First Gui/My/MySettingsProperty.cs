// Decompiled with JetBrains decompiler
// Type: First_Gui.My.MySettingsProperty
// Assembly: First Gui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 40B33E92-4454-436D-9199-EC8DF301D264
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Ransomware\Pirate Ransomware\First Gui.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace First_Gui.My;

[StandardModule]
[HideModuleName]
[DebuggerNonUserCode]
[CompilerGenerated]
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
