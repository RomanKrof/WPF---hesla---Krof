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
using System.Text.RegularExpressions;
using System.Threading;

namespace WPF___hesla___Krof
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        static Regex reg = new Regex(@"\d");

        private void But_Click(object sender, RoutedEventArgs e)
        {
            if (Jmeno.Text != "")
            {
                if (Heslo.Text != "")
                {
                    if (Heslo.Text.Length >= 6)
                    {
                        if (reg.IsMatch(Heslo.Text))
                        {
                            Konec.Text = "Bylo zadáno správné jméno a heslo, zmáčkněte tlačítko Vypnout k vypnutí.";
                        }

                        else
                        {
                            Konec.Text = "Heslo neobsahuje číslici!";
                        }
                    }

                    else
                    {
                        Konec.Text = "Heslo je příliš krátké!";
                    }
                }

                else
                {
                    Konec.Text = "Nebylo zadáno heslo!";
                }
            }

            else
            {
                Konec.Text = "Nebylo zadáno jméno!";
            }
        }

        private void ButKon_Click(object sender, RoutedEventArgs e)
        {
            if (reg.IsMatch(Heslo.Text) && Jmeno.Text != "")
            {
                this.Close();
            }

            else { }
        }
    }
}
