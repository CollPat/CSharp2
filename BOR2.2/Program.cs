namespace BOR2._2
{
    internal class Program
    {
        public class Clovek
        {
            public string Jmeno;
            public int TelCislo;
            public Clovek(string jmeno, int telCislo)
            {
                Jmeno = jmeno;
                TelCislo = telCislo;
                if (string.IsNullOrWhiteSpace(Jmeno))
                {
                    throw new ArgumentNullException(nameof(jmeno), "The text cannot be null or white space") ;
                }

                if (telCislo.ToString().Length != 9)
                {
                    throw new ArgumentException("Telephone number must have 9 numbers", "TelCislo");
                }

            }
            public string VypisJmenoACislo()
            {
               
                return $"{Jmeno}: {TelCislo}";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program na vytvareni telefonniho seznamu");
            Console.WriteLine("========================================");
            Console.Write("Zadejte jmeno: ");
            string jmeno = Console.ReadLine();
            Console.Write("Zadejte telefonni cislo: ");
            string cislo = Console.ReadLine();
          
            

            try
            {
                Clovek prvniClovek = new Clovek(jmeno, int.Parse(cislo));
                Console.WriteLine(prvniClovek.VypisJmenoACislo());
            }

            catch (ArgumentException argEx)
            {
                Console.WriteLine($"Error: {argEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finished.");
            }

            Console.ReadLine();
        }
    }
}
