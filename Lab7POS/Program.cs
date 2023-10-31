using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7POS
{
    class Program
    {
        static void Main(string[] args)
        {
            POS pos = new POS();
            PunctVanzare punctVanzare = new PunctVanzare();
            CasaDeMarcat casaDeMarcat = new CasaDeMarcat(punctVanzare);

            IPlataContactFull cardClasic = new CardClasic();
            IPlataContactFull cardContactless = new CardContactless();
            IPlataContactless telefonContactless = new TelefonContactless();

            pos.PlatesteContactFull(cardClasic, 100);
            pos.PlatesteContactFull(cardContactless, 150);
            pos.PlatesteContactless(telefonContactless, 50);

            // Plata cu cash
            Console.WriteLine("Plata cu cash:");
            casaDeMarcat.PlatesteCash(200);

            // Plata cu card
            Console.WriteLine("\nPlata cu card:");
            casaDeMarcat.PlatesteCuCard(150);

            // Clientul decide modalitatea de plata cu cardul
            Console.WriteLine("\nClientul decide modalitatea de plata cu cardul:");
            Console.WriteLine("1. Plata contactless");
            Console.WriteLine("2. Plata contactfull");

            int optiune = int.Parse(Console.ReadLine());
            switch (optiune)
            {
                case 1:
                    punctVanzare.PlataContactless();
                    break;
                case 2:
                    punctVanzare.PlataContactFull();
                    break;
                default:
                    Console.WriteLine("Optiune invalida.");
                    break;
            }
        }
    }
}
