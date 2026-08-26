// Decompiled with JetBrains decompiler
// Type: Detonator.My.Resources.Resources
// Assembly: Detonator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FA2FF0E3-083F-4040-BA84-6329375224BC
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\GDI\SaturnR\SaturnR.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace Detonator.My.Resources;

[HideModuleName]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[StandardModule]
internal sealed class Resources
{
  private static ResourceManager resourceMan;
  private static CultureInfo resourceCulture;

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static ResourceManager ResourceManager
  {
    get
    {
      if (object.ReferenceEquals((object) Detonator.My.Resources.Resources.resourceMan, (object) null))
        Detonator.My.Resources.Resources.resourceMan = new ResourceManager("Detonator.Resources", typeof (Detonator.My.Resources.Resources).Assembly);
      return Detonator.My.Resources.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => Detonator.My.Resources.Resources.resourceCulture;
    set => Detonator.My.Resources.Resources.resourceCulture = value;
  }

  internal static Bitmap detState1
  {
    get
    {
      return (Bitmap) RuntimeHelpers.GetObjectValue(Detonator.My.Resources.Resources.ResourceManager.GetObject(nameof (detState1), Detonator.My.Resources.Resources.resourceCulture));
    }
  }

  internal static Bitmap detState2
  {
    get
    {
      return (Bitmap) RuntimeHelpers.GetObjectValue(Detonator.My.Resources.Resources.ResourceManager.GetObject(nameof (detState2), Detonator.My.Resources.Resources.resourceCulture));
    }
  }

  internal static Bitmap detStatePressed
  {
    get
    {
      return (Bitmap) RuntimeHelpers.GetObjectValue(Detonator.My.Resources.Resources.ResourceManager.GetObject(nameof (detStatePressed), Detonator.My.Resources.Resources.resourceCulture));
    }
  }

  internal static byte[] Gordon
  {
    get
    {
      return (byte[]) RuntimeHelpers.GetObjectValue(Detonator.My.Resources.Resources.ResourceManager.GetObject(nameof (Gordon), Detonator.My.Resources.Resources.resourceCulture));
    }
  }

  internal static byte[] Saturn
  {
    get
    {
      return (byte[]) RuntimeHelpers.GetObjectValue(Detonator.My.Resources.Resources.ResourceManager.GetObject(nameof (Saturn), Detonator.My.Resources.Resources.resourceCulture));
    }
  }

  internal static Bitmap ToggleSwitchDn
  {
    get
    {
      return (Bitmap) RuntimeHelpers.GetObjectValue(Detonator.My.Resources.Resources.ResourceManager.GetObject(nameof (ToggleSwitchDn), Detonator.My.Resources.Resources.resourceCulture));
    }
  }

  internal static Bitmap ToggleSwitchUp
  {
    get
    {
      return (Bitmap) RuntimeHelpers.GetObjectValue(Detonator.My.Resources.Resources.ResourceManager.GetObject(nameof (ToggleSwitchUp), Detonator.My.Resources.Resources.resourceCulture));
    }
  }
}
