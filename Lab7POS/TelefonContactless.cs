using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7POS
{
    public class TelefonContactless : IPlataContactless
    {
        public void Apropie()
        {
            Console.WriteLine("Apropiati telefonul mobil contactless de POS.");
        }

        public void EfectueazaPlata()
        {
            Console.WriteLine("Plata cu telefonul mobil contactless a fost efectuata.");
        }
    }
}
