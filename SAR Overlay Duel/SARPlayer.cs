
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace SAR_Overlay_Duel
{
    public class SARPlayer
    {
        public int pID { get; }
        public string Player { get; }
        public string PlayfabID { get; }
        public int SquadID { get; }
        public int TeamID { get; }
        public int Kills { get; }
        public int Placement { get; set; }
        public int EnemyID { get; set; }
        public int Xposition { get; set; }
        public int Yposition { get; set; }

        public SARPlayer(int pID, string player, string playfabID, int squadID, int teamID, int kills, int placement)
        {
            this.pID = pID;
            Player = player;
            PlayfabID = playfabID;
            SquadID = squadID;
            TeamID = teamID;
            Kills = kills;
            Placement = placement;
        }
    }

}
