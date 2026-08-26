// Decompiled with JetBrains decompiler
// Type: A.
// Assembly: InfiniteBlue, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 75787C59-6E69-48EC-8991-CFBDA71A3167
// Assembly location: C:\Users\adriel\Downloads\InfiniteBlue.exe

using System;
using System.Reflection;

#nullable disable
namespace A;

internal sealed class \u0012\u0012
{
  private static readonly Assembly \u001D;

  static \u0012\u0012()
  {
    AppDomain.CurrentDomain.ResourceResolve += new ResolveEventHandler(\u0012\u0012.\u0012);
    AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(\u0012\u0012.\u001D);
    \u0012\u0012.\u001D = Assembly.Load(\u0012\u0012.\u001D(Assembly.GetExecutingAssembly()));
  }

  internal static void \u001D() => \u0006\u0010.\u001D();

  private static Assembly \u001D(object _param0, ResolveEventArgs _param1)
  {
    return \u0002\u0010.\u001D(_param0, _param1);
  }

  private static string \u001D(Assembly _param0) => \u0001\u0010.\u001D(_param0);

  private static Assembly \u0012(object _param0, ResolveEventArgs _param1)
  {
    return \u000F\u0010.\u001D(_param0, _param1);
  }
}
