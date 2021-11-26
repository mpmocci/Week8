using Equazioni_grado2.Core;
using System;

namespace Equazioni_grado2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Benvenuta!*******");
            Console.WriteLine("Immetti i 3 coefficienti dell'equazione completa ax^2 +bx +c:\n");
            double a, b, c;

            Console.WriteLine("a=");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Valore errato.Riprova.");
            };
            Console.WriteLine("b=");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Valore errato.Riprova.");
            };
            Console.WriteLine("c=");
            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Valore errato.Riprova.");
            };

            Console.WriteLine($"L'equazione da risolvere è:{a}x^2 + {b}x +c");

            Equation equation = new Equation();
            double[] risultato = equation.RisolviEquazioneSecondoGrado(a, b, c);

            if (risultato == null)
            {
                Console.WriteLine("L'equazione è impossibile da risolvere.");
            }
            else if (risultato.Length == 1)
            {
                Console.WriteLine($"Soluzioni coincidenti x1=x2={risultato[0]}");

            }
            else if(risultato.Length == 2)
            {
                Console.WriteLine($"Soluzioni distinte x1={risultato[0]}, x2={risultato[1]}");
            }



        }
    }
}
