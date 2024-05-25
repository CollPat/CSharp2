namespace BOR3._1
{
    internal class Program
    {
        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);

            //použitie for a Lenght 
        }

        static string OpravCapsLock(string text)
        {
            char[] znaky = text.ToCharArray();

            for (int i = 0; i < znaky.Length; i++)
            {
                if (Char.IsLower(znaky[i]))
                {
                    znaky[i] = Char.ToUpper(znaky[i]);
                }
                else if (Char.IsUpper(znaky[i]))
                {
                    znaky[i] = Char.ToLower(znaky[i]);
                }
            }

            return new string(znaky);
        }

        static string Desifruj(string sifra)
        {
            char[] znaky = sifra.ToCharArray();

            for (int i = 0; i < znaky.Length; i++)
            {
                char aktualni = znaky[i];

                // Pro písmena posuneme o jedno místo doleva
                if (Char.IsLetter(aktualni))
                {
                    znaky[i] = (char)(aktualni - 1);

                    // Pokud jsme pod 'a' nebo 'A', přetočíme na 'z' nebo 'Z'
                    if (Char.IsLower(aktualni) && znaky[i] < 'a')
                    {
                        znaky[i] = 'z';
                    }
                    else if (Char.IsUpper(aktualni) && znaky[i] < 'A')
                    {
                        znaky[i] = 'Z';
                    }
                }
            }

            return new string(znaky);

        }

         static bool JePalindrom(string slovo)
    {
        // Odstranění mezer a převedení na malá písmena pro porovnání
        slovo = slovo.Replace(" ", "").ToLower();

        // Porovnání znaků od začátku a konce řetězce
        for (int i = 0; i < slovo.Length / 2; i++)
        {
            if (slovo[i] != slovo[slovo.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }

    static List<string> NajdiPalindromy(string[] slova)
    {
        List<string> palindromy = new List<string>();

        foreach (string slovo in slova)
        {
            if (JePalindrom(slovo))
            {
                palindromy.Add(slovo);
            }
        }

        return palindromy;
    }
        static void Main(string[] args)
        {
            //1. 

            string palindromveta = "Kuna nese nanuk";

            string reversed = ReverseString(palindromveta);

            Console.WriteLine("Původní řetězec: " + palindromveta);
            Console.WriteLine("Invertovaný řetězec: " + reversed);

            Console.ReadLine();

            //2. 

            string[] slova = new string[] { "kajak", "program", "rotor", "Czechitas", "madam", "Jarda", "radar", "nepotopen" };
            List<string> palindromy = NajdiPalindromy(slova);

            Console.WriteLine("Palindromy v poli:");
            foreach (string palindrom in palindromy)
            {
                Console.WriteLine(palindrom);
            }

            Console.ReadLine();



            //Ukol - opravte v tomto textu omylem zapnuty Caps Lock
            string capsLock = "jAK mICROSOFT wORD POZNA ZAPNUTY cAPSLOCK";
            string opravenyText = OpravCapsLock(capsLock);

            Console.WriteLine(opravenyText);

            Console.ReadLine();

            //Ukol - rozsifrujte tuto zpravu - text byl zasifrovan tak, ze jsme kazde pismeno posunuli o jedno doprava: 'a' -> 'b'. 
            string sifra = "Wzcpsob!qsbdf!.!hsbuvmvkj!b!ktfn!ob!Ufcf!qztoz";
            string desifrovanaZprava = Desifruj(sifra);

            Console.WriteLine(desifrovanaZprava);

        }
    }
}

