namespace BOR7
{
    abstract class Zvire
    {
        public abstract void VydavejZvuk();
    }
    class Pes : Zvire
    {
        public override void VydavejZvuk()
        {
            Console.WriteLine("Haf, haf");
        }
    }
    class Kocka : Zvire
    {
        public override void VydavejZvuk()
        {
            Console.WriteLine("Mnau, mnau");
        }
    }

    class Krava : Zvire
    {
        public override void VydavejZvuk()
        {
            Console.WriteLine("Bů, bů");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                List<Zvire> zooKoutek = new List<Zvire>
        {
            new Pes(),
            new Kocka(),
            new Krava()
        };

                // Procházení seznamu a vydávání zvuků
                foreach (Zvire zvire in zooKoutek)
                {
                    zvire.VydavejZvuk();
                }
            }
        }
    }
}
