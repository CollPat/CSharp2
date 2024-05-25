using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BOR4._2
{
    internal class Program
    {
        class TelefonniSeznam
        {
            private Dictionary<string, int> seznam;

            public TelefonniSeznam()
            {
                seznam = new Dictionary<string, int>();
                
                seznam.Add("Jan Novák", 123456789);
                seznam.Add("Marie Dvořáková", 987654321);
                seznam.Add("Janko Hráško", 876342567);
               
            }
            //trygetvalue - najdoležitejšie
            public void PridejOsobu(string jmeno, int cislo)
            {
                if (seznam.ContainsKey(jmeno))
                {
                    Console.WriteLine("Toto jméno již existuje v telefonním seznamu.");
                }
                else
                {
                    seznam.Add(jmeno, cislo);
                    Console.WriteLine($"Osoba {jmeno} byla úspěšně přidána do telefonního seznamu.");
                }
            }

            public int NajdiTelefon(string jmeno)
            {
                if (seznam.ContainsKey(jmeno))
                {
                    return seznam[jmeno];
                }
                else
                {
                    Console.WriteLine($"Osoba {jmeno} nebyla nalezena v telefonním seznamu.");
                    return -1;
                }
            }

            public void VypisSeznam()
            {
                Console.WriteLine("Telefonní seznam:");
                foreach (var item in seznam)
                {
                    Console.WriteLine($"Jméno: {item.Key}, Telefonní číslo: {item.Value}");
                }
            }

            public void SmazOsobu(string jmeno)
            {
                if (seznam.ContainsKey(jmeno))
                {
                    seznam.Remove(jmeno);
                    Console.WriteLine($"Osoba {jmeno} byla úspěšně smazána z telefonního seznamu.");
                }
                else
                {
                    Console.WriteLine($"Osoba {jmeno} nebyla nalezena v telefonním seznamu.");
                }
            }

            public void SmazSeznam()
            {
                seznam.Clear();
                Console.WriteLine("Telefonní seznam byl úspěšně smazán.");
            }
        }
        static void Main(string[] args)
        {
            //može sa použiť var 
            TelefonniSeznam telefonniSeznam = new TelefonniSeznam();

            // Přidání nové osoby
            telefonniSeznam.PridejOsobu("Petr Nový", 555123456);

            // Zjištění telefonního čísla
            int telefonniCislo = telefonniSeznam.NajdiTelefon("Marie Dvořáková");
            Console.WriteLine($"Telefonní číslo pro Marii Dvořákovou: {telefonniCislo}");

            // Výpis celého seznamu
            telefonniSeznam.VypisSeznam();

            // Smazání osoby
            telefonniSeznam.SmazOsobu("Jan Novák");

            // Smazání celého seznamu
            telefonniSeznam.SmazSeznam();

            //myslete na mozne chybove stavy(co kdyz tam dany clovek neni, co kdyz pridavam cloveka, ktery uz tam je)


        }
    }
}
