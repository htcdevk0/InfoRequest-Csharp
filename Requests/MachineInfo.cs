namespace InfoRequest.Requests;
using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Management;
using System.Diagnostics;
using System.Reflection;

public class MachineInfo
{
    public static string RequestMachineName = Environment.MachineName;
    public static string RequestUserName = Environment.UserName;
    public static string RequestSystemDate = DateTime.Now.ToString();
    public static string RequestCurrentDirectory = Environment.CurrentDirectory;
    public static string RequestProcessorCount = Environment.ProcessorCount.ToString();
    public static string RequestUserDomain = Environment.UserDomainName;
}
