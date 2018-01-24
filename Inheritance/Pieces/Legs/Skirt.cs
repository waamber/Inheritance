using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Pieces.Legs
{
    class Skirt : LegBase
    {
        public string Material { get; set; }
        public Length  Length { get; set; }

        public override void Jump(int howHigh)
        {
            Console.WriteLine($"Skirt jumped {howHigh} inches.");
        }

        public override void Walk(int numberOfSteps) //overrides Walk() in LegBase
        {
            if (Length == Length.StreetCorner)
            {
                Console.WriteLine($"The {Size} legs walked {numberOfSteps} steps suggestively and knocked on your window.");
                return;
            }

            base.Walk(numberOfSteps); // base is what you're inheriting from in LegBase
        }
    }
}
