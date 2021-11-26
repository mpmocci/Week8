using Equazioni_grado2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equazioni_grado2.WinForms
{
    public partial class Equazioni_grado2 : Form
    {
        Equation equazione = new Equation();
        double valueA, valueB, valueC;
        

        public Equazioni_grado2()
        {
            InitializeComponent();
        }

        private void tbB_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '.') && !(e.KeyChar == '-');
        }

        private void tbC_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '.') && !(e.KeyChar == '-');
        }

        private void btnAzzera_Click(object sender, EventArgs e)
        {
            tbA.Clear();
            tbB.Clear();
            tbC.Clear();
            tbRisultato.Clear();
        }

        private void tbA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '.') && !(e.KeyChar == '-');
        
        }


        private void btnCalcola_Click(object sender, EventArgs e)
        {
            valueA = double.Parse(tbA.Text);
            valueB = double.Parse(tbB.Text);
            valueC = double.Parse(tbC.Text);

            double[] result = equazione.RisolviEquazioneSecondoGrado(valueA, valueB, valueC);

            if (result == null)
            {

                tbRisultato.Text = "Equazione impossibile.";

               

            }

            else if(result.Length == 1)
            {
                string risultato = result[0].ToString();
                tbRisultato.Text = "x= " + risultato;

            }
     
            else if (result.Length == 2)
            {
                string risultato1 = result[0].ToString();
                string risultato2 = result[1].ToString();
                tbRisultato.Text = "x1= " + risultato1 + ", x2 = " + risultato2;
            }

        }


    }


}
