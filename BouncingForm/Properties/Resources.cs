// Decompiled with JetBrains decompiler
// Type: BouncingForm.Properties.Resources
// Assembly: BouncingForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 70EF9BDA-F99B-498E-AD3F-2E6BE04A9BA7
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\BadJoke\BouncingForm\BouncingForm.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace BouncingForm.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
      if (BouncingForm.Properties.Resources.resourceMan == null)
        BouncingForm.Properties.Resources.resourceMan = new ResourceManager("BouncingForm.Properties.Resources", typeof (BouncingForm.Properties.Resources).Assembly);
      return BouncingForm.Properties.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => BouncingForm.Properties.Resources.resourceCulture;
    set => BouncingForm.Properties.Resources.resourceCulture = value;
  }

  internal static Bitmap emblem_256
  {
    get
    {
      return (Bitmap) BouncingForm.Properties.Resources.ResourceManager.GetObject(nameof (emblem_256), BouncingForm.Properties.Resources.resourceCulture);
    }
  }
}
