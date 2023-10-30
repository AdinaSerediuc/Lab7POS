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

            IPlataContactFull cardClasic = new CardClasic();
            IPlataContactFull cardContactless = new CardContactless();
            IPlataContactless telefonContactless = new TelefonContactless();

            pos.PlatesteContactFull(cardClasic, 100);
            pos.PlatesteContactFull(cardContactless, 150);
            pos.PlatesteContactless(telefonContactless, 50);
        }
    }
}
