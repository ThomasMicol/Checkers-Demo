using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers_Demo
{
    interface IMoveObserver
    {
        IMoveContainer GetPossibleMoves(ILevelData levelData);
        bool IsMovePossible(IMoveContainer aMove);
    }
}
