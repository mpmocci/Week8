using Calcolatrice.Core;
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

namespace Calcolatrice.Wpf
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


        double valueA;
        double valueB;
        string operation;
        Calculator c = new Calculator();


        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += btn1.Content;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += btn2.Content;

        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += btn3.Content;

        }

        

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += btn4.Content;

        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += btn5.Content;

        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += btn6.Content;

        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += btn7.Content;

        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += btn8.Content;

        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += btn9.Content;

        }

        private void btnComma_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += btnComma.Content;

        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            textValue.Text += btn0.Content;

        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            textValue.Clear();

        }

        private void SetOperation(string contentValue, string operationToDo)
        {
            valueA = double.Parse(contentValue);
            operation = operationToDo;
            textValue.Clear();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            SetOperation(textValue.Text, "somma");

        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            SetOperation(textValue.Text, "sottrazione");

        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            SetOperation(textValue.Text, "moltiplicazione");

        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            SetOperation(textValue.Text, "divisione");

        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            valueB = string.IsNullOrEmpty(textValue.Text) ? 0 : double.Parse(textValue.Text);

            switch (operation)
            {
                case "somma":
                    textValue.Text = c.SommaNumeri(valueA, valueB).ToString();
                    break;

                case "sottrazione":
                    textValue.Text = c.SottraiNumeri(valueA, valueB).ToString();
                    break;

                case "moltiplicazione":
                    textValue.Text = c.MoltiplicaNumeri(valueA, valueB).ToString();
                    break;

                case "divisione":

                    var risultato = c.DividiNumeri(valueA, valueB);
                    textValue.Text = (risultato == null) ? "errore" : risultato.ToString();


                    break;
            }

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
