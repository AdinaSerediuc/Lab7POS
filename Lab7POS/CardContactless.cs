using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7POS
{
    public class CardContactless : IPlataContactFull, IPlataContactless
    {
        public void Introduce()
        {
            Console.WriteLine("Introduceti cardul contactless in POS.");
        }

        public void Apropie()
        {
            Console.WriteLine("Apropiaii cardul contactless de POS.");
        }

        public void EfectueazaPlata()
        {
            Console.WriteLine("Plata cu cardul contactless a fost efectuata.");
        }

        public void Extrage()
        {
            Console.WriteLine("Cardul contactless a fost extras din POS.");
        }
    }
}
