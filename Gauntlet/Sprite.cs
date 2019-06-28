using System.Collections.Generic;

namespace Gauntlet
{
    /*
     * This class is the base class for every sprite of the sprite sheet, either the main character, enemies, obstacles...
     */ 
    class Sprite
    {
        public static Image SpriteSheet = new Image("imgs/gauntlet_spritesheet.png", 2385, 768);

        public const short SPRITE_WIDTH = 46;
        public const short SPRITE_HEIGHT = 46;

        public short X { get; set; }
        public short Y { get; set; }
        public short SpriteX { get; set; }
        public short SpriteY { get; set; }

        public void MoveTo(short x, short y)
        {
            X = x;
            Y = y;
        }

        public bool CollidesWith(Sprite sp, short xOffset, short yOffset)
        {
            return (X + xOffset + Sprite.SPRITE_WIDTH > sp.X && X + xOffset < sp.X + Sprite.SPRITE_WIDTH &&
                    Y + yOffset + Sprite.SPRITE_HEIGHT > sp.Y && Y + yOffset < sp.Y + Sprite.SPRITE_HEIGHT);
        }

        public bool CollidesWith(List<Sprite> sprites, short xOffset, short yOffset)
        {
            foreach (Sprite sp in sprites)
                if (this.CollidesWith(sp, xOffset, yOffset))
                    return true;
            return false;
        }
    }
}
