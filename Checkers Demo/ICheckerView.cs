using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers_Demo
{
    public interface ICheckerView
    {
        void DrawMainMenu();
        void DrawGameLevel(ILevelData levelData);
    }
}
