using Inheritance.Pieces.Accessories;
using Inheritance.Pieces.Heads;
using Inheritance.Pieces.Legs;
using Inheritance.Pieces.Torsos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class MiniFigure //all minifigures must have these at least
    {
        public string Name { get; private set; }
        public LegBase _legs; 
        public HeadBase _head;
        public TorsoBase _torso;

        public MiniFigure(LegBase legs, HeadBase head, TorsoBase torso, string name) //constructs minifigure
        {
            _legs = legs;
            _head = head;
            _torso = torso;
            Name = name;
        }

        public void Walk(int numberOfSteps)
        {
            switch (_head.HeadGear)
            {
                case Hair hair: //hair is placeholder
                    Console.WriteLine($"{Name} tossed his {hair.Length} {hair.Color} hair in the wind.");
                    break;
                case Helmet helmet:
                    Console.WriteLine($"{Name} wondered why he is wearing a {helmet.Color} helmet. He'd like some hair.");
                    break;
            }

            foreach (var accessory in _torso.Accessories)
            {

            }

            _legs.Walk(numberOfSteps);
        }

        public void SwapTorso(TorsoBase torso)
        {
            if (torso == null)
            {
                throw new ArgumentNullException(nameof(torso));
            }

            _torso = torso;
        }

        public void Accessorize(AccessoryBase accessory)
        {
            _torso.Accessories.Add(accessory);
        }
    }
}
