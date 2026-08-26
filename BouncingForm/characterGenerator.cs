// Decompiled with JetBrains decompiler
// Type: BouncingForm.characterGenerator
// Assembly: BouncingForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 70EF9BDA-F99B-498E-AD3F-2E6BE04A9BA7
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\BadJoke\BouncingForm\BouncingForm.exe

using System;

#nullable disable
namespace BouncingForm;

public class characterGenerator
{
  public static string gen()
  {
    Random random = new Random();
    char[] chArray = new char[96 /*0x60*/]
    {
      '☼',
      '◙',
      '♂',
      '♀',
      '♪',
      '♫',
      '►',
      '◄',
      '↕',
      '¶',
      '▬',
      '☺',
      '☻',
      '♥',
      '♦',
      '♣',
      '♠',
      '•',
      '◘',
      '○',
      '▲',
      '▼',
      'ž',
      'ř',
      'č',
      'é',
      'í',
      'ÿ',
      'ï',
      'ä',
      'ö',
      'ó',
      'š',
      'ě',
      '╚',
      '╔',
      '╩',
      '╠',
      '╬',
      '╧',
      '╤',
      '╥',
      '↑',
      '■',
      '±',
      '1',
      '2',
      '3',
      '4',
      '5',
      '6',
      '7',
      '8',
      '9',
      'œ',
      'Ÿ',
      '\u00BC',
      '\u00BD',
      '\u00BE',
      'ń',
      '£',
      '¤',
      '¥',
      'Â',
      '¢',
      'Æ',
      'Ç',
      '«',
      '¬',
      '®',
      'å',
      'ß',
      'ø',
      'õ',
      '×',
      'ñ',
      'æ',
      '√',
      'ε',
      '₧',
      'Σ',
      'σ',
      'µ',
      '█',
      '▄',
      '▌',
      '▐',
      '▀',
      '∞',
      'π',
      '≈',
      'φ',
      '\u00B2',
      '∩',
      '—',
      '™'
    };
    string str1 = "";
    for (int index = 0; index < 30; ++index)
    {
      string str2 = chArray[random.Next(chArray.Length)].ToString();
      str1 += str2;
    }
    return str1;
  }
}
