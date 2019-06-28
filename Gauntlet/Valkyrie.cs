using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauntlet
{
    /*
     * Subtype of main character: Valkyrie
     */ 
    class Valkyrie: MainCharacter
    {
        public Valkyrie()
        {
            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.LEFT] = new int[] { 2332, 388, 820 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.LEFT] = new int[] { 502, 556, 556 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.LEFT_UP] = new int[] { 8, 442, 874 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.LEFT_UP] = new int[] { 556, 556, 556 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.UP] = new int[] { 2008, 64, 496 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.UP] = new int[] { 502, 556, 556 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.RIGHT_UP] = new int[] { 2062, 118, 550 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.RIGHT_UP] = new int[] { 502, 556, 556 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.RIGHT] = new int[] { 2116, 172, 604 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.RIGHT] = new int[] { 502, 556, 556 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.RIGHT_DOWN] = new int[] { 2170, 226, 658 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.RIGHT_DOWN] = new int[] { 502, 556, 556 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.DOWN] = new int[] { 2224, 280, 712 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.DOWN] = new int[] { 502, 556, 556 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.LEFT_DOWN] = new int[] { 2278, 334, 766 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.LEFT_DOWN] = new int[] { 502, 556, 556 };

            UpdateSpriteCoordinates();

        }
    }
}
