using System.Diagnostics;
using System.Threading;

namespace Android_Emulator.Utility
{
    public static class Shell
    {
        public static void RunExternal(string processKey, string command, bool hideConsole)
        {
            Process p = new Process();
            Thread thread = new Thread(() => {
                // Redirect the output stream of the child process.
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.Arguments = "/C " + command;

                p.StartInfo.UseShellExecute = !hideConsole;
                p.StartInfo.CreateNoWindow = hideConsole;
                p.StartInfo.RedirectStandardOutput = hideConsole;


                p.Start();
                p.WaitForExit();
            });
            thread.Start();
        }

        public static string Run(string command, bool waitForProcessToEnd = false, Process activeProcess = null)
        {
            // Start the child process.
            Process p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/C " + command;
            p.StartInfo.CreateNoWindow = true;
            p.Start();

            activeProcess = p;

            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            if(waitForProcessToEnd)
                p.WaitForExit();
            // Read the output stream first and then wait.
            string output = p.StandardOutput.ReadToEnd();
            //p.WaitForExit();
            return output;
        }
    }
}
