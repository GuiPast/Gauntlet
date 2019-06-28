using System;
using System.Threading;
using Tao.Sdl;
using System.IO;
namespace Gauntlet
{
    /**
     * This class will show the game screen, where we do play Gauntlet
     */
    class GameScreen: Screen
    {
        
        MainCharacter character;
        Level level;
        int chosenPlayer;
        Font font;
        Audio audio;
        IntPtr textPoints, textEnergy;

        public int ChosenPlayer
        {
            get
            {
                return chosenPlayer;
            }

            set
            {
                if (value >= 1 && value <= 4)
                {
                    chosenPlayer = value;
                    switch (value)
                    {
                        case 1:
                            character = new Warrior();
                            break;
                        case 2:
                            character = new Valkyrie();
                            break;
                        case 3:
                            character = new Sorcerer();
                            break;
                        case 4:
                            character = new Dwarf();
                            break;
                    }
                    character.MoveTo(400, 250);
                }
            }
        }

        public GameScreen(Hardware hardware): base(hardware)
        {
            font = new Font("fonts/prince_valiant.ttf", 20);
            audio = new Audio(44100, 2, 4096);
            audio.AddMusic("sound/song_b.mid");
            level = new Level("levels/level1.txt");
            initTexts();
        }

        private void initTexts()
        {
            Sdl.SDL_Color red = new Sdl.SDL_Color(255, 0, 0);
            Sdl.SDL_Color green = new Sdl.SDL_Color(0, 255, 0);
            textEnergy = SdlTtf.TTF_RenderText_Solid(font.GetFontType(), "ENERGY:", red);
            textPoints = SdlTtf.TTF_RenderText_Solid(font.GetFontType(), "POINTS:", green);
            if (textEnergy == IntPtr.Zero || textPoints == IntPtr.Zero)
                Environment.Exit(5);
        }

        private void moveCharacter()
        {
            bool left = hardware.IsKeyPressed(Hardware.KEY_LEFT);
            bool right = hardware.IsKeyPressed(Hardware.KEY_RIGHT);
            bool up = hardware.IsKeyPressed(Hardware.KEY_UP);
            bool down = hardware.IsKeyPressed(Hardware.KEY_DOWN);
            //Tecla para poder correr
            bool shift = hardware.IsKeyPressed(Hardware.KEYS_SHIFT);

            if (up)
            {
                if (character.Y == GameController.SCREEN_HEIGHT / 2 && level.YMap > 0)
                    level.YMap--;
                else if (character.Y > 0)
                    character.Y--;
                //Añadido Correr
                if (shift)
                {
                    if (character.Y == GameController.SCREEN_HEIGHT / 2 && level.YMap > 0)
                        level.YMap -= 2;
                    else if (character.Y > 0)
                        character.Y -= 2;
                }
            }
            if (down)
            {
                if (character.Y == GameController.SCREEN_HEIGHT / 2 && level.YMap < level.Height - GameController.SCREEN_HEIGHT)
                    level.YMap++;
                else if (character.Y < GameController.SCREEN_HEIGHT - Sprite.SPRITE_HEIGHT)
                    character.Y++;
                //Añadido Correr
                if (shift)
                {
                    if (character.Y == GameController.SCREEN_HEIGHT / 2 && level.YMap < level.Height - GameController.SCREEN_HEIGHT)
                        level.YMap += 2;
                    else if (character.Y < GameController.SCREEN_HEIGHT - Sprite.SPRITE_HEIGHT)
                        character.Y += 2;
                }
            }
            if (left)
            {
                if (character.X == GameController.SCREEN_WIDTH / 2 && level.XMap > 0)
                    level.XMap--;
                else if (character.X > 0)
                    character.X--;
                //Añadido Correr
                if (shift)
                {
                    if (character.X == GameController.SCREEN_WIDTH / 2 && level.XMap > 0)
                        level.XMap -= 2;
                    else if (character.X > 0)
                        character.X -= 2;
                }
            }
            if (right)
            {
                if (character.X == GameController.SCREEN_WIDTH / 2 && level.XMap < level.Width - GameController.SCREEN_WIDTH)
                    level.XMap++;
                else if (character.X < GameController.SCREEN_WIDTH - Sprite.SPRITE_WIDTH)
                    character.X++;
                //Añadido Correr
                if (shift)
                {
                    if (character.X == GameController.SCREEN_WIDTH / 2 && level.XMap < level.Width - GameController.SCREEN_WIDTH)
                        level.XMap += 2;
                    else if (character.X < GameController.SCREEN_WIDTH - Sprite.SPRITE_WIDTH)
                        character.X += 2;
                }
            }

            if (left)
                if (up) character.Animate(MovableSprite.SpriteMovement.LEFT_UP);
                else if (down) character.Animate(MovableSprite.SpriteMovement.LEFT_DOWN);
                else character.Animate(MovableSprite.SpriteMovement.LEFT);
            else if (right)
                if (up) character.Animate(MovableSprite.SpriteMovement.RIGHT_UP);
                else if (down) character.Animate(MovableSprite.SpriteMovement.RIGHT_DOWN);
                else character.Animate(MovableSprite.SpriteMovement.RIGHT);
            else if (up)
                character.Animate(MovableSprite.SpriteMovement.UP);
            else if (down)
                character.Animate(MovableSprite.SpriteMovement.DOWN);

        }

