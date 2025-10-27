namespace InfoRequest.Requests;
using System.Security.Principal;
using System;
public class UserInfoUse
{
    public static int RequestSystemUptime = Environment.TickCount;
    public static bool IsAdmin = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
}
