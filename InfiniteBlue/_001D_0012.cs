// Decompiled with JetBrains decompiler
// Type: A.
// Assembly: InfiniteBlue, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 75787C59-6E69-48EC-8991-CFBDA71A3167
// Assembly location: C:\Users\adriel\Downloads\InfiniteBlue.exe

using System;
using System.Reflection;
using System.Text;

#nullable disable
namespace A;

internal sealed class \u001D\u0012
{
  internal static readonly byte[] \u001D;
  internal readonly int \u001D;
  internal readonly int \u0012;

  static \u001D\u0012()
  {
    if (\u001D\u0012.\u001D != null)
      return;
    byte[] bytes = Convert.FromBase64String("SW5maW5pdGVCbHVlJQ==");
    string name = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
    \u001D\u0012.\u001D = \u000C.\u001D(97L, Assembly.GetExecutingAssembly().GetManifestResourceStream(name));
  }

  internal static int \u001D(int _param0) => BitConverter.ToInt32(\u001D\u0012.\u001D, _param0);

  internal static long \u001D(int _param0) => BitConverter.ToInt64(\u001D\u0012.\u001D, _param0);

  internal static float \u001D(int _param0) => BitConverter.ToSingle(\u001D\u0012.\u001D, _param0);

  internal static double \u001D(int _param0) => BitConverter.ToDouble(\u001D\u0012.\u001D, _param0);

  internal static void \u001D(Array _param0, int _param1)
  {
    int count;
    if (((int) \u001D\u0012.\u001D[_param1] & 128 /*0x80*/) == 0)
    {
      count = (int) \u001D\u0012.\u001D[_param1];
      ++_param1;
    }
    else if (((int) \u001D\u0012.\u001D[_param1] & 64 /*0x40*/) == 0)
    {
      count = ((int) \u001D\u0012.\u001D[_param1] & -129) << 8 | (int) \u001D\u0012.\u001D[_param1 + 1];
      _param1 += 2;
    }
    else
    {
      count = ((int) \u001D\u0012.\u001D[_param1] & -193) << 24 | (int) \u001D\u0012.\u001D[_param1 + 1] << 16 /*0x10*/ | (int) \u001D\u0012.\u001D[_param1 + 2] << 8 | (int) \u001D\u0012.\u001D[_param1 + 3];
      _param1 += 4;
    }
    if (count < 1)
      return;
    Buffer.BlockCopy((Array) \u001D\u0012.\u001D, _param1, _param0, 0, count);
  }
}
