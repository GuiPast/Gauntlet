using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauntlet
{
    /*
     * Subtype of main character: Warrior
     */ 
    class Warrior: MainCharacter
    {
        public Warrior(): base()
        {
            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.LEFT] = new int[] { 334, 766, 1198 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.LEFT] = new int[] { 502, 502, 502 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.LEFT_UP] = new int[] { 388, 820, 1252 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.LEFT_UP] = new int[] { 502, 502, 502 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.UP] = new int[] { 8, 442, 874 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.UP] = new int[] { 502, 502, 502 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.RIGHT_UP] = new int[] { 64, 496, 928 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.RIGHT_UP] = new int[] { 502, 502, 502 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.RIGHT] = new int[] { 118, 550, 982 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.RIGHT] = new int[] { 502, 502, 502 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.RIGHT_DOWN] = new int[] { 172, 604, 1036 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.RIGHT_DOWN] = new int[] { 502, 502, 502 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.DOWN] = new int[] { 226, 658, 1090 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.DOWN] = new int[] { 502, 502, 502 };

            SpriteXCoordinates[(int)MovableSprite.SpriteMovement.LEFT_DOWN] = new int[] { 280, 712, 1144 };
            SpriteYCoordinates[(int)MovableSprite.SpriteMovement.LEFT_DOWN] = new int[] { 502, 502, 502 };

            UpdateSpriteCoordinates();
        }
    }
}
