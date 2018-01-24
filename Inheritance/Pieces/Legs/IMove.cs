using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Pieces.Legs
{
    interface IMoveable //cannot define what a class does //always public
    {
        int HowFarIMoved { get; } //anything using IMoveable MUST have this property and MUST have a getter

        void Walk(int howManySteps);
        void Jump(int howHigh);
        void Run(int howFar);
    }
}
