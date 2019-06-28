using System;
using System.Threading;

namespace Gauntlet
{
    /*
     * Main application
     */ 
    class Program
    {
        static void Main(string[] args)
        {
            GameController controller = new GameController();
            controller.Start();
        }
    }
}
