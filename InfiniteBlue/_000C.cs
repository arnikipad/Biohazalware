// Decompiled with JetBrains decompiler
// Type: A.
// Assembly: InfiniteBlue, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 75787C59-6E69-48EC-8991-CFBDA71A3167
// Assembly location: C:\Users\adriel\Downloads\InfiniteBlue.exe

using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;

#nullable disable
namespace A;

internal sealed class \u000C
{
  private static readonly object \u001D;
  private static readonly int \u001D;
  private static readonly int \u0012;
  private static readonly MemoryStream \u001D = (MemoryStream) null;
  private static readonly MemoryStream \u0012 = (MemoryStream) null;
  private static readonly byte \u001D;

  static \u000C()
  {
    \u000C.\u001D = int.MaxValue;
    \u000C.\u0012 = int.MinValue;
    \u000C.\u001D = new MemoryStream(0);
    \u000C.\u0012 = new MemoryStream(0);
    \u000C.\u001D = new object();
  }

  private static string \u001D(Assembly _param0)
  {
    string str = _param0.FullName;
    int length = str.IndexOf(',');
    if (length >= 0)
      str = str.Substring(0, length);
    return str;
  }

  private static byte[] \u001D(Assembly _param0)
  {
    try
    {
      string fullName = _param0.FullName;
      int num1 = fullName.IndexOf("PublicKeyToken=");
      if (num1 < 0)
        num1 = fullName.IndexOf("publickeytoken=");
      if (num1 < 0)
        return (byte[]) null;
      int num2 = num1 + 15;
      if (fullName[num2] == 'n' || fullName[num2] == 'N')
        return (byte[]) null;
      byte[] bytes = BitConverter.GetBytes(long.Parse(fullName.Substring(num2, 16 /*0x10*/), NumberStyles.HexNumber));
      Array.Reverse((Array) bytes);
      return bytes;
    }
    catch
    {
    }
    return (byte[]) null;
  }

  internal static byte[] \u001D(Stream _param0)
  {
    lock (\u000C.\u001D)
      return \u000C.\u001D(97L, (object) _param0);
  }

  internal static byte[] \u001D(long _param0, Stream _param1)
  {
    try
    {
      return \u000C.\u001D(_param1);
    }
    catch
    {
      return \u000C.\u001D(97L, (object) _param1);
    }
  }

  internal static byte[] \u001D(long _param0, object _param1)
  {
    Stream stream1 = _param1 as Stream;
    Stream stream2 = stream1;
    MemoryStream memoryStream = (MemoryStream) null;
    for (int index = 1; index < 4; ++index)
      stream1.ReadByte();
    ushort num1 = ~(ushort) stream1.ReadByte();
    if (((int) num1 & 2) != 0)
    {
      DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider();
      byte[] buffer1 = new byte[8];
      stream1.Read(buffer1, 0, 8);
      cryptoServiceProvider.IV = buffer1;
      byte[] buffer2 = new byte[8];
      stream1.Read(buffer2, 0, 8);
      bool flag = true;
      foreach (byte num2 in buffer2)
      {
        if (num2 != (byte) 0)
        {
          flag = false;
          break;
        }
      }
      if (flag)
        buffer2 = \u000C.\u001D(Assembly.GetExecutingAssembly());
      cryptoServiceProvider.Key = buffer2;
      if (\u000C.\u001D == null)
        \u000C.\u001D.Capacity = \u000C.\u001D != int.MaxValue ? \u000C.\u001D : (int) stream1.Length;
      \u000C.\u001D.Position = 0L;
      ICryptoTransform decryptor = cryptoServiceProvider.CreateDecryptor();
      int inputBlockSize = decryptor.InputBlockSize;
      int outputBlockSize = decryptor.OutputBlockSize;
      byte[] numArray1 = new byte[decryptor.OutputBlockSize];
      byte[] numArray2 = new byte[decryptor.InputBlockSize];
      int position;
      for (position = (int) stream1.Position; (long) (position + inputBlockSize) < stream1.Length; position += inputBlockSize)
      {
        stream1.Read(numArray2, 0, inputBlockSize);
        int count = decryptor.TransformBlock(numArray2, 0, inputBlockSize, numArray1, 0);
        \u000C.\u001D.Write(numArray1, 0, count);
      }
      stream1.Read(numArray2, 0, (int) (stream1.Length - (long) position));
      byte[] buffer3 = decryptor.TransformFinalBlock(numArray2, 0, (int) (stream1.Length - (long) position));
      \u000C.\u001D.Write(buffer3, 0, buffer3.Length);
      stream2 = (Stream) \u000C.\u001D;
      stream2.Position = 0L;
      memoryStream = \u000C.\u001D;
    }
    if (((int) num1 & 8) != 0)
    {
      if (\u000C.\u0012 == null)
        \u000C.\u0012.Capacity = \u000C.\u0012 != int.MinValue ? \u000C.\u0012 : (int) stream2.Length * 2;
      \u000C.\u0012.Position = 0L;
      DeflateStream deflateStream = new DeflateStream(stream2, CompressionMode.Decompress);
      int count1 = 1000;
      byte[] buffer = new byte[count1];
      int count2;
      do
      {
        count2 = deflateStream.Read(buffer, 0, count1);
        if (count2 > 0)
          \u000C.\u0012.Write(buffer, 0, count2);
      }
      while (count2 >= count1);
      memoryStream = \u000C.\u0012;
    }
    if (memoryStream != null)
      return memoryStream.ToArray();
    byte[] buffer4 = new byte[stream1.Length - stream1.Position];
    stream1.Read(buffer4, 0, buffer4.Length);
    return buffer4;
  }
}
