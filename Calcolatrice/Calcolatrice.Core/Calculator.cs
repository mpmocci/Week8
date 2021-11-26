using System;

namespace Calcolatrice.Core
{
    public class Calculator
    {


        public double SommaNumeri(double a, double b)
        {
            double result;
            result = a + b;
            return result;
        }

        public double SottraiNumeri(double a, double b)
        {
            double result;
            result = a - b;
            return result;
        }

        public double MoltiplicaNumeri(double a, double b)
        {
            double result;
            result = a * b;
            return result;
        }

        public double? DividiNumeri(double a, double b)
        {
            double? result;
            if (b != 0)
            {
                result = a / b;
                return result;
            }

            result = null;
            return result;
        }

        public bool VerificaSeAMaggioreDiB(double a, double b)
        {
            bool result;

            if (a >= b)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
    }
