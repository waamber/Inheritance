using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Pieces.Legs
{
    abstract class LegBase //abstract- cannot create new instance-- most 'base' classes will be abstract
    {
        public int NumberOfPockets { get; set; }
        public string Color { get; set; }
        public LegSize Size { get; set; }

        public virtual void Walk(int numberOfSteps) // virtural allows other classes to override Walk()
        {
            Console.WriteLine($"The {Size} legs took {numberOfSteps} steps.");
        }
    }
}
