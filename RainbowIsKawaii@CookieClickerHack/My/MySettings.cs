// Decompiled with JetBrains decompiler
// Type: CookieClicker_Hack2017.My.MySettings
// Assembly: CookieClicker_Hack2017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B73F46C-B45D-4F1F-8EA2-FFEC6388E296
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\BadJoke\RainbowIsKawaii@CookieClickerHack\RainbowIsKawaii@CookieClickerHack.exe

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
namespace CookieClicker_Hack2017.My;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
  private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());
  private static bool addedHandler;
  private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

  [DebuggerNonUserCode]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  private static void AutoSaveSettings(object sender, EventArgs e)
  {
    if (!MyProject.Application.SaveMySettingsOnExit)
      return;
    MySettingsProperty.Settings.Save();
  }

  public static MySettings Default
  {
    get
    {
      if (!MySettings.addedHandler)
      {
        object handlerLockObject = MySettings.addedHandlerLockObject;
        ObjectFlowControl.CheckForSyncLockOnValueType(handlerLockObject);
        Monitor.Enter(handlerLockObject);
        try
        {
          if (!MySettings.addedHandler)
          {
            MyProject.Application.Shutdown += (ShutdownEventHandler) ([DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Advanced)] (sender, e) =>
            {
              if (!MyProject.Application.SaveMySettingsOnExit)
                return;
              MySettingsProperty.Settings.Save();
            });
            MySettings.addedHandler = true;
          }
        }
        finally
        {
          Monitor.Exit(handlerLockObject);
        }
      }
      MySettings defaultInstance = MySettings.defaultInstance;
      return defaultInstance;
    }
  }
}
