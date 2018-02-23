using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers_Demo
{
    public class CheckersController
    {
        protected ICheckersGameInstance myGame;
        protected ICheckerView myView;

        public CheckersController(ICheckerView aView)
        {
            myView = aView;
            BootGame();
        }

        protected void BootGame()
        {
            myGame = new CheckerBoard();
        }
    }
}
