using Calcolatrice.Core;
using System;
using Xunit;

namespace Calcolatrice.Test
{
    public class CalcolatriceTest
    {
        [Fact]
        public void TestSomma()
        {
            //ARRANGE
            Calculator calcolatrice = new Calculator();
            //ACT
            double risultato = calcolatrice.SommaNumeri(1, -3);
            //ASSERT
            Assert.Equal(-2, risultato);

        }

        [Fact]
        public void TestSottrai()
        {
            //ARRANGE
            double a = 20, b = 11;
            Calculator calcolatrice = new Calculator();
            //ACT
            double risultato = calcolatrice.SottraiNumeri(a, b);
            //ASSERT
            Assert.Equal(9, risultato);

        }


        [Fact]
        public void TestMoltiplica()
        {
            //ARRANGE
            double a = 3, b = 2;
            Calculator calcolatrice = new Calculator();
            //ACT
            double risultato = calcolatrice.MoltiplicaNumeri(a, b);
            //ASSERT
            Assert.Equal(6, risultato);

        }


        [Fact]
        public void TestDividi()
        {
            //ARRANGE
            double a = 10, b = 2;
            Calculator calcolatrice = new Calculator();
            //ACT
            double? risultato = calcolatrice.DividiNumeri(a, b);
            //ASSERT
            Assert.Equal(5, risultato);


        }

        [Fact]

        public void TestVerificaSeAMaggioreDiB()
        {
            Calculator calcolatrice = new Calculator();

            bool risultato = calcolatrice.VerificaSeAMaggioreDiB(3, 1);
            Assert.True(risultato == true);

        }

        [Fact]

        public void TestVerificaSeAMaggioreDiB2()
        {
            Calculator calcolatrice = new Calculator();

            bool risultato = calcolatrice.VerificaSeAMaggioreDiB(3.2, 3.2);
            Assert.True(risultato == true);

        }
    }
}
