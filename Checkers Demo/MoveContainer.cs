using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers_Demo
{
    class MoveContainer : IMoveContainer
    {
        protected List<IMove> possibleMoves;
        public MoveContainer()
        {
            possibleMoves = new List<IMove>();
        }

        public void AddMove(IChecker aChecker, Directions aDir)
        {
            throw new NotImplementedException();
        }

        public void RemoveMove(IChecker aChecker, Directions aDir)
        {
            throw new NotImplementedException();
        }

        protected bool checkForDuplicates(IMove targetMove)
        {
            foreach(IMove aMove in possibleMoves)
            {
                if (aMove.Equals(targetMove))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
