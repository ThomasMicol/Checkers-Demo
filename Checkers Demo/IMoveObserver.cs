using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers_Demo
{
    interface IMoveObserver
    {
        List<Move> GetPossibleMoves(ILevelData levelData);
        bool IsMovePossible(IMove aMove);
    }
}
