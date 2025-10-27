namespace InfoRequest.Requests;
using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Management;
using System.Diagnostics;
using System.Reflection;

public class OSInfo
{
    public static string RequestOS = Environment.OSVersion.ToString();
    public static string RequestOSFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    public static string RequestSystemArchitecture = Environment.Is64BitOperatingSystem ? "x64" : "x86";
    public static string ReqyestProgramFilesFolder = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
    public static string ReqyestDesktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
}
