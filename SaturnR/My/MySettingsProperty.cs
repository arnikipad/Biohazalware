// Decompiled with JetBrains decompiler
// Type: Detonator.My.MySettingsProperty
// Assembly: Detonator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FA2FF0E3-083F-4040-BA84-6329375224BC
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\GDI\SaturnR\SaturnR.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace Detonator.My;

[HideModuleName]
[CompilerGenerated]
[DebuggerNonUserCode]
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
