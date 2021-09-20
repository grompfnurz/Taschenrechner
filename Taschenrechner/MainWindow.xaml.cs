using System;
using System.Collections.Generic;
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

namespace Taschenrechner
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

        private void TB_C_Click(object sender, RoutedEventArgs e)
        {
            TB_zahlenFeld.Text = "0";
        }

        private void TB_1_Click(object sender, RoutedEventArgs e)
        {
            if (TB_zahlenFeld.Text =="0")
            {
                TB_zahlenFeld.Text = "1";
            }
            else
            {
                TB_zahlenFeld.Text += "1";
            }
        }

        private void TB_2_Click(object sender, RoutedEventArgs e)
        {
            if (TB_zahlenFeld.Text == "0")
            {
                TB_zahlenFeld.Text = "2";
            }
            else
            {
                TB_zahlenFeld.Text += "2";
            }

        }

        private void TB_3_Click(object sender, RoutedEventArgs e)
        {
            if (TB_zahlenFeld.Text == "0")
            {
                TB_zahlenFeld.Text = "3";
            }
            else
            {
                TB_zahlenFeld.Text += "3";
            }

        }

        private void TB_4_Click(object sender, RoutedEventArgs e)
        {
            if (TB_zahlenFeld.Text == "0")
            {
                TB_zahlenFeld.Text = "4";
            }
            else
            {
                TB_zahlenFeld.Text += "4";
            }

        }

        private void TB_5_Click(object sender, RoutedEventArgs e)
        {
            if (TB_zahlenFeld.Text == "0")
            {
                TB_zahlenFeld.Text = "5";
            }
            else
            {
                TB_zahlenFeld.Text += "5";
            }

        }

        private void TB_6_Click(object sender, RoutedEventArgs e)
        {
            if (TB_zahlenFeld.Text == "0")
            {
                TB_zahlenFeld.Text = "6";
            }
            else
            {
                TB_zahlenFeld.Text += "6";
            }

        }

        private void TB_7_Click(object sender, RoutedEventArgs e)
        {
            if (TB_zahlenFeld.Text == "0")
            {
                TB_zahlenFeld.Text = "7";
            }
            else
            {
                TB_zahlenFeld.Text += "7";
            }

        }

        private void TB_8_Click(object sender, RoutedEventArgs e)
        {
            if (TB_zahlenFeld.Text == "0")
            {
                TB_zahlenFeld.Text = "8";
            }
            else
            {
                TB_zahlenFeld.Text += "8";
            }

        }

        private void TB_9_Click(object sender, RoutedEventArgs e)
        {
            if (TB_zahlenFeld.Text == "0")
            {
                TB_zahlenFeld.Text = "9";
            }
            else
            {
                TB_zahlenFeld.Text += "9";
            }

        }

        private void TB_0_Click(object sender, RoutedEventArgs e)
        {
            if (TB_zahlenFeld.Text == "0")
            {
                TB_zahlenFeld.Text = "0";
            }
            else
            {
                TB_zahlenFeld.Text += "0";
            }

        }

        private void TB_SdL_Click_1(object sender, RoutedEventArgs e)
        {
            if (TB_zahlenFeld.Text == "0")
            {
                TB_zahlenFeld.Text = "42";
            }
            else
            {
                TB_zahlenFeld.Text += "42";
            }
        }

        private void TB_Plus_Click(object sender, RoutedEventArgs e)
        {
            if (TB_zahlenFeld.Text == "0")
            {
                TB_zahlenFeld.Text = "0";
            }
            else
            {
                TB_zahlenFeld.Text += "+";
                TB_Operator.Text = "+";
                
            }
        }

        private void TB_Gleich_Click(object sender, RoutedEventArgs e)
        {
            string[] zahlen = TB_zahlenFeld.Text.Split(TB_Operator.Text);
            int zahl1 = Convert.ToInt32(zahlen[0]);
            int zahl2 = Convert.ToInt32(zahlen[1]);
            int erg=0;
            if (TB_Operator.Text == "+")
            {
                erg = zahl1 + zahl2;
            }
            else if (TB_Operator.Text=="-")
            {
                erg = zahl1 - zahl2;
            }
            else if (TB_Operator.Text=="*")
            {
                erg = zahl1 * zahl2;
            }
            else if (TB_Operator.Text == "/")
            {
                erg = zahl1 / zahl2;
            }



            string ergebnis = (erg.ToString());
            TB_zahlenFeld.Text = ergebnis;
            
        }

        private void TB_Minus_Click(object sender, RoutedEventArgs e)
        {

            if (TB_zahlenFeld.Text == "0")
            {
                TB_zahlenFeld.Text = "0";
            }
            else
            {
                TB_zahlenFeld.Text += "-";
                TB_Operator.Text = "-";

            }
        }

        private void TB_Mal_Click(object sender, RoutedEventArgs e)
        {
            if (TB_zahlenFeld.Text == "0")
            {
                TB_zahlenFeld.Text = "0";
            }
            else
            {
                TB_zahlenFeld.Text += "*";
                TB_Operator.Text = "*";

            }

        }

        private void TB_Geteilt_Click(object sender, RoutedEventArgs e)
        {
            if (TB_zahlenFeld.Text == "0")
            {
                TB_zahlenFeld.Text = "0";
            }
            else
            {
                TB_zahlenFeld.Text += "/";
                TB_Operator.Text = "/";

            }
        }
    }
}
