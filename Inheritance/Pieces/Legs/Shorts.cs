using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Pieces.Legs
{
    class Shorts : LegBase //inherits properties from legbase
    {
        public string Material { get; set; }
        public Length Length { get; set; }

        public override void Jump(int howHigh)
        {
            Console.WriteLine($"Shorts jumped {howHigh} feet in the air.");
        }
    }


}
