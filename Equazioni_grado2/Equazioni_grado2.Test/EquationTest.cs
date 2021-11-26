using Equazioni_grado2.Core;
using System;
using Xunit;

namespace Equazioni_grado2.Test
{
    public class EquationTest
    {
        [Fact]
        public void Test1() //iniziano con Should
        {

            //ARRANGE:predisposizione/prerequisiti
            double a = 1, b = -3, c = 2;
            Equation equazione = new Equation();

            //ACT: chiamata alla funzionalità da testare
           double[] risultato= equazione.RisolviEquazioneSecondoGrado(a, b, c);



            //ASSERT: valutazione del risultato
            Assert.True(risultato.Length == 2); //lunghezza dell'array risultato
            Assert.Equal(1, risultato[0]);
            Assert.Equal(2, risultato[1]);



        }
        [Fact]
        public void Test2() //iniziano con Should
        {

            //ARRANGE:predisposizione/prerequisiti
            double a = 1, b = -5, c = 6;
            Equation equazione = new Equation();

            //ACT: chiamata alla funzionalità da testare
            double[] risultato = equazione.RisolviEquazioneSecondoGrado(a, b, c);



            //ASSERT: valutazione del risultato
            Assert.True(risultato.Length == 2); //lunghezza dell'array risultato
            Assert.Equal(2, risultato[0]);
            Assert.Equal(3, risultato[1]);



        }
        [Fact]
        public void Test3() //iniziano con Should
        {

            //ARRANGE:predisposizione/prerequisiti
            double a = 1, b = 2, c = 1;
            Equation equazione = new Equation();

            //ACT: chiamata alla funzionalità da testare
            double[] risultato = equazione.RisolviEquazioneSecondoGrado(a, b, c);



            //ASSERT: valutazione del risultato
            Assert.True(risultato.Length == 1); //lunghezza dell'array risultato
            Assert.Equal(-1, risultato[0]);



        }
        [Fact]
        public void Test4() //iniziano con Should
        {

            //ARRANGE:predisposizione/prerequisiti
            double a = 1, b = -3, c = 10;
            Equation equazione = new Equation();

            //ACT: chiamata alla funzionalità da testare
            double[] risultato = equazione.RisolviEquazioneSecondoGrado(a, b, c);



            //ASSERT: valutazione del risultato
            Assert.Null(risultato);



        }
    }
}
