using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7POS
{
    public class PunctVanzare : IComunicarePOS
    {
        private decimal sumaPlata;

        public void TrimitePlata(decimal suma)
        {
            sumaPlata = suma;
            Console.WriteLine($"Suma de {sumaPlata} a fost trimisa la POS.");
        }

        public void PlataContactless()
        {
            Console.WriteLine($"Plata contactless cu suma de {sumaPlata} a fost efectuata.");
        }

        public void PlataContactFull()
        {
            Console.WriteLine($"Plata contactfull cu suma de {sumaPlata} a fost efectuata.");
        }
    }
}
