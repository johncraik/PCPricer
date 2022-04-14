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

        private void Btn_Refresh_Click(object sender, RoutedEventArgs e)
        {
            //Run python script 'ppp.py' (ppp = pcpartpicker)
            Resfile.RunPython("ppp.py");
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
            if(MessageBox.Show("Are you sure you want to quit?",    //Message
                "Quit Application?",                                //Title
                MessageBoxButton.YesNo,                             //Buttons
                MessageBoxImage.Question)                           //Image
                == MessageBoxResult.Yes)                            //Result condition
            {
                //If they press yes, quit (if no, do nothing):
                this.Close();
            }
        }

        private void Btn_MarkSelectedMissing_Click(object sender, RoutedEventArgs e)
        {
            ItemCollection items = Lv_Missing.Items;
            List<ListViewItem> lvi = new List<ListViewItem>();
            foreach(ListViewItem item in items)
            {
                if (item.IsSelected)
                {
                    lvi.Add(item);
                }

            }

            MessageBox.Show("Items selected: " + lvi.Count);
        }

        private void Btn_MarkSelectedPriceChg_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
