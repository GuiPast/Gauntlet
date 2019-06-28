using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * This class will be the parent of every screen in the video game
 */ 
namespace Gauntlet
{
    class Screen
    {
        protected Hardware hardware;

        public Screen(Hardware hardware)
        {
            this.hardware = hardware;
        }

        public virtual void Show()
        {
        }
    }
}
