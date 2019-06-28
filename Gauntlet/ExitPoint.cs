using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauntlet
{
    class ExitPoint: StaticSprite
    {
        public ExitPoint()
        {
            SpriteX = 10;
            SpriteY = 340;
        }

        public ExitPoint(short x, short y): this()
        {
            X = x;
            Y = y;
        }
    }
}
