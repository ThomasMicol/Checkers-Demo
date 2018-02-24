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
            IMove aMove = new Move(aChecker, aDir);
            if (CheckForDuplicates(aMove))
            {
                System.Console.WriteLine("This move already exists in the possible moves array. File MOveCOntainer.cs, Line 22");

            }
            else
            {
                possibleMoves.Add(aMove);
            }
            
        }

        public void RemoveMove(IChecker aChecker, Directions aDir)
        {
            foreach(IMove aMove in possibleMoves)
            {
                if (aMove.GetChecker().Equals(aChecker) && aMove.GetDirections() == aDir)
                {
                    possibleMoves.Remove(aMove);
                    break;
                }
            }
        }

        protected bool CheckForDuplicates(IMove targetMove)
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
