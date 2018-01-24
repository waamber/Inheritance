using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Pieces.Legs
{
    class Skirt : LegBase, IMoveable
    {
        public string Material { get; set; }
        public Length  Length { get; set; }
        int _howFarIMoved;

        public int HowFarIMoved { get => _howFarIMoved; } //returns _howFarIMoved


        public override void Jump(int howHigh)
        {
            Console.WriteLine($"Skirt jumped {howHigh} inches.");
        }

        public void Run(int howFar)
        {
            Console.WriteLine($"Skirt ran {howFar} miles.");
            _howFarIMoved += howFar;
        }

        public override void Walk(int numberOfSteps) //overrides Walk() in LegBase
        {
            _howFarIMoved += numberOfSteps;

            if (Length == Length.StreetCorner)
            {
                Console.WriteLine($"The {Size} legs walked {numberOfSteps} steps suggestively and knocked on your window.");
                return;
            }

            base.Walk(numberOfSteps); // base is what you're inheriting from in LegBase
        }
    }
}
