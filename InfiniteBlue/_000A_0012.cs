// Decompiled with JetBrains decompiler
// Type: A.

// Assembly: InfiniteBlue, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 75787C59-6E69-48EC-8991-CFBDA71A3167
// Assembly location: C:\Users\adriel\Downloads\InfiniteBlue.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

#nullable disable
namespace A;

internal sealed class \u000A\u0012
{
  internal static readonly byte[] \u001D;
  internal static readonly Dictionary<int, int> \u001D;
  private static readonly ModuleHandle \u001D;
  internal readonly int \u001D;

  static \u000A\u0012()
  {
    if (\u000A\u0012.\u001D == null)
    {
      byte[] bytes = Convert.FromBase64String("SW5maW5pdGVCbHVlKg==");
      string name = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
      \u000A\u0012.\u001D = \u000C.\u001D(97L, Assembly.GetExecutingAssembly().GetManifestResourceStream(name));
      \u000A\u0012.\u001D = new Dictionary<int, int>();
      using (BinaryReader binaryReader = new BinaryReader((Stream) new MemoryStream(\u000A\u0012.\u001D, false)))
      {
        int num1 = binaryReader.ReadInt32();
        for (int index = 0; index < num1; ++index)
        {
          int key = binaryReader.ReadInt32();
          int num2 = binaryReader.ReadInt32();
          \u000A\u0012.\u001D[key] = num2;
        }
      }
    }
    if ((object) typeof (MulticastDelegate) == null)
      return;
    \u000A\u0012.\u001D = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
  }

