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
        protected IMoveObserver moveObserver;
        protected ICheckerView myView;

        public CheckersController(ICheckerView aView)
        {
            myView = aView;
            moveObserver = new MoveObserver();
            BootGame();
        }

        public void Move(Checker aChecker, Directions aDir)
        {
            if (!aChecker.Move(aDir))
            {
                myView.Message("Move was unsuccessful");
            }
            else {
                myView.DrawGameLevel(myGame.GetLevelData());
            }
        }

        protected void BootGame()
        {
            myGame = new CheckerBoard();
            myView.DrawGameLevel(myGame.GetLevelData());
        }


    }
}
