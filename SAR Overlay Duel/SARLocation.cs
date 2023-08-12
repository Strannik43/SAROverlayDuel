using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAR_Overlay_Duel
{
    internal class SARLocation
    {
        public string LocationName;
        public int LocationPlayerOnePointSpawnX;
        public int LocationPlayerOnePointSpawnY;
        public int LocationPlayerTwoPointSpawnX;
        public int LocationPlayerTwoPointSpawnY;
        public SARLocation(string LocationName, int X1,int Y1, int X2, int Y2) 
        {
            this.LocationName = LocationName;
            LocationPlayerOnePointSpawnX = X1;
            LocationPlayerOnePointSpawnY = Y1;
            LocationPlayerTwoPointSpawnX = X2;
            LocationPlayerTwoPointSpawnY = Y2;

        }   
    }
}
