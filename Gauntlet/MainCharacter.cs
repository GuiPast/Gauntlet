using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauntlet
{
    /*
     * This Sprite subclass is used to define the attributes of the main character (coordinates, energy, points, sprite coordinates in spritesheet...)
     */ 
    class MainCharacter: MovableSprite
    {
        public ushort Energy { get; set; }
        public ushort Points { get; set; }

        public MainCharacter()
        {
            Energy = 1000;
            Points = 0;
        }
    }
}
