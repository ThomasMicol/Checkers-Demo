using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers_Demo
{
    public interface ILevelData
    {
        List<Checker> GetNorthPlayerCheckers();
        List<Checker> GetSouthPlayerCheckers();
        int GetPlayerOneScore();
        int GetPlayerTwoScore();
        char GetCurrentTurn();

    }
}
