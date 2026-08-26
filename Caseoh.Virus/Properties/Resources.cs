// Decompiled with JetBrains decompiler
// Type: Caseoh_Virus.Properties.Resources
// Assembly: Caseoh Virus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2670CA6-E3F2-4FDC-91C6-6AAE58ABEC3C
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Trojan\Caseoh.Virus\Caseoh.Virus.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace Caseoh_Virus.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resources
{
  private static ResourceManager resourceMan;
  private static CultureInfo resourceCulture;

  internal Resources()
  {
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static ResourceManager ResourceManager
  {
    get
    {
      if (Caseoh_Virus.Properties.Resources.resourceMan == null)
        Caseoh_Virus.Properties.Resources.resourceMan = new ResourceManager("Caseoh_Virus.Properties.Resources", typeof (Caseoh_Virus.Properties.Resources).Assembly);
      return Caseoh_Virus.Properties.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => Caseoh_Virus.Properties.Resources.resourceCulture;
    set => Caseoh_Virus.Properties.Resources.resourceCulture = value;
  }

  internal static UnmanagedMemoryStream caseoh
  {
    get => Caseoh_Virus.Properties.Resources.ResourceManager.GetStream(nameof (caseoh), Caseoh_Virus.Properties.Resources.resourceCulture);
  }

  internal static byte[] CaseohGUI
  {
    get
    {
      return (byte[]) Caseoh_Virus.Properties.Resources.ResourceManager.GetObject(nameof (CaseohGUI), Caseoh_Virus.Properties.Resources.resourceCulture);
    }
  }

  internal static byte[] ferris
  {
    get => (byte[]) Caseoh_Virus.Properties.Resources.ResourceManager.GetObject(nameof (ferris), Caseoh_Virus.Properties.Resources.resourceCulture);
  }

  internal static byte[] melt
  {
    get => (byte[]) Caseoh_Virus.Properties.Resources.ResourceManager.GetObject(nameof (melt), Caseoh_Virus.Properties.Resources.resourceCulture);
  }

  internal static byte[] WMPLib
  {
    get => (byte[]) Caseoh_Virus.Properties.Resources.ResourceManager.GetObject(nameof (WMPLib), Caseoh_Virus.Properties.Resources.resourceCulture);
  }

  internal static string WMPStart
  {
    get => Caseoh_Virus.Properties.Resources.ResourceManager.GetString(nameof (WMPStart), Caseoh_Virus.Properties.Resources.resourceCulture);
  }
}
