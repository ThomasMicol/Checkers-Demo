using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers_Demo
{
    public interface ICheckersGameInstance
    {
        Boolean Move(Directions aDir);
        ILevelData GetLevelData();
        void ResetBoard();
        
    }
}
