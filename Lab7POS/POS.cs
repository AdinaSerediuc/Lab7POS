using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7POS
{
    public class POS
    {
        public void PlatesteContactFull(IPlataContactFull plata, decimal suma)
        {
            plata.Introduce();
            plata.EfectueazaPlata();
            plata.Extrage();
            Console.WriteLine($"Plata contactfull in valoare de {suma} a fost efectuata.");
        }

        public void PlatesteContactless(IPlataContactless plata, decimal suma)
        {
            plata.Apropie();
            plata.EfectueazaPlata();
            Console.WriteLine($"Plata contactless in valoare de {suma} a fost efectuata.");
        }
    }
}


