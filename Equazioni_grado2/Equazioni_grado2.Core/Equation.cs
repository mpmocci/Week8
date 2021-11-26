using System;

namespace Equazioni_grado2.Core
{
    public class Equation
    {

        public double[] RisolviEquazioneSecondoGrado(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - (4 * a * c);
            double[] result = new double[2];

            if (delta > 0)
            {

                result[0] = (-b - Math.Sqrt(delta)) / (2 * a);
                result[1] = (-b + Math.Sqrt(delta)) / (2 * a);

                return result;
            }

            if (delta == 0)
            {
                result = new double[1];
                result[0] = -b / (2 * a);
                return result;
            }

            return null;
        }
    }
}
