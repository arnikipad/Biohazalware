// Decompiled with JetBrains decompiler
// Type: A.
// Assembly: InfiniteBlue, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 75787C59-6E69-48EC-8991-CFBDA71A3167
// Assembly location: C:\Users\adriel\Downloads\InfiniteBlue.exe

using System;
using System.Reflection;
using System.Text;

#nullable disable
namespace A;

internal sealed class \u0017
{
  internal static readonly byte[] \u001D;
  internal readonly int \u001D;

  static \u0017()
  {
    if (\u0017.\u001D != null)
      return;
    byte[] bytes = Convert.FromBase64String("SW5maW5pdGVCbHVlJA==");
    string name = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
    \u0017.\u001D = \u000C.\u001D(97L, Assembly.GetExecutingAssembly().GetManifestResourceStream(name));
  }

  internal static string \u001D(int _param0)
  {
    int count;
    if (((int) \u0017.\u001D[_param0] & 128 /*0x80*/) == 0)
    {
      count = (int) \u0017.\u001D[_param0];
      ++_param0;
    }
    else if (((int) \u0017.\u001D[_param0] & 64 /*0x40*/) == 0)
    {
      count = ((int) \u0017.\u001D[_param0] & -129) << 8 | (int) \u0017.\u001D[_param0 + 1];
      _param0 += 2;
    }
    else
    {
      count = ((int) \u0017.\u001D[_param0] & -193) << 24 | (int) \u0017.\u001D[_param0 + 1] << 16 /*0x10*/ | (int) \u0017.\u001D[_param0 + 2] << 8 | (int) \u0017.\u001D[_param0 + 3];
      _param0 += 4;
    }
    return count < 1 ? string.Empty : string.Intern(Encoding.Unicode.GetString(\u0017.\u001D, _param0, count));
  }
}
