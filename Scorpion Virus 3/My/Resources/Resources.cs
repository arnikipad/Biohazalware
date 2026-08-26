// Decompiled with JetBrains decompiler
// Type: Scorpion_Virus_3.My.Resources.Resources
// Assembly: Scorpion Virus 3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 972D4062-A93E-4DCA-92BE-D2183A70246A
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Ransomware\Scorpion Virus 3.1\Scorpion Virus 3.1.7z\Scorpion Virus 3.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace Scorpion_Virus_3.My.Resources;

[StandardModule]
[HideModuleName]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal sealed class Resources
{
  private static ResourceManager resourceMan;
  private static CultureInfo resourceCulture;

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static ResourceManager ResourceManager
  {
    get
    {
      if (object.ReferenceEquals((object) Scorpion_Virus_3.My.Resources.Resources.resourceMan, (object) null))
        Scorpion_Virus_3.My.Resources.Resources.resourceMan = new ResourceManager("Scorpion_Virus_3.Resources", typeof (Scorpion_Virus_3.My.Resources.Resources).Assembly);
      return Scorpion_Virus_3.My.Resources.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => Scorpion_Virus_3.My.Resources.Resources.resourceCulture;
    set => Scorpion_Virus_3.My.Resources.Resources.resourceCulture = value;
  }

  internal static byte[] Destroy
  {
    get
    {
      return (byte[]) RuntimeHelpers.GetObjectValue(Scorpion_Virus_3.My.Resources.Resources.ResourceManager.GetObject(nameof (Destroy), Scorpion_Virus_3.My.Resources.Resources.resourceCulture));
    }
  }

  internal static UnmanagedMemoryStream scary_laughing
  {
    get => Scorpion_Virus_3.My.Resources.Resources.ResourceManager.GetStream(nameof (scary_laughing), Scorpion_Virus_3.My.Resources.Resources.resourceCulture);
  }

  internal static byte[] Scorpion_Virus
  {
    get
    {
      return (byte[]) RuntimeHelpers.GetObjectValue(Scorpion_Virus_3.My.Resources.Resources.ResourceManager.GetObject(nameof (Scorpion_Virus), Scorpion_Virus_3.My.Resources.Resources.resourceCulture));
    }
  }

  internal static byte[] StartBlueScreen
  {
    get
    {
      return (byte[]) RuntimeHelpers.GetObjectValue(Scorpion_Virus_3.My.Resources.Resources.ResourceManager.GetObject(nameof (StartBlueScreen), Scorpion_Virus_3.My.Resources.Resources.resourceCulture));
    }
  }
}
