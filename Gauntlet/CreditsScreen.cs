
namespace Gauntlet
{
    /**
     * This class will show the credits screen of the game, and wait for the user to press spacebar key to go back to the welcome screen
     */
    class CreditsScreen: Screen
    {
        Image imgCredits;

        public CreditsScreen(Hardware hardware): base(hardware)
        {
            imgCredits = new Image("imgs/game_over_screen.png", 800, 600);
            imgCredits.MoveTo(0, 0);
        }

        public override void Show()
        {
            hardware.DrawImage(imgCredits);
            hardware.UpdateScreen();

            while (hardware.KeyPressed() != Hardware.KEY_SPACE);
        }
    }
}
