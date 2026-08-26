// Decompiled with JetBrains decompiler
// Type: Scorpion_Virus_3.My.MySettings
// Assembly: Scorpion Virus 3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 972D4062-A93E-4DCA-92BE-D2183A70246A
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Ransomware\Scorpion Virus 3.1\Scorpion Virus 3.1.7z\Scorpion Virus 3.exe

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
namespace Scorpion_Virus_3.My;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
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
