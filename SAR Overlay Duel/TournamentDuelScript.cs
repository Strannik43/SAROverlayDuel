using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Markup;


namespace SAR_Overlay_Duel
{
    public class TournamentDuelScript
    {

        private bool flagliveplayers = true;
        public bool participate;
        TournamentDuelInfoWindow TournamentDuelInfoWindow;
        List<SARLocation> SARLocations = new List<SARLocation>()
            {
                new SARLocation("Museum", 911, 579, 1106, 580 ),
                new SARLocation("Safari", 886, 895, 1001, 843 ),
                new SARLocation("Studio", 426, 1108, 610, 1107 ),
                new SARLocation("Shooting gallery", 761, 1063,1013,1063 ),
                new SARLocation("Theatre entrance", 664, 1316, 938, 1316 ),
                new SARLocation("Theatre scene",661, 1594, 942, 1594 ),
                new SARLocation("Bar", 1315, 1342, 1511, 1302 ),
                new SARLocation("HQ", 1174, 1904, 1326, 1733 ),
                new SARLocation("Resort statue", 2482, 2164, 2651, 2164),
                new SARLocation("Camp D7", 1701, 563, 1825, 637 ),
                new SARLocation("Island", 3308, 311, 3569,265 ),
                new SARLocation("Port storage", 4003, 1832, 4241, 1782),
                new SARLocation("Cargo F4", 3181, 2422, 3284, 2576),
                new SARLocation("Port houses", 3843, 2296,3841, 2180),
                new SARLocation("Security", 3401,1764, 3572, 1888 ),
                new SARLocation("Lab 3", 2985, 3076, 2985, 2887),
                new SARLocation("Lab 2", 2612, 3152, 2799, 3223),
                new SARLocation("Lab 1", 2409,3088, 2409, 2876 ),
                new SARLocation("Lab outside", 2943, 3125, 3101, 3220),
                new SARLocation("Resort main", 2427, 1830, 2721, 1830 ),
                new SARLocation("Emu farm", 1792, 2572, 1989, 2575 ),
                new SARLocation("Pyramid short", 1291, 2700,1518, 2700),
                new SARLocation("Milk bar",2674, 1200,2827,1195 ),
                new SARLocation("Farm short", 2660, 1320, 2770,1397 ),
                new SARLocation("Ice palace",1991, 3863, 2324, 3838 ),
                new SARLocation("Two houses", 3273, 4272,3468, 4226 ),
                new SARLocation("Cargo H3", 4054, 3366, 4159, 3276 ),
                new SARLocation("Lab forest", 2881, 2753, 3110, 2727),
                new SARLocation("Cargo F2",2945, 3955, 3140,4018 ),
                new SARLocation("Sahara short", 780, 2655, 924,2596 ),
                new SARLocation("Hill short", 1395, 3189, 1520, 3188),
                new SARLocation("Cargo B1", 847, 4317, 1028, 4359),
            };
        private SARPlayers SARPlayersInfo;
        List<SARPlayer> LivePlayers;
        Random RND = new Random();
        public TournamentDuelScript(TournamentDuelInfoWindow tournamentDuelInfoWindow)
        {
            TournamentDuelInfoWindow = tournamentDuelInfoWindow;
        }
        public void StartMatch()
        {
            flagliveplayers = true; 
            SARCommandsInput.SARSendCommand("emus");
            SARCommandsInput.SARSendCommand("god all");
            SARCommandsInput.SARSendCommand("allitems");
            SARCommandsInput.SARSendCommand("gasoff");
            SARCommandsInput.SARSendCommand("gasoff");
            SARCommandsInput.SARSendCommand("hamballs");
            SARCommandsInput.SARSendCommand("startp"); 
            SARCommandsInput.SARSendCommand("startp"); 

        }
        public void GetplayersToList()
        { 
            SARCommandsInput.SARSendCommand("getplayers");
            SARCommandsInput.SARSendCommand("getplayers");
            SARCommandsInput.SARSendCommand("getplayers");
            string data = System.Windows.Clipboard.GetText();
            SARPlayersInfo = new SARPlayers(data, participate);
            if( flagliveplayers )
            {
                SARPlayers LivePlayersclass = new SARPlayers(data, participate);
                LivePlayers = LivePlayersclass.PlayersList;
                flagliveplayers = false;
            }
        }
        public void PlayersTeleToLocations()
        {    
            foreach (var player in LivePlayers)
            {
                SARCommandsInput.SARSendCommand($"tele {player.pID} {player.Xposition} {player.Yposition}");
                SARCommandsInput.SARSendCommand($"tele {player.pID} {player.Xposition} {player.Yposition}");
            }
        }
        public void PlayersTeleToLobby()
        {
            foreach(var player in LivePlayers)
            {
                    SARCommandsInput.SARSendCommand($"tele {player.pID} {Parameters.lobbyX} {Parameters.lobbyY}");
                    SARCommandsInput.SARSendCommand($"tele {player.pID} {Parameters.lobbyX} {Parameters.lobbyY}");
            }
        }
        public void CouplePlayersGeneration()
        {
            for (int i = 0; i < SARLocations.Count; i++)
            {
                SARLocation tmp = SARLocations[0];
                SARLocations.RemoveAt(0);
                SARLocations.Insert(RND.Next(SARLocations.Count), tmp);
            }
            GetplayersToList();
            foreach (var player in LivePlayers)
            {
                player.EnemyID = 0;
                player.Xposition = Parameters.lobbyX;
                player.Yposition = Parameters.lobbyY;
            }
            for (int i = 0; i < LivePlayers.Count; i++)
            {
                SARPlayer tmp = LivePlayers[0];
                LivePlayers.RemoveAt(0);
                LivePlayers.Insert(RND.Next(LivePlayers.Count), tmp);
            }
            TournamentDuelInfoWindow.ListBoxPlayers.Items.Clear();
            for (int i = 0,j = LivePlayers.Count -1; i < LivePlayers.Count / 2 && j >= LivePlayers.Count / 2; i +=1, j-=1)
            {
                LivePlayers[i].EnemyID = LivePlayers[j].pID;
                LivePlayers[j].EnemyID = LivePlayers[i].pID;
                LivePlayers[i].Xposition = SARLocations[i].LocationPlayerOnePointSpawnX;
                LivePlayers[i].Yposition = SARLocations[i].LocationPlayerOnePointSpawnY;
                LivePlayers[j].Xposition = SARLocations[i].LocationPlayerTwoPointSpawnX;
                LivePlayers[j].Yposition = SARLocations[i].LocationPlayerTwoPointSpawnY;
                SARCommandsInput.SARSendCommand($"yell {LivePlayers[i].Player} VS {LivePlayers[j].Player} In {SARLocations[i].LocationName}");
                if (i > 16)
                {
                    TournamentDuelInfoWindow.ListBoxPlayers2.Items.Add($"{LivePlayers[i].pID} {LivePlayers[i].Player}  VS  {LivePlayers[j].pID} {LivePlayers[j].Player}  In  {SARLocations[i].LocationName}");
                }
                else
                {
                    TournamentDuelInfoWindow.ListBoxPlayers.Items.Add($"{LivePlayers[i].pID} {LivePlayers[i].Player}  VS  {LivePlayers[j].pID} {LivePlayers[j].Player}  In  {SARLocations[i].LocationName}");
                }
            }
        }
        public void TournamentFinishedThisRound()
        {
            bool flag = true;
            List<SARPlayer>ActualLivePlayer = new List<SARPlayer>();
            GetplayersToList();
  
            for (int i = 0; i < SARPlayersInfo.PlayersList.Count;i++) 
            {
                for(int j = 0; j < LivePlayers.Count; j++)
                {
                    LivePlayers[j].Placement = LivePlayers[j].pID == SARPlayersInfo.PlayersList[i].pID ? SARPlayersInfo.PlayersList[i].Placement : LivePlayers[j].Placement;
                }
            }
            foreach (var player in LivePlayers)
            {
                if (player.Placement == -1) { ActualLivePlayer.Add(player); }  
            }
            foreach (var player in ActualLivePlayer)
            {
                foreach(var playerenemy in ActualLivePlayer)
                {
                    if (playerenemy.pID == player.EnemyID)
                    {
                        flag = false;
                    }
                }
            }
            if (flag)
            {
                foreach (var player in LivePlayers)
                {
                    if (player.Placement != -1) { SARCommandsInput.SARSendCommand($"ghost {player.pID}"); }
                }
                LivePlayers = ActualLivePlayer;
                PlayersTeleToLobby();
                SARCommandsInput.SARSendCommand("god all");
                

            }
            else
            {
                System.Windows.MessageBox.Show("Не все игроки убили своих противников");
            }
        }
        public void StartNextRound()
        {
            CouplePlayersGeneration();
            if (!participate)
            {
                SARCommandsInput.SARSendCommand("kill 1");
                SARCommandsInput.SARSendCommand("ghost");
            }
            SARCommandsInput.SARSendCommand($"yell Start in 10 seconds");
            Thread.Sleep(5000);
            for (var i = 5; i > 0; i--) 
            {
                SARCommandsInput.SARSendCommand($"yell {i}");
                Thread.Sleep(1000);
            }
            PlayersTeleToLocations();
            SARCommandsInput.SARSendCommand("god all");

        }
    }
}
