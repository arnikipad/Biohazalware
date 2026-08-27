// Decompiled with JetBrains decompiler
// Type: Zika.Properties.Resources
// Assembly: Zika, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C7CE6D81-E560-4B98-8463-4AED586D3B4E
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\GDI\Zika\Zika.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace Zika.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
      if (Zika.Properties.Resources.resourceMan == null)
        Zika.Properties.Resources.resourceMan = new ResourceManager("Zika.Properties.Resources", typeof (Zika.Properties.Resources).Assembly);
      return Zika.Properties.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => Zika.Properties.Resources.resourceCulture;
    set => Zika.Properties.Resources.resourceCulture = value;
  }

  internal static byte[] AxInterop_WMPLib
  {
    get
    {
      return (byte[]) Zika.Properties.Resources.ResourceManager.GetObject(nameof (AxInterop_WMPLib), Zika.Properties.Resources.resourceCulture);
    }
  }

  internal static UnmanagedMemoryStream beep
  {
    get => Zika.Properties.Resources.ResourceManager.GetStream(nameof (beep), Zika.Properties.Resources.resourceCulture);
  }

  internal static byte[] Interop_WMPLib
  {
    get
    {
      return (byte[]) Zika.Properties.Resources.ResourceManager.GetObject(nameof (Interop_WMPLib), Zika.Properties.Resources.resourceCulture);
    }
  }

  internal static UnmanagedMemoryStream NavaShield_Delete_C
  {
    get
    {
      return Zika.Properties.Resources.ResourceManager.GetStream(nameof (NavaShield_Delete_C), Zika.Properties.Resources.resourceCulture);
    }
  }

  internal static UnmanagedMemoryStream NavaShield_Laugh_1
  {
    get
    {
      return Zika.Properties.Resources.ResourceManager.GetStream(nameof (NavaShield_Laugh_1), Zika.Properties.Resources.resourceCulture);
    }
  }

  internal static UnmanagedMemoryStream NavaShield_Laugh_2
  {
    get
    {
      return Zika.Properties.Resources.ResourceManager.GetStream(nameof (NavaShield_Laugh_2), Zika.Properties.Resources.resourceCulture);
    }
  }

  internal static UnmanagedMemoryStream pig
  {
    get => Zika.Properties.Resources.ResourceManager.GetStream(nameof (pig), Zika.Properties.Resources.resourceCulture);
  }

  internal static byte[] ResHacker
  {
    get
    {
      return (byte[]) Zika.Properties.Resources.ResourceManager.GetObject(nameof (ResHacker), Zika.Properties.Resources.resourceCulture);
    }
  }

  internal static byte[] ResourceHacker
  {
    get
    {
      return (byte[]) Zika.Properties.Resources.ResourceManager.GetObject(nameof (ResourceHacker), Zika.Properties.Resources.resourceCulture);
    }
  }
}
