namespace InfoRequest.Requests;
using System.Diagnostics;
using System;

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