        public void DecreaseEnergy(Object o)
        {
            if (character.Energy > 0)
                character.Energy--;
            Sdl.SDL_Color red = new Sdl.SDL_Color(255, 0, 0);
            textEnergy = SdlTtf.TTF_RenderText_Solid(font.GetFontType(),
            "ENERGY: " + character.Energy, red);
        }
        private void updatePoints()
        {
            Sdl.SDL_Color green = new Sdl.SDL_Color(0, 255, 0);
            textPoints = SdlTtf.TTF_RenderText_Solid(font.GetFontType(), "POINTS: " +
            character.Points, green);
        }

        public override void Show()
        {
            short oldX, oldY, oldXMap, oldYMap;
            byte currentLevel = 1;
            bool gameOver = false;
            character.MoveTo((short)(level.Start.X - level.XMap),
                (short)(level.Start.Y - level.YMap));
            audio.PlayMusic(0, -1);
            var timer = new Timer(this.DecreaseEnergy, null, 1000, 1000);
            do
            {
                // 1. Draw everything
                hardware.ClearScreen();
                
                hardware.DrawSprite(level.Floor, 0, 0, level.XMap, level.YMap,
                    GameController.SCREEN_WIDTH, GameController.SCREEN_HEIGHT);

                foreach (Wall wall in level.Walls)
                    hardware.DrawSprite(Sprite.SpriteSheet, (short)(wall.X - level.XMap), 
                        (short)(wall.Y - level.YMap), wall.SpriteX, wall.SpriteY, 
                        Sprite.SPRITE_WIDTH, Sprite.SPRITE_HEIGHT);

                foreach (Treasure t in level.Treasures)
                    hardware.DrawSprite(Sprite.SpriteSheet, (short)(t.X - level.XMap),
                    (short)(t.Y - level.YMap), t.SpriteX, t.SpriteY, Sprite.SPRITE_WIDTH,
                    Sprite.SPRITE_HEIGHT);

                hardware.DrawSprite(Sprite.SpriteSheet, character.X, character.Y, 
                    character.SpriteX, character.SpriteY, Sprite.SPRITE_WIDTH, Sprite.SPRITE_HEIGHT);
                hardware.DrawSprite(Sprite.SpriteSheet, (short)(level.Exit.X - level.XMap),
                   (short)(level.Exit.Y - level.YMap), level.Exit.SpriteX,
                    level.Exit.SpriteY, Sprite.SPRITE_WIDTH, Sprite.SPRITE_HEIGHT);
                hardware.ClearBottom();
                hardware.DrawLine(0, 500, 800, 500, 255, 255, 0, 255);
                hardware.WriteText(textEnergy, 5, 550);
                hardware.WriteText(textPoints, 600, 550);
                hardware.UpdateScreen();

                // 2. Move character from keyboard input
                oldX = character.X;
                oldY = character.Y;
                oldXMap = level.XMap;
                oldYMap = level.YMap;
                moveCharacter();

                // 3. Move enemies and objects

                // 4. Check collisions and update game state
                if (character.CollidesWith(level.Walls, level.XMap, level.YMap))
                {
                    character.X = oldX;
                    character.Y = oldY;
                    level.XMap = oldXMap;
                    level.YMap = oldYMap;
                }
                if (character.CollidesWith(level.Exit, level.XMap, level.YMap))
                {
                    currentLevel++;
                    if (File.Exists("levels/level" + currentLevel + ".txt"))
                    {
                        level = new Level("levels/level" + currentLevel + ".txt");
                        character.MoveTo((short)(level.Start.X - level.XMap),
                        (short)(level.Start.Y - level.YMap));
                    }
                    else
                    {
                        gameOver = true;
                    }
                }
                if (level.CollidesCharacterWithTreasure(character))
                {
                    character.Points = (ushort)(character.Points + Treasure.TREASURE_SCORE);
                    updatePoints();
                }
                if (character.Energy <= 0)                    gameOver = true;

                // 5. Pause game
                //Thread.Sleep(5);

            } while (!gameOver && !hardware.IsKeyPressed(Hardware.KEY_ESC));
            audio.StopMusic();
            timer.Dispose();
        }
    }
}
