using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauntlet
{
    class Treasure : StaticSprite
    {
        public const short TREASURE_SCORE = 500;
        public Treasure()
        {
            SpriteX = 1144;
            SpriteY = 340;
        }
        public Treasure(short x, short y) : this()
        {
            X = x;
            Y = y;
        }
    }
}
