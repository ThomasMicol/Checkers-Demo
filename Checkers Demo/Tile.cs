using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers_Demo
{
    class Tile
    {
        protected bool isShaded = false;
        protected bool isBackRow = false;
        protected Location myLocation;

        public void SetIsShaded(bool inShaded)
        {
            isShaded = inShaded;
        }

        public void SetInBackRow(bool inBackRow)
        {
            isBackRow = inBackRow;
        }

        public void SetMyLocation(Location aLocation)
        {
            myLocation = aLocation;
        }

        public bool GetIsShaded()
        {
            return isShaded;
        }

        public bool GetIsBackRow()
        {
            return isBackRow;
        }

        public int GetX()
        {
            return myLocation.GetX();
        }

        public int GetY()
        {
            return myLocation.GetY();
        }
    }
}
