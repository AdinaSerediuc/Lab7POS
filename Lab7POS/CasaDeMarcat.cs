using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7POS
{
    public class CasaDeMarcat
    {
        private IComunicarePOS pos;

        public CasaDeMarcat(IComunicarePOS pos)
        {
            this.pos = pos;
        }

        public void PlatesteCash(decimal suma)
        {
            Console.WriteLine("Deschid seiful.");
            Console.WriteLine($"Introduc suma de {suma} in seif.");
            Console.WriteLine("Inchid seiful.");
            Console.WriteLine("Eliberez chitanta.");
        }

        public void PlatesteCuCard(decimal suma)
        {
            pos.TrimitePlata(suma);
            Console.WriteLine("Pun la dispozitie POS-ul pentru client.");
        }
    }
}
