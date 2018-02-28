using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers_Demo
{
    interface IChecker
    {
        void SetMyLocation(Location aLocation);
        void SetOwingPlayer(char boardSide);
        void SetIsCapped();
        Location GetLocation();
        bool Move(Directions aDir);
    }
}
