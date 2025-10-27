namespace InfoRequest.Requests;
using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Management;
using System.Diagnostics;
using System.Reflection;


public class HadwareInfo
{
    public static string RequestRamInfo = (GC.GetGCMemoryInfo().TotalAvailableMemoryBytes / (1024 * 1024)) + " MB";
}

public class RequestAdvancedHardware
{
    public static string RequestStorage()
    {
        string result = "";
        DriveInfo[] drives = DriveInfo.GetDrives();
        foreach (var d in drives)
        {
            if (d.IsReady)
                result += $"{d.Name} - Free: {d.TotalFreeSpace / (1024 * 1024)} MB{Environment.NewLine}";
        }
        return result;
    }
}
