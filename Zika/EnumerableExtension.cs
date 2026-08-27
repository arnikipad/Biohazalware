// Decompiled with JetBrains decompiler
// Type: EnumerableExtension
// Assembly: Zika, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C7CE6D81-E560-4B98-8463-4AED586D3B4E
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\GDI\Zika\Zika.exe

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public static class EnumerableExtension
{
  public static T PickRandom<T>(this IEnumerable<T> source) => source.PickRandom<T>(1).Single<T>();

  public static IEnumerable<T> PickRandom<T>(this IEnumerable<T> source, int count)
  {
    return source.Shuffle<T>().Take<T>(count);
  }

  public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
  {
    return (IEnumerable<T>) source.OrderBy<T, Guid>((Func<T, Guid>) (x => Guid.NewGuid()));
  }
}
