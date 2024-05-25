using System.Drawing;

namespace BOR6
{

    public class Rectangle
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            if (width <= 0 || height <= 0)
            {
                Console.WriteLine("Invalid input, setting values to 1.");
                Width = 1;
                Height = 1;
            }
            else
            {
                Width = width;
                Height = height;
            }

        }
           public Rectangle(double side) : this(side, side) { }
            public double Capacity => Width* Height;

        public double Perimeter => 2 * (Width + Height);
        public void WriteRectangleParameters()
        {
            Console.WriteLine($"Width: {Width}, Height: {Height}");
        }

        public void GetBigger(double widthIncrease, double heightIncrease)
        {

            double newWidth = Width + widthIncrease;
            double newHeight = Height + heightIncrease;

            if (newWidth <= 0 || newHeight <= 0)
            {
                Console.WriteLine("Invalid input, cannot decrease dimensions to zero or negative.");
                return;
            }

            Rectangle newRectangle = new Rectangle(newWidth, newHeight);
            Console.WriteLine("After increasing size:");
            newRectangle.WriteRectangleParameters();
        }
    }
    internal class Program
    { 
    static void Main(string[] args)
        {
            //  Vytvoř třídu Obdelnik (tak, aby byla v samostatnem souboru Obdelnik.cs), která bude mít dva fieldy: Sirka a Vyska.
            //  Vytvoř konstruktor třídy Obdelnik s parametry sirka a vyska.
            //  Přidej do třídy ještě jeden typ konstruktoru pro speciální případ obdelníku(čtverec) s jedním parametrem, který bude volat první konstruktor.
            //  Obdelniku vytvorte funkci Vypis informace, ktery vypise vysku a sirku.
            //  Vytvoř několik instancí třídy Obdelnik (například 2) a vypiš jejich vlastnosti pomoci metody VypisParameteryObdelniku.

            Rectangle rectangle1 = new Rectangle(10, 5);
            Rectangle rectangle2 = new Rectangle(15, 5);

            // Výpis vlastností obdélníků
            rectangle1.WriteRectangleParameters();
            rectangle2.WriteRectangleParameters();

            /* Vyuzij tridu Obdelnik z prvniho BR.
   Prepis fieldy Sirka a Vyska na properties.
   Nastavte properties tak, aby je nebylo mozne zmenit po vytvoreni instance.
   Vytvorte property Obsah, ktera umozni ziskat obsah obdelniku.
   Vytvorte property Obvod, ktera umozni ziskat obvod obdelniku.
   Vytvorte funkci Zvetsi, ktera zvetsi obdelnik o sirku a vysku.
   Zajistete, aby nebylo mozne vytvorit obdelnik o obsahu 0 (vypiste hlasku a nastavte hodnotu na 1).
   Napiste program, ktery vytvori obdelnik, vypise jeho velikosti, obsah a obvod.
*/
            Console.WriteLine($"Area of rectangle1: {rectangle1.Capacity}, Perimeter of rectangle1: {rectangle1.Perimeter}");
            Console.WriteLine($"Area of rectangle2: {rectangle2.Capacity}, Perimeter of rectangle2: {rectangle2.Perimeter}");

          
            rectangle1.GetBigger(5, 5);
            rectangle2.GetBigger(30, 25);






        }
    }
}
