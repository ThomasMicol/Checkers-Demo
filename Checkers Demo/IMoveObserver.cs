using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers_Demo
{
    interface IMoveObserver
    {
        List<IMove> GetPossibleMoves(ILevelData levelData);
        bool IsMovePossible(IMove aMove);
    }
}
