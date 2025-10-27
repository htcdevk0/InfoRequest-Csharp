namespace InfoRequest.Requests;
using System;
public class MachineInfo
{
    public static string RequestMachineName = Environment.MachineName;
    public static string RequestUserName = Environment.UserName;
    public static string RequestSystemDate = DateTime.Now.ToString();
    public static string RequestCurrentDirectory = Environment.CurrentDirectory;
    public static string RequestProcessorCount = Environment.ProcessorCount.ToString();
    public static string RequestUserDomain = Environment.UserDomainName;
}
