
namespace Gauntlet
{
    /*
     * This class represents every wall of every stage of the game
     */ 
    class Wall: StaticSprite
    {
        public Wall()
        {
            SpriteX = 1629;
            SpriteY = 663;
        }

        public Wall(short x, short y): this()
        {
            X = x;
            Y = y;
        }
    }
}
