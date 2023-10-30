using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7POS
{
    public class CardClasic : IPlataContactFull
    {
        public void Introduce()
        {
            Console.WriteLine("Introduceti cardul clasic în POS.");
        }

        public void EfectueazaPlata()
        {
            Console.WriteLine("Plata cu cardul clasic a fost efectuata.");
        }

        public void Extrage()
        {
            Console.WriteLine("Cardul clasic a fost extras din POS.");
        }

    }
}
