using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers_Demo
{
    interface IMove
    {
        Location GetLocation();
        IChecker GetChecker();
        Directions GetDirections();
    }
}
