using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers_Demo
{
    public class Checker : IChecker
    {
        protected char owningPlayer;
        protected bool isCapped = false;
        protected Location myLocation;

        public void Move(Directions aDir)
        {

        }

        public void SetOwingPlayer(char boardSide)
        {
            owningPlayer = boardSide;
        }

        public void SetIsCapped()
        {
            isCapped = true;
        }

        public Location GetLocation()
        {
            return myLocation;
        }
    }
}
