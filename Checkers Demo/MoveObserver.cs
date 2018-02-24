using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers_Demo
{
    class MoveObserver : IMoveObserver
    {
        public IMoveContainer GetPossibleMoves(ILevelData levelData)
        {
            IMoveContainer possibleMoves = new MoveContainer();

            List<Checker> myCheckers = levelData.GetNorthPlayerCheckers();
            List<Checker> theirCheckers = levelData.GetSouthPlayerCheckers();

            if (levelData.GetCurrentTurn() == 'N')
            {
                myCheckers = levelData.GetNorthPlayerCheckers();
                theirCheckers = levelData.GetSouthPlayerCheckers();
            }
            else
            {
                myCheckers = levelData.GetSouthPlayerCheckers();
                theirCheckers = levelData.GetNorthPlayerCheckers();
            }
            
            foreach(Checker myChecker in myCheckers)
            {
                int myX = myChecker.GetLocation().GetX();
                int myY = myChecker.GetLocation().GetY();
                foreach (Checker theirChecker in theirCheckers)
                {
                    int theirX = theirChecker.GetLocation().GetX();
                    int theirY = theirChecker.GetLocation().GetY();
                    if(myY == (theirY - 1) && myX == (theirX - 1))
                    {
                        
                    }

                    if (myY == (theirY - 1) && myX == (theirX + 1))
                    {

                    }

                    if (myY == (theirY + 1) && myX == (theirX - 1))
                    {

                    }

                    if (myY == (theirY + 1) && myX == (theirX + 1))
                    {

                    }
                }
            }
            return possibleMoves;
        }

        public bool IsMovePossible(IMoveContainer aMove)
        {
            throw new NotImplementedException();
        }
    }
}
