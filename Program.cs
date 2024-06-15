namespace DU2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napište program, který se zeptá na dvě čísla a zobrazí jejich součet.
            Console.WriteLine("User, write the first number");
            string consolenumber1 = Console.ReadLine();
            double usernumber1;
            bool number1 = double.TryParse(consolenumber1, out usernumber1);

            Console.WriteLine("User, write the second number");
            string consolenumber2 = Console.ReadLine();
            double usernumber2;
            bool number2 = double.TryParse(consolenumber2, out usernumber2);

            double result = usernumber1 + usernumber2;
            Console.WriteLine($"The result is: {result}");






            //Napište program, který se zeptá na počet hvězdiček a potom je v cyklu zobrazí na konzoli.
            Console.WriteLine("Počet hviezdičiek:");
            string numberOfStars = Console.ReadLine();
            int rows;
            bool numberOfrows = int.TryParse(numberOfStars, out rows);
            string star = "*";

            for (int x = 1; x <= rows; x++)
            {


                for (int y = 1; y <= x; y++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            /*Vytvořte třídu Lucistnik, ktera bude mit vlastnost PocetSipu a metodu Vystrel. PocetSipu muze byt nastaven treba na 10.
            Pokud bude mit dost sipu, napise metoda Vystrel na konzoli text: Vzdy se strefim primo do prostred!
            Metoda Vystrel uvnitr s kazdym vystrelem snizi pocet sipu.
            Pokud bude pocet 0, metoda Vystrel vypise "Nemam sipy".
            Napiste program, ktery vytvori lucistnika a vystreli vsechny sipy.*/

            Lucistnik lucistnik = new Lucistnik(10);

            while (lucistnik.PocetSipu > 0)
            {
                lucistnik.Vystrel();
            }

            Console.WriteLine("Nemam šípy.");

            // Napište program, který umožní hádat číslo. Zeptá se, jaké číslo si myslím. Podle toho, jaké číslo se zadá, napíše, jestli je číslo větší nebo menší a umožní hádat tak dlouho, dokud se uživatel netrefí:
            /* Např.
             Hádej číslo: 10
             Číslo je menší, hádej znovu: 5
             Číslo je větší, hádej znovu: 7
             To je správně!*/

            Random generator = new Random();
            int randomNumber = generator.Next(0,11);
            Console.WriteLine("Hádej číslo!");

            bool correctGuess = false;

            while (!correctGuess)
            {
                string userGuess = Console.ReadLine();
                int guess;

                if (int.TryParse(userGuess, out guess))
                {
                    if (guess == randomNumber)
                    {
                        Console.WriteLine("To je správně!");
                        correctGuess = true;
                    }
                    else
                    {
                        if (guess < randomNumber)
                        {
                            Console.WriteLine("Číslo je větší, hádej znovu:");
                        }
                        else
                        {
                            Console.WriteLine("Číslo je menší, hádej znovu:");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Neplatný vstup. Zadej prosím platné číslo.");
                }
            }
        }



    }
}
