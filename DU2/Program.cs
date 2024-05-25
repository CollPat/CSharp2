using System.ComponentModel.Design;
using System.Text.RegularExpressions;

namespace DU2
{
    class IntegerAdditionCalculator
    {
        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }
    }

    class NumberGuessingGame
    {
        private int NumberToBeGuessed;

        public NumberGuessingGame(int number)
        {
            NumberToBeGuessed = number;
        }

        public int Guess(int guess)
        {
            return guess.CompareTo(NumberToBeGuessed);
        }
    }

    class GetUserNumberInput
    {
        static double UserInputToCalculate()
        {
            while (true)
            {
                string userInput = Console.ReadLine();
                double number;
                if (double.TryParse(userInput, out number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Error, write a valid number");
                }
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                //Napište program, který se zeptá na dvě čísla a zobrazí jejich součet.
                Console.WriteLine("User, write the first number");
                double usernumber1 = UserInputToCalculate();

                Console.WriteLine("User, write the second number");
                double usernumber2 = UserInputToCalculate();

                double result = IntegerAdditionCalculator.Add(usernumber1, usernumber2);
                Console.WriteLine($"The result is: {result}");


                //Napište program, který se zeptá na počet hvězdiček a potom je v cyklu zobrazí na konzoli.
                Console.WriteLine("Number of Stars:");
                string numberOfStars = Console.ReadLine();
                int starsCount;
                bool isInputValidInteger = int.TryParse(numberOfStars, out starsCount);

                while (isInputValidInteger == false || starsCount <= 0)
                {
                    Console.WriteLine("Invalid input. Please write a number greater than 0:");
                    numberOfStars = Console.ReadLine();
                    isInputValidInteger = int.TryParse(numberOfStars, out starsCount);
                }

                for (int x = 1; x <= starsCount; x++)
                {

                    Console.Write("*");

                }

                Console.WriteLine();

                /*Vytvořte třídu Lucistnik, ktera bude mit vlastnost PocetSipu a metodu Vystrel. PocetSipu muze byt nastaven treba na 10.
                Pokud bude mit dost sipu, napise metoda Vystrel na konzoli text: Vzdy se strefim primo do prostred!
                Metoda Vystrel uvnitr s kazdym vystrelem snizi pocet sipu.
                Pokud bude pocet 0, metoda Vystrel vypise "Nemam sipy".
                Napiste program, ktery vytvori lucistnika a vystreli vsechny sipy.*/

                Archer archer = new Archer(10);

                while (archer.HasArrows())
                {
                    archer.Shot();
                }
                Console.WriteLine("Out of arrows.");
                Console.WriteLine();

                // Napište program, který umožní hádat číslo. Zeptá se, jaké číslo si myslím. Podle toho, jaké číslo se zadá, napíše, jestli je číslo větší nebo menší a umožní hádat tak dlouho, dokud se uživatel netrefí:
                /* Např.
                 Hádej číslo: 10
                 Číslo je menší, hádej znovu: 5
                 Číslo je větší, hádej znovu: 7
                 To je správně!*/

                int numberOfGuesses = 0;

                while (numberOfGuesses < 3)
                {
                    Random generator = new Random();
                    int randomNumber = generator.Next(0, 11);
                    Console.WriteLine("Guess a number!");

                    NumberGuessingGame game = new NumberGuessingGame(randomNumber);

                    int guessResult = 1;

                    while (guessResult != 0 && numberOfGuesses < 3)
                    {
                        string userGuess = Console.ReadLine();
                        int guess;

                        if (int.TryParse(userGuess, out guess))
                        {
                            guessResult = game.Guess(guess);
                            numberOfGuesses++;

                            if (guessResult == 0)
                            {
                                Console.WriteLine("That is right!");
                            }
                            else if (guessResult < 0)
                            {
                                Console.WriteLine("The number is bigger, guess again:");
                            }
                            else
                            {
                                Console.WriteLine("The number is smaller, guess again:");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Write a valid number.");
                        }
                    }

                    if (guessResult != 0)
                    {
                        Console.WriteLine("Sorry, you have reached the maximum number of guesses. The correct number was: " + randomNumber);
                    }
                }
            }
        }
    }
}
