using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers_Demo
{
    class CheckerBoard : ICheckersGameInstance
    {
        protected int height = 8;
        protected int width = 8;
        protected List<Tile> tileData;
        protected List<Checker> checkerData;
        

        public CheckerBoard()
        {
            ResetBoard();
        }

        public ILevelData GetLevelData()
        {
            throw new NotImplementedException();
        }

        public bool Move(Directions aDir)
        {
            throw new NotImplementedException();
        }

        public void ResetBoard()
        {
            tileData = new List<Tile>();
            for(int x = 0; x < width; x++)
            {
                for(int y = 0; y < height; y++)
                {
                    Tile aTile = new Tile();
                    if(y == 0 || y == 7)
                    {
                        aTile.SetInBackRow(true);
                    }
                    else
                    {
                        aTile.SetInBackRow(false);
                    }

                    if(((x%2) == 0) && ((y%2) > 0))
                    {
                        aTile.SetIsShaded(true);
                    }
                    if(((x % 2) > 0) && ((y % 2) == 0))
                    {
                        aTile.SetIsShaded(true);
                    }
                    aTile.SetMyLocation(new Location(x, y));
                    tileData.Add(aTile);
                }
            }
            PlaceCheckers();
        }

        protected void PlaceCheckers()
        {
            foreach(Tile aTile in tileData)
            {
                if(((aTile.GetY() >= (height /2) - 1) || (aTile.GetY() <= (height / 2) - 1)) && aTile.GetIsShaded())
                {
                    
                }
            }
        }
    }
}
