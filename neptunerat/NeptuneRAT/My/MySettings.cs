// Decompiled with JetBrains decompiler
// Type: NeptuneRAT.My.MySettings
// Assembly: NeptuneRAT Free Version V2, Version=2.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 48C579C5-C5A1-4244-9537-C19C9217B961
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Tools\NeptuneRAT\NeptuneRAT.7z\neptunerat.exe

using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

#nullable disable
namespace NeptuneRAT.My;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.13.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
  private static MySettings \u2694️MasonRAT\u270Cڅﻼٺ؁ٻـٺڞۏ\u060B\u060Fح\u0608ڞٺــ = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());
  private static bool \u2694️MasonRAT\u270C\u060Eۙـ\u060D\u060Dـــ\u060Fۚ\u0609\u060Dﻼژىﻻٸ\u060A\u060D;
  private static object \u2694️MasonRAT\u270Cڙڞـ\u0608ـى\u060Fمـؤ\u060Cــټ\u060A\u060Fـ\u0608\u060Dٸ = RuntimeHelpers.GetObjectValue(new object());

  [DebuggerNonUserCode]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  private static void \u2694️MasonRAT\u270Cۙ\u0020دڣــْۏ\u060Aـټ\u0608څ(object sender, EventArgs e)
  {
    if (!MyProject.\u2694️MasonRAT\u270Cبڠ\u060A\u0608ٺـﻋٸ\u060Dۡ\u060Eـٺٻ̨ۨٺـ\u060F\u0608.SaveMySettingsOnExit)
      return;
    MySettingsProperty.\u2694️MasonRAT\u270C؁\u060Eڝڛۙ\u0609ٺـ\u0609ــئـٺـۜﻋـ.Save();
  }

  public static MySettings \u2694️MasonRAT\u270Cــــ\u0608ـڞ\u060A̍\u0609ﻻڝـ
  {
    get
    {
      if (!MySettings.\u2694️MasonRAT\u270C\u060Eۙـ\u060D\u060Dـــ\u060Fۚ\u0609\u060Dﻼژىﻻٸ\u060A\u060D)
      {
        object ratڙڞــىمـؤــټـٸ = MySettings.\u2694️MasonRAT\u270Cڙڞـ\u0608ـى\u060Fمـؤ\u060Cــټ\u060A\u060Fـ\u0608\u060Dٸ;
        ObjectFlowControl.CheckForSyncLockOnValueType(ratڙڞــىمـؤــټـٸ);
        bool lockTaken = false;
        try
        {
          Monitor.Enter(ratڙڞــىمـؤــټـٸ, ref lockTaken);
          if (!MySettings.\u2694️MasonRAT\u270C\u060Eۙـ\u060D\u060Dـــ\u060Fۚ\u0609\u060Dﻼژىﻻٸ\u060A\u060D)
          {
            MyProject.\u2694️MasonRAT\u270Cبڠ\u060A\u0608ٺـﻋٸ\u060Dۡ\u060Eـٺٻ̨ۨٺـ\u060F\u0608.Shutdown += (ShutdownEventHandler) ([DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Advanced)] (sender, e) =>
            {
              if (!MyProject.\u2694️MasonRAT\u270Cبڠ\u060A\u0608ٺـﻋٸ\u060Dۡ\u060Eـٺٻ̨ۨٺـ\u060F\u0608.SaveMySettingsOnExit)
                return;
              MySettingsProperty.\u2694️MasonRAT\u270C؁\u060Eڝڛۙ\u0609ٺـ\u0609ــئـٺـۜﻋـ.Save();
            });
            MySettings.\u2694️MasonRAT\u270C\u060Eۙـ\u060D\u060Dـــ\u060Fۚ\u0609\u060Dﻼژىﻻٸ\u060A\u060D = true;
          }
        }
        finally
        {
          if (lockTaken)
            Monitor.Exit(ratڙڞــىمـؤــټـٸ);
        }
      }
      MySettings ratڅﻼٺ؁ٻـٺڞۏحڞٺــ = MySettings.\u2694️MasonRAT\u270Cڅﻼٺ؁ٻـٺڞۏ\u060B\u060Fح\u0608ڞٺــ;
      return ratڅﻼٺ؁ٻـٺڞۏحڞٺــ;
    }
  }
}
