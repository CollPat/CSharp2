namespace Lekce2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day are you leaving for holiday?");
            string d = Console.ReadLine();
            

            Console.WriteLine("What month are you leaving for holiday?");
            string m = Console.ReadLine();
            

            Console.WriteLine("What year are you leaving for holiday?");
            string y = Console.ReadLine();
            

            DateTime holiday = new DateTime(int.Parse(y),int.Parse(m), int.Parse(d));
            TimeSpan leavingforholidayin = holiday - DateTime.Now;

            Console.WriteLine($"I am leaving for holiday in {leavingforholidayin.Days} days");
        }
    }
}
