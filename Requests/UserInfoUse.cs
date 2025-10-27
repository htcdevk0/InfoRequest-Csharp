namespace InfoRequest.Requests;
using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Management;
using System.Diagnostics;
using System.Reflection;

public class UserInfoUse
{
    public static int RequestSystemUptime = Environment.TickCount;
    public static bool IsAdmin = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
}
