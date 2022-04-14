using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCPricer
{
    internal static class  Resfile
    {
        public static void RunPython(string script)
        {
            //Obtain the relative path of the program:
            string path = Environment.CurrentDirectory;
            path = path[..path.IndexOf("PCPricer")] + @"\PCPricer\scripts";

            //Start a new process to run cmd
            Process p = new();
            ProcessStartInfo pInfo = new()
            {
                FileName = "cmd.exe",           //File to open is cmd
                RedirectStandardInput = true,   //Redirect input to the program (rather than user input)
                UseShellExecute = false
            };

            //Strat the process:
            p.StartInfo = pInfo;
            p.Start();

            //Write to process as standard input (run commands in cmd):
            using StreamWriter sw = p.StandardInput;
            if (sw.BaseStream.CanWrite)
            {
                sw.WriteLine("cd " + path);         //Move to correct file location in cmd
                sw.WriteLine("python " + script);   //Run python script from cmd
            }
        }
    }
}
