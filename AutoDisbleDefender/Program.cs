using System.Diagnostics;

namespace AutoDisbleDefender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetEnviromentVariable();
        }

        static void GetEnviromentVariable()
        {
            string path =Environment.GetEnvironmentVariable("\\HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", EnvironmentVariableTarget.Machine);
            bool existsInMachine = CheckEnvironmentVariable("DisableAntiSpyware", EnvironmentVariableTarget.Machine);
            if (!existsInMachine)
            {
                SetEnviromentVariable();
            }
            else
            {
                Console.WriteLine("OK");
            }
        }

        static void SetEnviromentVariable()
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/c reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\" /v DisableAntiSpyware /t REG_DWORD /d 1 /f";
                process.Start();
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

        public static bool CheckEnvironmentVariable(string variableName, EnvironmentVariableTarget target)
        {
            try
            {
                string value = Environment.GetEnvironmentVariable(variableName, target);
                return !string.IsNullOrEmpty(value);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to check environment variable '{variableName}' in scope {target}", ex);
            }
        }
    }
}
