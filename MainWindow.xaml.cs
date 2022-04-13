using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PCPricer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void run_cmd(string path, string[] cmd)
        {
            Process p = new Process();
            ProcessStartInfo pInfo = new ProcessStartInfo();
            pInfo.WindowStyle = ProcessWindowStyle.Hidden;
            pInfo.FileName = "cmd.exe";

            string args = "/C";
            foreach(string s in cmd)
            {
                args += s;
            }
            pInfo.Arguments = args;
            p.StartInfo = pInfo;
            p.Start();
        }
    }
}
