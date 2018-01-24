using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Pieces.Legs
{
    class Jeans : LegBase
    {
        public override void Jump(int howHigh)
        {
            Console.WriteLine("I don't jump.");
        }
    }
}
