using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

        private static void RunPython(string script)
        {
            string path = Environment.CurrentDirectory;
            path = path[..path.IndexOf("PCPricer")] + @"\PCPricer\scripts";

            Process p = new();
            ProcessStartInfo pInfo = new()
            {
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                UseShellExecute = false
            };

            p.StartInfo = pInfo;
            p.Start();

            using StreamWriter sw = p.StandardInput;
            if (sw.BaseStream.CanWrite)
            {
                sw.WriteLine("cd " + path);
                sw.WriteLine("python " + script);
            }
        }

        private void Btn_Refresh_Click(object sender, RoutedEventArgs e)
        {
            RunPython("ppp.py");
        }

        private void Btn_OpenSCR_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_OpenDAT_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_ViewProducts_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_MarkALL_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_MarkMissing_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_MarkPriceChg_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Help_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Quit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_MarkSelectedMissing_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_MarkSelectedPriceChg_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
