// Decompiled with JetBrains decompiler
// Type: Hydra.Properties.Resources
// Assembly: Hydra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FE967A65-D44D-4D25-B3F9-59D325AB8DF5
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\BadJoke\Endermanch@Hydra\Endermanch@Hydra.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace Hydra.Properties;

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
      if (Hydra.Properties.Resources.resourceMan == null)
        Hydra.Properties.Resources.resourceMan = new ResourceManager("Hydra.Properties.Resources", typeof (Hydra.Properties.Resources).Assembly);
      return Hydra.Properties.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => Hydra.Properties.Resources.resourceCulture;
    set => Hydra.Properties.Resources.resourceCulture = value;
  }

  internal static Bitmap hydra
  {
    get => (Bitmap) Hydra.Properties.Resources.ResourceManager.GetObject(nameof (hydra), Hydra.Properties.Resources.resourceCulture);
  }
}
