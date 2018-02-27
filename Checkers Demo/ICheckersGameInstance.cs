using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers_Demo
{
    public interface ICheckersGameInstance
    {
        ILevelData GetLevelData();
        void ResetBoard();
        
    }
}
