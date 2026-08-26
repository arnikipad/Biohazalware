// Decompiled with JetBrains decompiler
// Type: First_Gui.My.Resources.Resources
// Assembly: First Gui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 40B33E92-4454-436D-9199-EC8DF301D264
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Ransomware\Pirate Ransomware\First Gui.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace First_Gui.My.Resources;

[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
[HideModuleName]
internal sealed class Resources
{
  private static ResourceManager resourceMan;
  private static CultureInfo resourceCulture;

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static ResourceManager ResourceManager
  {
    get
    {
      if (object.ReferenceEquals((object) First_Gui.My.Resources.Resources.resourceMan, (object) null))
        First_Gui.My.Resources.Resources.resourceMan = new ResourceManager("First_Gui.Resources", typeof (First_Gui.My.Resources.Resources).Assembly);
      return First_Gui.My.Resources.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => First_Gui.My.Resources.Resources.resourceCulture;
    set => First_Gui.My.Resources.Resources.resourceCulture = value;
  }
}
