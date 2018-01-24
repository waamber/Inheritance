using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Pieces.Legs
{
    class Jeans : LegBase, IMoveable
    {
        public int HowFarIMoved { get; set; }

        public override void Jump(int howHigh)
        {
            Console.WriteLine("I don't jump.");
        }

        public void Run(int howFar)
        {
            HowFarIMoved += howFar;
            Console.WriteLine($"Jeans ran {howFar} miles.");
        }

        public override void Walk(int numberOfSteps)
        {
            HowFarIMoved += numberOfSteps;
            base.Walk(numberOfSteps);
        }
    }
}
