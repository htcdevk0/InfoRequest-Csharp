namespace InfoRequest.Requests;
using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Management;
using System.Diagnostics;
using System.Reflection;

public class DotNetInfo
{
    public static string RequestDotNetVersion = Environment.Version.ToString();
    public static string RequestDotNetVersionF = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;
    public static string RequestDotNetArchitecture = Environment.Is64BitProcess ? "x64" : "x86";
    public static string RequestDotNetBaseDirectory = AppContext.BaseDirectory;
    public static string RequestDotNetAssemblyLocation = typeof(object).Assembly.Location;
}
