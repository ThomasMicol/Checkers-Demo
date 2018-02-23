﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers_Demo
{
    class Checker
    {
        protected char owningPlayer;
        protected bool isCapped = false;
        protected Location myLocation;

        public void SetMyLocation(Location aLocation)
        {
            myLocation = aLocation;
        }

        public void SetOwingPlayer(char boardSide)
        {
            owningPlayer = boardSide;
        }

        public void SetIsCapped()
        {
            isCapped = true;
        }
    }
}