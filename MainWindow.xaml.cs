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
            try
            {
                //Try to run python script 'ppp.py' (ppp = pcpartpicker):
                Resfile.RunPython("ppp.py");

                //Inform user the action was completed successfully:
                Resfile.ActionComplete("Prices and details of all parts are being updated. Wait until comand prompt closes.", "Refresh Started");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured. " +               //Line 1 of message
                    "\nThe script could not be found?" +                        //Line 2 of message
                    "\n------------------------------------------\nDetails:" +  //Breaker and line 3 of message
                    "\n" + ex.Message);                                         //Exception details
            }
            
        }

        private void Btn_OpenSCR_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Try to run file explorer to scripts folder:
                Resfile.RunFileExp("scripts");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured. " +               //Line 1 of message
                    "\nThe folder location could not be found?" +               //Line 2 of message
                    "\n------------------------------------------\nDetails:" +  //Breaker and line 3 of message
                    "\n" + ex.Message);                                         //Exception details
            }
        }

        private void Btn_OpenDAT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Try to run file explorer to data folder:
                Resfile.RunFileExp("data");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occured. " +               //Line 1 of message
                    "\nThe folder location could not be found." +               //Line 2 of message
                    "\n------------------------------------------\nDetails:" +  //Breaker and line 3 of message
                    "\n" + ex.Message);                                         //Exception details
            }
        }

        private void Btn_ViewProducts_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_MarkALL_Click(object sender, RoutedEventArgs e)
        {
            //Remove selected items:
            Resfile.RemoveItems(Lv_Missing, true);
            Resfile.RemoveItems(Lv_PriceChg, true);

            //Inform user the action was completed successfully:
            Resfile.ActionComplete("All items in both lists have been removed successfully.", null);
        }

        private void Btn_MarkMissing_Click(object sender, RoutedEventArgs e)
        {
            //Remove selected items:
            Resfile.RemoveItems(Lv_Missing, true);

            //Inform user the action was completed successfully:
            Resfile.ActionComplete("All items in the Missing Part Updates list have been removed successfully.", null);
        }

        private void Btn_MarkPriceChg_Click(object sender, RoutedEventArgs e)
        {
            //Remove selected items:
            Resfile.RemoveItems(Lv_PriceChg, true);

            //Inform user the action was completed successfully:
            Resfile.ActionComplete("All items in the Price Change Updates list have been removed successfully.", null);
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
            //Remove selected items:
            Resfile.RemoveItems(Lv_Missing, false);

            //Inform user the action was completed successfully:
            Resfile.ActionComplete("Selected items in the Missing Part Updates list have been removed successfully.", null);
        }

        private void Btn_MarkSelectedPriceChg_Click(object sender, RoutedEventArgs e)
        {
            //Remove selected items:
            Resfile.RemoveItems(Lv_PriceChg, false);

            //Inform user the action was completed successfully:
            Resfile.ActionComplete("Selected items in the Price Change Updates list have been removed successfully.", null);
        }
    }
}
