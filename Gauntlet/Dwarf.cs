using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauntlet
{
    /*
     * Subtype of main character: Dwarf
     */ 
    class Dwarf: MainCharacter
    {
        public Dwarf(): base()
        {
            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.LEFT] = new int[] { 1576, 2008, 64 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.LEFT] = new int[] { 610, 610, 664 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.LEFT_UP] = new int[] { 1630, 2062, 118 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.LEFT_UP] = new int[] { 610, 610, 664 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.UP] = new int[] { 1252, 1684, 2116 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.UP] = new int[] { 610, 610, 610 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.RIGHT_UP] = new int[] { 1306, 1738, 2170 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.RIGHT_UP] = new int[] { 610, 610, 610 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.RIGHT] = new int[] { 1360, 1792, 2224 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.RIGHT] = new int[] { 610, 610, 610 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.RIGHT_DOWN] = new int[] { 1414, 1846, 2278 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.RIGHT_DOWN] = new int[] { 610, 610, 610 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.DOWN] = new int[] { 1468, 1900, 2332 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.DOWN] = new int[] { 610, 610, 610 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.LEFT_DOWN] = new int[] { 1522, 1954, 8 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.LEFT_DOWN] = new int[] { 610, 610, 664 };

            UpdateSpriteCoordinates();
        }

    }
}
