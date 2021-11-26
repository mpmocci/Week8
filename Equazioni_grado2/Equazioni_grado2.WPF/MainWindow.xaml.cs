using Equazioni_grado2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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


namespace Equazioni_grado2.WPF
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

        Equation equazione = new Equation();
        double valueA, valueB, valueC;

        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {
            valueA = double.Parse(txtA.Text);
            valueB = double.Parse(txtB.Text);
            valueC = double.Parse(txtC.Text);

            double[] result = equazione.RisolviEquazioneSecondoGrado(valueA, valueB, valueC);

            if (result == null)
            {

                txtRisultato.Text = "Equazione impossibile.";



            }

            else if (result.Length == 1)
            {
                string risultato = result[0].ToString();
                txtRisultato.Text = "Due soluzioni coincidenti: x= " + risultato;

            }

            else if (result.Length == 2)
            {
                string risultato1 = result[0].ToString();
                string risultato2 = result[1].ToString();
                txtRisultato.Text = "x= " + risultato1 + ", x = " + risultato2;
            }
        }

        private void btnAzzera_Click(object sender, RoutedEventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtRisultato.Clear();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"^-?[0-9]\d*\.{0,1}\d+$");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
