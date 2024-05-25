namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> cisla = new List<double>
        {
            0.046939913,
            0.295866297,
            0.852489925,
            0.84994766,
            0.96925183,
            0.946275497,
            0.688903175,
            0.553463564,
            0.59628254,
            0.645816929
        };
            // Vypis vsechna cisla na konzoli (nachystej si pro to funkci)
            Vypis(cisla);
            // Vypis na konzoli pocet cisel v seznamu
            VypisPocet(cisla);
            // Pridej cislo 0.5 do seznamu
            cisla.Add(0.5);
            //cisla.Insert(cisla.Count, 0.5)
            // vypis prvni cislo ze seznamu, ktere je vetsi nez 0.8 - može sa použiť funkcia find/ cisla.First(x=>x > 0.8) 
            foreach (double cislo in cisla)
            {
                if (cislo > 0.8)
                {
                    Console.WriteLine($"Prvni cislo vetsi nez 0.8 je: {cislo}");
                    break;
                }
            }
            // najdi nejvetsi cislo v seznamu, vypis, ktere to je, a odstran ho ze seznamu
            //var max = cisla.Max();
            double maxCislo = double.MinValue;
            foreach (double cislo in cisla)
            {
                if (cislo > maxCislo)
                {
                    maxCislo = cislo;
                }
            }
            cisla.Remove(maxCislo);
            Console.WriteLine($"Nejvetsi cislo v seznamu bylo: {maxCislo}");
            //cisla.RemoveAll - ak by bolo rovnaké číslo viac krát, použiť túto metódu aby sa odstrabili všetky
            // vypis opet vsechna cisla a jejich pocet 

            Vypis(cisla);
            VypisPocet(cisla);
        }
        static void Vypis(List<double> seznam)
        {
            Console.WriteLine("Cisla v seznamu:");
            foreach (double cislo in seznam)
            {
                Console.WriteLine(cislo);
            }
        }

        static void VypisPocet(List<double> seznam)
        {
            Console.WriteLine($"Pocet cisel v seznamu: {seznam.Count}");
        }
    }
}
