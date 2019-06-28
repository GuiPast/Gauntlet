using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauntlet
{
    /**
     * This class will show the player select screen to let the player choose his character
     */
    class PlayerSelectScreen : Screen
    {
        Image imgBackground, imgChosenPlayer;
        int chosenPlayer = 1;
        Audio audio;

        public PlayerSelectScreen(Hardware hardware) : base(hardware)
        {
            audio = new Audio(44100, 2, 4096);
            audio.AddWAV("sound/fire.wav");
            imgBackground = new Image("imgs/player_select_screen.png", 800, 600);
            imgChosenPlayer = new Image("imgs/choose_player.png", 48, 48);
            imgBackground.MoveTo(0, 0);
            imgChosenPlayer.MoveTo(510, 125);
        }

        public override void Show()
        {
            bool spacePressed = false;
            do
            {
                hardware.ClearScreen();
                hardware.DrawImage(imgBackground);
                hardware.DrawImage(imgChosenPlayer);
                hardware.UpdateScreen();

                int keyPressed = hardware.KeyPressed();
                if (keyPressed == Hardware.KEY_UP && chosenPlayer > 1)
                {
                    audio.PlayWAV(0, 1, 0);
                    chosenPlayer--;
                    imgChosenPlayer.MoveTo(510, (short)(imgChosenPlayer.Y - 105));
                }
                else if (keyPressed == Hardware.KEY_DOWN && chosenPlayer < 4)
                {
                    audio.PlayWAV(0, 1, 0);
                    chosenPlayer++;
                    imgChosenPlayer.MoveTo(510, (short)(imgChosenPlayer.Y + 105));
                }
                else if (keyPressed == Hardware.KEY_SPACE)
                {
                    spacePressed = true;
                }
            }
            while (!spacePressed);
        }

        public int GetChosenPlayer()
        {
            return chosenPlayer;
        }

    }
}
