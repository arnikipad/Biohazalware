// Decompiled with JetBrains decompiler
// Type: Detonator.My.MySettings
// Assembly: Detonator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FA2FF0E3-083F-4040-BA84-6329375224BC
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\GDI\SaturnR\SaturnR.exe

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
namespace Detonator.My;

[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
  private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());
  private static bool addedHandler;
  private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

  [DebuggerNonUserCode]
  public MySettings()
  {
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [DebuggerNonUserCode]
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
        bool lockTaken = false;
        try
        {
          Monitor.Enter(handlerLockObject, ref lockTaken);
          if (!MySettings.addedHandler)
          {
            MyProject.Application.Shutdown += (ShutdownEventHandler) ([EditorBrowsable(EditorBrowsableState.Advanced), DebuggerNonUserCode] (sender, e) =>
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
          if (lockTaken)
            Monitor.Exit(handlerLockObject);
        }
      }
      MySettings defaultInstance = MySettings.defaultInstance;
      return defaultInstance;
    }
  }
}
