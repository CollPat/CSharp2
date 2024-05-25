using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DU2
{
    internal class Archer
    {
        private int NumberOfArrows { get; set; }

        public Archer(int numOfArrows)
        {
            NumberOfArrows = numOfArrows;
        }

        public bool HasArrows()
        {
            return NumberOfArrows > 0;
        }
        public void Shot()
        {
            if (HasArrows())
            {
                Console.WriteLine("I always shoot the bulsseye!");
                NumberOfArrows--;
            }
            else
            {
                Console.WriteLine("Out of arrows.");
            }
        }
    }
}
