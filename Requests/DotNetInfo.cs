namespace InfoRequest.Requests;

public class DotNetInfo
{
    public static string RequestDotNetVersion = Environment.Version.ToString();
    public static string RequestDotNetVersionF = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;
    public static string RequestDotNetArchitecture = Environment.Is64BitProcess ? "x64" : "x86";
    public static string RequestDotNetBaseDirectory = AppContext.BaseDirectory;
    public static string RequestDotNetAssemblyLocation = typeof(object).Assembly.Location;
}