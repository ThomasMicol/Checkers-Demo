using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers_Demo
{
    public interface ILevelData
    {
        List<Location> GetPlayerOneLocations();
        List<Location> GetPlayerTwoLocations();
        int GetPlayerOneScore();
        int GetPlayerTwoScore();

    }
}
