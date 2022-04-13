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

        private void RunPython(string script)
        {
            string path = Environment.CurrentDirectory;
            path = path[..path.IndexOf("PCPicker")] + @"\PCPicker\scripts";

            Process p = new();
            ProcessStartInfo pInfo = new()
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = (@"/C cd \/C cd " + path + "/C python " + script)
            };

            p.StartInfo = pInfo;
            p.Start();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RunPython("test.py");
        }
    }
}
