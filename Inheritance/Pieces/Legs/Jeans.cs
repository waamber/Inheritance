using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Pieces.Legs
{
    class Jeans : LegBase, IMove
    {
        public override void Jump(int howHigh)
        {
            Console.WriteLine("I don't jump.");
        }

        public void Run(int howFar)
        {
            Console.WriteLine($"Jeans ran {howFar} miles.");
        }
    }
}
