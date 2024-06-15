namespace BOR8
{
    class Obdelnik : IUmiPocitatObvod, IUmiPocitatObsah
    {
        public double Delka { get; set; }
        public double Sire { get; set; }

        public Obdelnik(double delka, double sire)
        {
            Delka = delka;
            Sire = sire;
        }

        public double VypocitejObsah()
        {
            return Delka * Sire;
        }

        public double VypocitejObvod()
        {
            return 2 * (Delka + Sire);
        }

        class Kruh : IUmiPocitatObsah, IUmiPocitatObvod
        {
            public double Polomer { get; set; }

            public Kruh(double polomer)
            {
                Polomer = polomer;
            }

            public double VypocitejObsah()
            {
                return Math.PI * Polomer * Polomer;
            }

            public double VypocitejObvod()
            {
                return 2 * Math.PI * Polomer;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IUmiPocitatObsah> seznamObsah = new List<IUmiPocitatObsah>();
            List<IUmiPocitatObvod> seznamObvod = new List<IUmiPocitatObvod>();

            // Vytvoření instance Obdelnik a Kruh
            Obdelnik obdelnik = new Obdelnik (5, 3);
            Kruh kruh = new Kruh(4);

            // Přidání instancí do seznamu
            seznamObsah.Add(obdelnik);
            seznamObsah.Add(kruh);
            seznamObvod.Add(obdelnik);
            seznamObvod.Add(kruh);

            // Výpočet a výpis obsahu
            foreach (var item in seznamObsah)
            {
                Console.WriteLine("Obsah: " + item.VypocitejObsah());
            }

            // Výpočet a výpis obvodu
            foreach (var item in seznamObvod)
            {
                Console.WriteLine("Obvod: " + item.VypocitejObvod());
            }
        }
        FairytaleCreature princess = new Princess();
            princess.HowDoYouSpendFreeTime();

            FairytaleCreature knight = new Knight();
            knight.HowDoYouSpendFreeTime();

            FairytaleCreature witch = new Witch();
            witch.HowDoYouSpendFreeTime();

        }
    }
}
