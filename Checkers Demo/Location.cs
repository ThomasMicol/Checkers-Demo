using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers_Demo
{
    public class Location
    {
        protected int y;
        protected int x;

        public Location(int inX, int inY)
        {
            x = inX;
            y = inY;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }
    }
}
