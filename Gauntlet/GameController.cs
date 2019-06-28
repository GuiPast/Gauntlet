
namespace Gauntlet
{
    /**
     * This class will manage the screen flow during the game
     */
    class GameController
    {
        public const short SCREEN_WIDTH = 800;
        public const short SCREEN_HEIGHT = 500;
        public void Start()
        {
            Hardware hardware = new Hardware(800, 600, 24, false);

            WelcomeScreen welcome = new WelcomeScreen(hardware);
            CreditsScreen credits = new CreditsScreen(hardware);
            PlayerSelectScreen playerSelect = new PlayerSelectScreen(hardware);
            GameScreen game = new GameScreen(hardware);

            do
            {
                hardware.ClearScreen();
                welcome.Show();
                if (!welcome.GetExit())
                {
                    playerSelect.Show();
                    game.ChosenPlayer = playerSelect.GetChosenPlayer();
                    hardware.ClearScreen();
                    game.Show();
                    hardware.ClearScreen();
                    credits.Show();
                }
            } while (!welcome.GetExit());
        }
    }
}
