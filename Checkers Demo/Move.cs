using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers_Demo
{
    class Move :IMove
    {
        protected Location myLocation;
        protected IChecker myChecker;
        protected Directions myDir;

        public Move(IChecker aChecker, Directions aDir)
        {
            myChecker = aChecker;
            myDir = aDir;
            myLocation = PullLocation();
        }

        public IChecker GetChecker()
        {
            return myChecker;
        }

        public Directions GetDirections()
        {
            return myDir;
        }

        public Location GetLocation()
        {
            return myLocation;
        }

        protected Location PullLocation()
        {
            return new Location(myChecker.GetLocation().GetX(), myChecker.GetLocation().GetY());
        }

    }
}
