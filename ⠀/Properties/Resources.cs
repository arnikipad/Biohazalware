// Decompiled with JetBrains decompiler
// Type: HC.Properties.Resources
// Assembly: ⠀, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D0708EAF-DBFF-4047-8796-B1F7AB78F6FA
// Assembly location: \\VBOXSVR\B4s3\Private\⠀.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace HC.Properties;

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
      if (HC.Properties.Resources.resourceMan == null)
        HC.Properties.Resources.resourceMan = new ResourceManager("HC.Properties.Resources", typeof (HC.Properties.Resources).Assembly);
      return HC.Properties.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => HC.Properties.Resources.resourceCulture;
    set => HC.Properties.Resources.resourceCulture = value;
  }

  internal static UnmanagedMemoryStream homyak2
  {
    get => HC.Properties.Resources.ResourceManager.GetStream(nameof (homyak2), HC.Properties.Resources.resourceCulture);
  }
}
