using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauntlet
{
    /* 
     * Subtype of main character: Sorcerer
     */ 
    class Sorcerer: MainCharacter
    {
        public Sorcerer(): base()
        {
            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.LEFT] = new int[] { 1954, 8, 442 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.LEFT] = new int[] { 556, 610, 610 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.LEFT_UP] = new int[] { 2008, 64, 496 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.LEFT_UP] = new int[] { 556, 610, 610 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.UP] = new int[] { 1630, 2062, 118 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.UP] = new int[] { 556, 556, 610 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.RIGHT_UP] = new int[] { 1684, 2116, 172 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.RIGHT_UP] = new int[] { 556, 556, 610 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.RIGHT] = new int[] { 1738, 2170, 226 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.RIGHT] = new int[] { 556, 556, 610 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.RIGHT_DOWN] = new int[] { 1792, 2224, 280 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.RIGHT_DOWN] = new int[] { 556, 556, 610 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.DOWN] = new int[] { 1846, 2278, 334 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.DOWN] = new int[] { 556, 556, 610 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.LEFT_DOWN] = new int[] { 1900, 2332, 388 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.LEFT_DOWN] = new int[] { 556, 556, 610 };

            UpdateSpriteCoordinates();
        }

    }
}
