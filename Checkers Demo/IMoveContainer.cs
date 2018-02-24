using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers_Demo
{
    interface IMoveContainer
    { 
        void AddMove(IChecker aChecker, Directions aDir);
        void RemoveMove(IChecker aChecker, Directions aDir);
    }
}
