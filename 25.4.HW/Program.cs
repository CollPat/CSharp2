using System;
using System.Text.RegularExpressions;

namespace _25._4.HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tento ukol se opravuje sam. Kazdy priklad obsahuje kontrolni vypisy, ktere overi, ze jsi dosla k spravnemu vysledku.
            // Vsechny priklady take obsahuji nejakou predpripravenou promennou, kam ulozis vysledek svoji prace.

            int padding = 45;
            string text = @"""Hurry up, boy!"" shouted Uncle Vernon from the kitchen. ""What are you
doing, checking for letter bombs?"" He chuckled at his own joke.

Harry went back to the kitchen, still staring at his letter. He handed
Uncle Vernon the bill and the postcard, sat down, and slowly began to
open the yellow envelope.

Uncle Vernon ripped open the bill, snorted in disgust, and flipped over
the postcard.

""Marge's ill,"" he informed Aunt Petunia. ""Ate a funny whelk. --.""

""Dad!"" said Dudley suddenly. ""Dad, Harry's got something!""

Harry was on the point of unfolding his letter, which was written on the
same heavy parchment as the envelope, when it was jerked sharply out of
his hand by Uncle Vernon.

""That's mine!"" said Harry, trying to snatch it back.

""Who'd be writing to you?"" sneered Uncle Vernon, shaking the letter open
with one hand and glancing at it. His face went from red to green faster
than a set of traffic lights. And it didn't stop there. Within seconds
it was the grayish white of old porridge.";

            // Nez zacnes volat nejake stringove funkce na nejake stringove promenne, nezapomen overit, ze obsahuje smysluplnou hodnotu. Vysledek uloz do promenne 'textMaSmysl'.
            bool textHasMeaning = !string.IsNullOrEmpty(text);
            Console.WriteLine("Text is meaningful - ".PadRight(padding) + textHasMeaning);

            // Do promenne 'delkaTextu' uloz celkovou delku uryvku z knizky.

          
            int textLenght = text.Length;
            Console.WriteLine("The length of the text is right - ".PadRight(padding) + (textLenght == 1024));

            // Do promenne 'oddelovac' vloz text, ktery se sklada pouze z pomlcek a jeho delka je presne 20. Pouzij k tomu konstruktor typu string.

            string divider = new string('-', 20);
            Console.WriteLine("Divider has 20 dashes - ".PadRight(padding) + (divider == "--------------------"));

            // Pozmen nasledujici porovnani textu tak, aby se do konzole vypisovalo True, aniz bys menila hodnoty promennych

            string name1 = "Katka";
            string name2 = "katka";
            bool isSame = string.Equals(name1, name2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("Both variables contain the same name - ".PadRight(padding) + isSame);

            // Zjisti, jestli je v textu zminka o obtloustle "tete" Harryho. Jmenuje se Marge. Vysledek uloz do promenne 'piseSeOMarge';

            bool isMargeMentioned = text.Contains("Marge");
            Console.WriteLine("Harry´s ´aunt´is mentioned - ".PadRight(padding) + isMargeMentioned);

            // Zjisti, jestli je text spravne ukonceny interpunkci. Vysledek uloz do promenne 'jeSpravneUkoncen'.

            bool isCorrectlyEnded = true;
            Console.WriteLine("Text correctly ends with punctuation - ".PadRight(padding) + isCorrectlyEnded);

            // Pomoci abecedniho porovnavani zjisti, ktery z nasledujicich textu je podle abecedy prvni a jeho hodnotu prirad do promenne 'prvni'.

            string gibberish1 = "abbc";
            string gibberish2 = "acbc";
            string gibberish3 = "abbb";
            string first = string.Compare(gibberish1, gibberish2, StringComparison.OrdinalIgnoreCase) < 0 ?
                           (string.Compare(gibberish1, gibberish3, StringComparison.OrdinalIgnoreCase) < 0 ? gibberish1 : gibberish3) :
                           (string.Compare(gibberish2, gibberish3, StringComparison.OrdinalIgnoreCase) < 0 ? gibberish2 : gibberish3);

            Console.WriteLine("First in the alphabet is gibberish3 - ".PadRight(padding) + (first == gibberish3));

            // Najdi prvni rozkazovaci vetu v textu a uloz ji do promenne 'veta' bez vykricniku a uvozovek.

            string sentence = Regex.Match(text, @"[A-Z][^\.!?]*[\.!?]").Value.Trim(new char[] { '.', '!', '?' });
            Console.WriteLine("First imperative sentence is 'Hurry up, boy' - ".PadRight(padding) + (sentence == "Hurry up, boy"));

            // Zjisti, kolikrat se v textu vyskytuje slovo "and" bez ohledu na velikosti prvniho pismenka a vysledek uloz do promenne 'pocetAnd'.
            // Abych vam to zjednodusil, muzete se spolehnout, ze tato anglicka spojka bude v textu vzdy obklopena mezerou na kazde strane.
            // Tim se snadno vylouci jakekoliv vyskyty "and" v ramci jinych slov.

            int numberOfAnd = text.Split(new string[] { " and " }, StringSplitOptions.None).Length - 1;
            Console.WriteLine("Text contains the word 'and' 4x in total - ".PadRight(padding) + (numberOfAnd == 4));
        }
    }
}
