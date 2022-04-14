using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PCPricer
{
    internal static class  Resfile
    {
        //Relative path of program:
        private static readonly string initialPath = Environment.CurrentDirectory;
        private static readonly string projectPath = initialPath[..initialPath.IndexOf("PCPricer")] + @"PCPricer";

        public static void RunPython(string script)
        {
            //Obtain the relative path of the program:
            string path = projectPath + @"\scripts";

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

        public static void RunFileExp(string fld)
        {
            //Set the folder to open:
            string path = projectPath + @"\" + fld;

            //Open file explorer to path defined above:
            Process.Start("explorer.exe", path);
        }

        public static void RemoveItems(ListView lv, bool ALL)
        {
            //ALL items:
            if (ALL)
            {
                //If all items are to be removed, clear list view and retrun.
                lv.Items.Clear();
                return;
            }

            //ONLY items selected:
            foreach(ListViewItem i in lv.SelectedItems)
            {
                //For all items selected, remove them:
                lv.Items.Remove(i);
            }
        }
    }
}
