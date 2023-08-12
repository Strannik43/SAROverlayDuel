using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SAR_Overlay_Duel
{
    public class SARSpawnPoints
    {

        public bool FlagStopSpawn = true;
        public List<Point> Points = new List<Point>();
        public SARSpawnPoints(List<Point> Points) 
        {
            this.Points = Points;
        }
        public void SpawnLobbyItems(int CountItem, int LobbyMidX, int LobbyMidY)
        {
           FlagStopSpawn = false;
           foreach (var SpawnItemPoints in this.Points)
           {
                if (SpawnItemPoints.ItemName != null)
                {
                    Thread.Sleep(20);
                    SARCommandsInput.SARSendCommand($"tele 1 {SpawnItemPoints.X} {SpawnItemPoints.Y}");
                    Thread.Sleep(20);
                    SARCommandsInput.SARSendCommand($"tele 1 {SpawnItemPoints.X} {SpawnItemPoints.Y}");
                    Thread.Sleep(200);
                    for (int i = 0; i < CountItem; i++)
                    {
                        SARCommandsInput.Spawn(SpawnItemPoints.ItemName);
                    }
                }
           }
            if (Parameters.SpawnStartMatch)
            {
                SARCommandsInput.SARSendCommand($"tele all {LobbyMidX} {LobbyMidY}");
                SARCommandsInput.SARSendCommand($"tele all {LobbyMidX} {LobbyMidY}");
                Parameters.lobbyX = LobbyMidX;
                Parameters.lobbyY = LobbyMidY;
                Parameters.SpawnStartMatch = false;
            }
            FlagStopSpawn = true ;
        }
    }
    public class Point
    {
        public int X { get; }
        public int Y { get; }
        public string ItemName { get; set; }
        public string ItemIcon { get; set; }
        public string Background = "#FF474747";
        public Point(int X, int Y) 
        {
            this.X = X;
            this.Y = Y;
        }

    }
}
