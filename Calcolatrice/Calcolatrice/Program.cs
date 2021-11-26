using Calcolatrice.Core;
using System;

namespace Calcolatrice
{
    class Program
    {
        static void Main(string[] args)
        {

            bool exit = false;
            do
            {
                double a, b;
                int scelta;
                do
                {
                    Console.WriteLine("********Benvenuta*******");
                    Console.WriteLine("Immetti l'operazione da effettuare tra le seguenti:\n");
                    Console.WriteLine("1. Somma");
                    Console.WriteLine("2. Sottrazione");
                    Console.WriteLine("3. Moltiplicazione");
                    Console.WriteLine("4. Divisione");
                    Console.WriteLine("5. Disequazione");
                    Console.WriteLine("0. Esci");
                }
                while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta <= 5));


                Console.WriteLine("Digita il primo numero a=");
                while (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Valore errato.Riprova.");
                };
                Console.WriteLine("Digita il secondo numero b = ");
                while (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Valore errato.Riprova.");
                };

                Calculator calcolatrice = new Calculator();

                switch (scelta)
                {
                    case 1:

                        double risultato1 = calcolatrice.SommaNumeri(a, b);
                        Console.WriteLine($"Il risultato è {risultato1}");

                        break;

                    case 2:

                        double risultato2 = calcolatrice.SottraiNumeri(a, b);
                        Console.WriteLine($"Il risultato è {risultato2}");


                        break;

                    case 3:

                        double risultato3 = calcolatrice.MoltiplicaNumeri(a, b);
                        Console.WriteLine($"Il risultato è {risultato3}");

                        break;

                    case 4:

                        double? risultato4 = calcolatrice.DividiNumeri(a, b);
                        Console.WriteLine($"Il risultato è {risultato4}");

                        break;

                    case 5:

                        bool risultato5 = calcolatrice.VerificaSeAMaggioreDiB(a, b);
                        Console.WriteLine($"Il risultato è {risultato5}");

                        break;

                    case 0:
                        exit = true;
                        break;
                }
            }
            while (exit == true);
        }
    }
}
