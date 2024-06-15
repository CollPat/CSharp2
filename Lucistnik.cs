using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DU2
{
    internal class Lucistnik
    {
        public int PocetSipu { get; set; }

        public Lucistnik(int pocetSipu)
        {
            PocetSipu = pocetSipu;
        }

        public void Vystrel()
        {
            if (PocetSipu > 0)
            {
                Console.WriteLine("Vždy se strefím přímo do prostředí!");
                PocetSipu--;
            }
            else
            {
                Console.WriteLine("Nemám šípy.");
            }
        }
    }
}
