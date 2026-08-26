// Decompiled with JetBrains decompiler
// Type: NeptuneRAT.My.InternalXmlHelper
// Assembly: NeptuneRAT Free Version V2, Version=2.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 48C579C5-C5A1-4244-9537-C19C9217B961
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Tools\NeptuneRAT\NeptuneRAT.7z\neptunerat.exe

using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

#nullable disable
namespace NeptuneRAT.My;

[Embedded]
[DebuggerNonUserCode]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
internal sealed class InternalXmlHelper
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  private InternalXmlHelper()
  {
  }

  public static string get_Value(IEnumerable<XElement> source)
  {
    IEnumerator<XElement> enumerator;
    string str;
    try
    {
      enumerator = source.GetEnumerator();
      if (enumerator.MoveNext())
      {
        str = enumerator.Current.Value;
        goto label_6;
      }
    }
    finally
    {
      enumerator?.Dispose();
    }
    str = (string) null;
label_6:
    return str;
  }

  public static void set_Value(IEnumerable<XElement> source, string value)
  {
    IEnumerator<XElement> enumerator;
    try
    {
      enumerator = source.GetEnumerator();
      if (!enumerator.MoveNext())
        return;
      enumerator.Current.Value = value;
    }
    finally
    {
      enumerator?.Dispose();
    }
  }
}
