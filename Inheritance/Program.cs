using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.Pieces.Legs;


namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var shorts = new Shorts
            {
                Color = "Tan",
                Length = Length.School,
                Size = LegSize.Baby,
                NumberOfPockets = 6
            };

            var jeans = new Jeans
            {
                Color = "Black",
                Size = LegSize.Adult,
                NumberOfPockets = 4
            };

            var jeans2 = new Jeans
            {
                Color = "Blue",
                Size = LegSize.Child,
                NumberOfPockets = 3
            };

            var jeans3 = new Jeans
            {
                Color = "Purple",
                Size = LegSize.Baby,
                NumberOfPockets = 6
            };

            var skirt = new Skirt
            {
                Color = "Rainbow",
                Size = LegSize.Child,
                NumberOfPockets = 0,
                Material = "Fishnet",
                Length = Length.StreetCorner
            };

            var skirt2 = new Skirt
            {
                Color = "Black",
                Size = LegSize.Adult,
                NumberOfPockets = 2,
                Material = "Fishnet",
                Length = Length.StreetCorner
            };

            var legs = new List<LegBase>
            {
                shorts,
                skirt,
                jeans,
                jeans2,
                jeans3,
                skirt2
            };

            foreach (var leg in legs) //leg is LegBase
            {
                leg.Walk(10);
            }
       
            Console.ReadLine();

        }
    }
}
