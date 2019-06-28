using System.Collections.Generic;
using System.IO;
using System;

namespace Gauntlet
{
    /*
     * This class stores the information of a given level: obstacles, keys, treasures, exit point...
     */ 
    class Level
    {
        public List<Sprite> Walls { get; }
        public List<Treasure> Treasures { get; }
        public Image Floor { get; set; }
        public ExitPoint Exit { get; set; }
        public StartPoint Start { get; set; }
        public short Width { get; set; }
        public short Height { get; set; }
        public short XMap { get; set; }
        public short YMap { get; set; }

        public Level(string fileName)
        {
            Walls = new List<Sprite>();
            Treasures = new List<Treasure>();
            XMap = YMap = 0;
            Floor = new Image("imgs/floor.jpg", 1196, 920);
            string[] lines = File.ReadAllLines(fileName);
            if (lines.Length > 0)
            {
                Width = (short)(lines[0].Length * Sprite.SPRITE_WIDTH);
                Height = (short)(lines.Length * Sprite.SPRITE_HEIGHT);
                for (int i = 0; i < lines.Length; i++)
                {
                    for (int j = 0; j < lines[i].Length; j++)
                    {
                        if (lines[i][j] == 'W')
                        {
                            AddWall(new Wall((short)(j * Sprite.SPRITE_WIDTH),
                                (short)(i * Sprite.SPRITE_HEIGHT)));
                        }
                        else if (lines[i][j] == 'S')
                        {
                            Start = new StartPoint((short)(j * Sprite.SPRITE_WIDTH),
                            (short)(i * Sprite.SPRITE_HEIGHT));
                            XMap = (short)(Math.Max(0, Start.X -
                            GameController.SCREEN_WIDTH / 2));
                            YMap = (short)(Math.Max(0, Start.Y -
                            GameController.SCREEN_HEIGHT / 2));
                        }
                        else if (lines[i][j] == 'E')
                        {
                            Exit = new ExitPoint((short)(j * Sprite.SPRITE_WIDTH),
                            (short)(i * Sprite.SPRITE_HEIGHT));
                        }
                        else if (lines[i][j] == 'T')
                        {
                            Treasures.Add(new Treasure((short)(j * Sprite.SPRITE_WIDTH),
                            (short)(i * Sprite.SPRITE_HEIGHT)));
                        }
                    }
                }
            }
        }
        public bool CollidesCharacterWithTreasure(MainCharacter character)
        {
            int pos = 0;
            bool collided = false;
            while (pos < Treasures.Count && !collided)
            {
                if (character.CollidesWith(Treasures[pos], XMap, YMap))
                {
                    collided = true;
                    Treasures.RemoveAt(pos);
                }
                pos++;
            }
            return collided;
        }

        public void AddWall(Wall w)
        {
            Walls.Add(w);
        }
    }
}
