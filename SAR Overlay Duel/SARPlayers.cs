using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SAR_Overlay_Duel
{
    public class SARPlayers
    {
        private static readonly Regex Parser = new Regex(@"(\d{1,2})\t(.*)\t(.*)\t(.*)\t(.*)\t(.*)\t(.*)");
        private bool participate;
        public List<SARPlayer> PlayersList { get; } = new List<SARPlayer>();
        private string Getplayers;
        public SARPlayers(string getplayers, bool par) 
        {
            participate = par;
            this.Getplayers = getplayers;
            AddLIstPlayer();
        }
        public void AddLIstPlayer()
        {
            int i = participate ? 1 : 2;
            string[] PlayersInfo = Getplayers.Split('\n');
            for(; i < PlayersInfo.Length -1 ; i++)
            {
                PlayersList.Add(Parse(PlayersInfo[i]));
            }
        }
        public new static SARPlayer Parse(string str)
        {
            Match match = Parser.Match(str);
            var pID = (match.Groups[1].Value);
            var SquadID = (match.Groups[4].Value);
            var TeamID = (match.Groups[5].Value);
            var Kills = (match.Groups[6].Value);
            var Placement = (match.Groups[7].Value);
            return new SARPlayer(Convert.ToInt32(pID), match.Groups[2].Value, match.Groups[3].Value, Convert.ToInt32(SquadID), Convert.ToInt32(TeamID), Convert.ToInt32(Kills), Convert.ToInt32(Placement));
        }

    }
}
