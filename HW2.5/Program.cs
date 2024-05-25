using System.Collections;
using System.Collections.Generic;

namespace HW2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Vypiš aktuální datum a čas, nemusíš řešit, v kterém je to časovém pásmu.

            DateTime aktualniDatumCas = DateTime.Now;
            Console.WriteLine("Aktuální datum a čas: " + aktualniDatumCas);

            // 2. Vytvoř proměnnou typu DateTime a ulož do ní svoje datum narození. Potom vypiš, kolik dnů od té doby uteklo.

            DateTime datumNarozeni = new DateTime(1998, 1, 22);
            TimeSpan rozdil = DateTime.Now - datumNarozeni;
            Console.WriteLine("Od mého narození uplynulo dní: " + rozdil.TotalDays);

            // 3. Vytvoř list stringů a vlož do něj 5 různých hodnot.
            List<string> seznam = new List<string>() { "modra", "zelena", "cervena", "zluta", "cerna" };

            // 4. Smaž z tohoto listu libovolnou hodnotu.
            seznam.Remove("cervena");

            // 5. Zjisti, jestli tento list obsahuje nějakou hodnotu pomocí list metody Contains

            bool obsahujeModra = seznam.Contains("modra");
            Console.WriteLine("Seznam obsahuje 'modra': " + obsahujeModra);

            // 6. Vypiš do konzole, kolik je v tom listu prvků a připoj k tomu všechny ty hodnoty (např: "2: modra, zelena").

            Console.WriteLine(seznam.Count + ": " + string.Join(", ", seznam));


            // 7. Vytvoř slovník, kde klíčem bude položka nákupu (string) a hodnotou cena té položky, a vlož nějaké hodnoty (např: <"chleba", 20>).

            Dictionary<string, double> nakup = new Dictionary<string, double>()
            {
            { "chleba", 20 },
            { "mleko", 15 },
            { "syr", 45 },
            { "jablka", 30 },
            { "maslo", 50 }
            };
            // 8. Zjisti, jestli slovník obsahuje nějakou konkrétní potravinu a pokud ano, vypiš její cenu, pokud ne, vypiš, že není.

            string hledanaPolozka = "chleba";
            if (nakup.ContainsKey(hledanaPolozka))
            {
                Console.WriteLine("Cena " + hledanaPolozka + " je " + nakup[hledanaPolozka] + " Kč.");
            }
            else
            {
                Console.WriteLine(hledanaPolozka + " není v nákupním seznamu.");
            }
            // 9. Řekněme, že už jsi do slovníku přidala např. chleba a zjistila, že máš v nákupní tašce ještě jeden -> uprav hodnotu k tomu klíči tak, aby obsahovala hromadnou cenu za všechny stejné položky.
            if (nakup.ContainsKey("chleba"))
            {
                nakup["chleba"] += 20; // Přidáme cenu dalšího chleba
                Console.WriteLine("Nová cena chleba je " + nakup["chleba"] + " Kč.");
            }
        }
    }
}
