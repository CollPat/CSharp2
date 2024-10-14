namespace BOR12.Test
{
    public static class Kalkulacka
    {
        public static double Secti(double x, double y)
        {
            return (x + y);
        }
        public static double Vydel(double x, double y)
        {
            return (x / y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kalkulacka.Secti);
        }
    }
}
