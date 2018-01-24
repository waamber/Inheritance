using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Pieces.Legs
{
    interface IMove //cannot define what a class does
    {
        void Walk(int howManySteps);
        void Jump(int howHigh);
        void Run(int howFar);
    }
}