  internal static void \u001D(int _param0, int _param1, int _param2)
  {
    Type typeFromHandle;
    MethodBase methodFromHandle;
    try
    {
      typeFromHandle = Type.GetTypeFromHandle(\u000A\u0012.\u001D.ResolveTypeHandle(_param0));
      methodFromHandle = MethodBase.GetMethodFromHandle(\u000A\u0012.\u001D.ResolveMethodHandle(_param1), \u000A\u0012.\u001D.ResolveTypeHandle(_param2));
    }
    catch (Exception ex)
    {
      throw;
    }
    foreach (FieldInfo field in typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField))
    {
      try
      {
        MethodBody methodBody = methodFromHandle.GetMethodBody();
        Type[] parameterTypes = \u000A\u0012.\u001D(methodFromHandle);
        DynamicMethod dynamicMethod = new DynamicMethod($"{methodFromHandle.DeclaringType.FullName}.{methodFromHandle.Name}_Encrypted$", (object) (methodFromHandle as ConstructorInfo) != null ? (Type) null : ((MethodInfo) methodFromHandle).ReturnType, parameterTypes, methodFromHandle.DeclaringType, true);
        int num;
        \u000A\u0012.\u001D.TryGetValue(_param0, out num);
        DynamicILInfo dynamicIlInfo = dynamicMethod.GetDynamicILInfo();
        \u000A\u0012.\u001D(methodBody, dynamicIlInfo);
        \u000A\u0012.\u001D(ref num, methodFromHandle, dynamicIlInfo);
        \u000A\u0012.\u001D(ref num, dynamicIlInfo);
        Delegate @delegate = dynamicMethod.CreateDelegate(typeFromHandle);
        field.SetValue((object) null, (object) @delegate);
      }
      catch (Exception ex)
      {
      }
    }
  }

  private static void \u001D(ref int _param0, MethodBase _param1, DynamicILInfo _param2)
  {
    int int32_1 = BitConverter.ToInt32(\u000A\u0012.\u001D, _param0);
    _param0 += 4;
    int int32_2 = BitConverter.ToInt32(\u000A\u0012.\u001D, _param0);
    _param0 += 4;
    byte[] numArray = new byte[int32_2];
    Buffer.BlockCopy((Array) \u000A\u0012.\u001D, _param0, (Array) numArray, 0, int32_2);
    new \u000A\u0012.\u0010\u0012(_param1, numArray, _param2).\u001D();
    _param2.SetCode(numArray, int32_1);
    _param0 += int32_2;
  }

  private static void \u001D(MethodBody _param0, DynamicILInfo _param1)
  {
    SignatureHelper localVarSigHelper = SignatureHelper.GetLocalVarSigHelper();
    foreach (LocalVariableInfo localVariable in (IEnumerable<LocalVariableInfo>) _param0.LocalVariables)
      localVarSigHelper.AddArgument(localVariable.LocalType, localVariable.IsPinned);
    _param1.SetLocalSignature(localVarSigHelper.GetSignature());
  }

  private static void \u001D(ref int _param0, DynamicILInfo _param1)
  {
    int int32_1 = BitConverter.ToInt32(\u000A\u0012.\u001D, _param0);
    _param0 += 4;
    if (int32_1 == 0)
      return;
    byte[] numArray = new byte[int32_1];
    Buffer.BlockCopy((Array) \u000A\u0012.\u001D, _param0, (Array) numArray, 0, int32_1);
    int startIndex1 = 4;
    int num = (int32_1 - 4) / 24;
    for (int index = 0; index < num; ++index)
    {
      ExceptionHandlingClauseOptions int32_2 = (ExceptionHandlingClauseOptions) BitConverter.ToInt32(numArray, startIndex1);
      int startIndex2 = startIndex1 + 20;
      switch (int32_2)
      {
        case ExceptionHandlingClauseOptions.Clause:
          RuntimeTypeHandle type = \u000A\u0012.\u001D.ResolveTypeHandle(BitConverter.ToInt32(numArray, startIndex2));
          \u000A\u0012.\u001D(_param1.GetTokenFor(type), startIndex2, numArray);
          break;
        case ExceptionHandlingClauseOptions.Fault:
          throw new NotSupportedException("dynamic method does not support fault clause");
      }
      startIndex1 = startIndex2 + 4;
    }
    _param1.SetExceptions(numArray);
  }

  public static void \u001D(int _param0, int _param1, byte[] _param2)
  {
    _param2[_param1++] = (byte) _param0;
    _param2[_param1++] = (byte) (_param0 >> 8);
    _param2[_param1++] = (byte) (_param0 >> 16 /*0x10*/);
    _param2[_param1++] = (byte) (_param0 >> 24);
  }

  private static Type[] \u001D(MethodBase _param0)
  {
    ParameterInfo[] parameters = _param0.GetParameters();
    int length = parameters.Length;
    if (!_param0.IsStatic)
      ++length;
    Type[] typeArray = new Type[length];
    int index1 = 0;
    if (!_param0.IsStatic)
    {
      typeArray[0] = !_param0.DeclaringType.IsValueType ? _param0.DeclaringType : _param0.DeclaringType.MakeByRefType();
      ++index1;
    }
    int index2 = 0;
    while (index2 < parameters.Length)
    {
      typeArray[index1] = parameters[index2].ParameterType;
      ++index2;
      ++index1;
    }
    return typeArray;
  }

  public sealed class \u0010\u0012
  {
    private static OpCode[] \u001D = new OpCode[256 /*0x0100*/];
    private static OpCode[] \u0012 = new OpCode[256 /*0x0100*/];
    private int \u001D;
    private byte[] \u001D;
    private DynamicILInfo \u001D;
    private Module \u001D;
    private Type[] \u001D;
    private Type[] \u0012;

    static \u0010\u0012()
    {
      foreach (FieldInfo field in typeof (OpCodes).GetFields(BindingFlags.Static | BindingFlags.Public))
      {
        OpCode opCode = (OpCode) field.GetValue((object) null);
        ushort index = (ushort) opCode.Value;
        if (index < (ushort) 256 /*0x0100*/)
          \u000A\u0012.\u0010\u0012.\u001D[(int) index] = opCode;
        else if (((int) index & 65280) == 65024)
          \u000A\u0012.\u0010\u0012.\u0012[(int) index & (int) byte.MaxValue] = opCode;
      }
    }

    public \u0010\u0012(MethodBase _param1, byte[] _param2, DynamicILInfo _param3)
    {
      this.\u001D = _param3;
      this.\u001D = _param2;
      this.\u001D = 0;
      this.\u001D = _param1.Module;
      this.\u001D = (object) (_param1 as ConstructorInfo) != null ? (Type[]) null : _param1.GetGenericArguments();
      this.\u0012 = (object) _param1.DeclaringType == null ? (Type[]) null : _param1.DeclaringType.GetGenericArguments();
    }

    internal void \u001D()
    {
      while (this.\u001D < this.\u001D.Length)
        this.\u001D();
    }

    private object \u001D()
    {
      int num = this.\u001D;
      OpCode nop = OpCodes.Nop;
      byte index1 = this.\u001D();
      OpCode opCode;
      if (index1 != (byte) 254)
      {
        opCode = \u000A\u0012.\u0010\u0012.\u001D[(int) index1];
      }
      else
      {
        byte index2 = this.\u001D();
        opCode = \u000A\u0012.\u0010\u0012.\u0012[(int) index2];
      }
      switch (opCode.OperandType)
      {
        case OperandType.InlineBrTarget:
          this.\u001D(4);
          return (object) null;
        case OperandType.InlineField:
          this.\u0012(this.\u001D.GetTokenFor(this.\u001D.ResolveField(this.\u001D(), this.\u0012, this.\u001D).FieldHandle), num + opCode.Size);
          return (object) null;
        case OperandType.InlineI:
          this.\u001D(4);
          return (object) null;
        case OperandType.InlineI8:
          this.\u001D(8);
          return (object) null;
        case OperandType.InlineMethod:
          MethodBase methodBase1 = this.\u001D.ResolveMethod(this.\u001D(), this.\u0012, this.\u001D);
          this.\u0012(this.\u001D.GetTokenFor(methodBase1.MethodHandle, methodBase1.DeclaringType.TypeHandle), num + opCode.Size);
          return (object) null;
        case OperandType.InlineNone:
          return (object) null;
        case OperandType.InlineR:
          this.\u001D(8);
          return (object) null;
        case OperandType.InlineSig:
          this.\u0012(this.\u001D.GetTokenFor(this.\u001D.ResolveSignature(this.\u001D())), num + opCode.Size);
          return (object) null;
        case OperandType.InlineString:
          this.\u0012(this.\u001D.GetTokenFor(this.\u001D.ResolveString(this.\u001D())), num + opCode.Size);
          return (object) null;
        case OperandType.InlineSwitch:
          this.\u001D(this.\u001D() * 4);
          return (object) null;
        case OperandType.InlineTok:
          int metadataToken = this.\u001D();
          MemberInfo memberInfo = this.\u001D.ResolveMember(metadataToken, this.\u0012, this.\u001D);
          if (memberInfo.MemberType == MemberTypes.TypeInfo || memberInfo.MemberType == MemberTypes.NestedType)
            metadataToken = this.\u001D.GetTokenFor((memberInfo as Type).TypeHandle);
          else if (memberInfo.MemberType == MemberTypes.Method || memberInfo.MemberType == MemberTypes.Constructor)
          {
            MethodBase methodBase2 = memberInfo as MethodBase;
            metadataToken = this.\u001D.GetTokenFor(methodBase2.MethodHandle, methodBase2.DeclaringType.TypeHandle);
          }
          else if (memberInfo.MemberType == MemberTypes.Field)
            metadataToken = this.\u001D.GetTokenFor((memberInfo as FieldInfo).FieldHandle);
          this.\u0012(metadataToken, num + opCode.Size);
          return (object) null;
        case OperandType.InlineType:
          this.\u0012(this.\u001D.GetTokenFor(this.\u001D.ResolveType(this.\u001D(), this.\u0012, this.\u001D).TypeHandle), num + opCode.Size);
          return (object) null;
        case OperandType.InlineVar:
          this.\u001D(2);
          return (object) null;
        case OperandType.ShortInlineBrTarget:
          this.\u001D(1);
          return (object) null;
        case OperandType.ShortInlineI:
          this.\u001D(1);
          return (object) null;
        case OperandType.ShortInlineR:
          this.\u001D(4);
          return (object) null;
        case OperandType.ShortInlineVar:
          this.\u001D(1);
          return (object) null;
        default:
          throw new BadImageFormatException("unexpected OperandType " + (object) opCode.OperandType);
      }
    }

    private void \u001D(int _param1) => this.\u001D += _param1;

    private byte \u001D() => this.\u001D[this.\u001D++];

    private int \u001D()
    {
      int startIndex = this.\u001D;
      this.\u001D += 4;
      return BitConverter.ToInt32(this.\u001D, startIndex);
    }

    private void \u0012(int _param1, int _param2)
    {
      this.\u001D[_param2++] = (byte) _param1;
      this.\u001D[_param2++] = (byte) (_param1 >> 8);
      this.\u001D[_param2++] = (byte) (_param1 >> 16 /*0x10*/);
      this.\u001D[_param2++] = (byte) (_param1 >> 24);
    }
  }
}
