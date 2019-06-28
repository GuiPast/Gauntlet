using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauntlet
{
    /**
     * This class will show the welcome screen with the game title
     */
    class WelcomeScreen : Screen
    {
        bool exit;
        Image imgWelcome;
        Audio audio;

        public WelcomeScreen(Hardware hardware) : base(hardware)
        {
            exit = false;
            audio = new Audio(44100, 2, 4096);
            audio.AddMusic("sound/title.mid");
            imgWelcome = new Image("imgs/welcome_screen.png", 800, 600);
            imgWelcome.MoveTo(0, 0);
        }

        public override void Show()
        {
            bool escPressed = false, spacePressed = false;
            hardware.DrawImage(imgWelcome);
            hardware.UpdateScreen();
            audio.PlayMusic(0, -1);

            do
            {
                int keyPressed = hardware.KeyPressed();
                if (keyPressed == Hardware.KEY_ESC)
                {
                    escPressed = true;
                    exit = true;
                }
                else if (keyPressed == Hardware.KEY_SPACE)
                {
                    spacePressed = true;
                    exit = false;
                }
            }
            while (!escPressed && !spacePressed);
            audio.StopMusic();
        }

        public bool GetExit()
        {
            return exit;
        }

    }
}
