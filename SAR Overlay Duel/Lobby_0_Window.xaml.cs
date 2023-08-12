using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SAR_Overlay_Duel
{
    /// <summary>
    /// Логика взаимодействия для Lobby_0_Window.xaml
    /// </summary>
    /// Осторожно говонокод 

    public partial class Lobby_0_Window : Window
    {

        public SARItemsPanelWindow SARItemsPanelLobby0Window;
        List<Button> AllWindowButtons = new List<Button>();    
        public SARSpawnPoints LobbySpawnItemPoints = new SARSpawnPoints( new List<Point>
            {
                new Point(667,844),
                new Point(706,844),
                new Point(666,810),
                new Point(706,810),
                new Point(649,787),
                new Point(688,787),
                new Point(725,787),

                new Point(650,680),
                new Point(688,680),
                new Point(725,680),
                new Point(667,645),
                new Point(709,645),
                new Point(667,620),
                new Point(709,620),

                new Point(608,758),
                new Point(575,758),
                new Point(528,758),
                new Point(495,758),
                new Point(449,758),
                new Point(416,758),

                new Point(607, 708),
                new Point(574, 708),
                new Point(529, 708),
                new Point(495, 708),
                new Point(448, 708),
                new Point(415, 708),

                new Point(768,758),
                new Point(803,758),
                new Point(847,758),
                new Point(881,758),
                new Point(928,758),
                new Point(960,758),

                new Point(752,708),
                new Point(801,708),
                new Point(848,708),
                new Point(883,708),
                new Point(926,708),
                new Point(962,708),
            }
            );
        public Lobby_0_Window(SARItemsPanelWindow SARItemsPanelLobby0Window)
        {
            InitializeComponent();
            Left = 70;
            Top = 300;
            AllWindowButtons = new List<Button>()
            { 
                Top1, Top2, Top3, Top4, Top5, Top6, Top7,
                Left1, Left2, Left3, Left4, Left5, Left6,
                Left7, Left8, Left9, Left10, Left11, Left12,
                Right1, Right2, Right3, Right4, Right5, Right6,
                Right7, Right8, Right9, Right10, Right11, Right12,
                Down1, Down2, Down3, Down4, Down5, Down6, Down7,

            };
            this.SARItemsPanelLobby0Window = SARItemsPanelLobby0Window;
        }
        private void SpawnPoints(object sender, RoutedEventArgs e)
        {
            if (SARItemsPanelLobby0Window.FlagButtonAktiv)
            {
                int PointIndex = Int32.Parse((string)((Button)e.OriginalSource).Tag);
                Point SpawnPoint = LobbySpawnItemPoints.Points[PointIndex];
                SARItemsPanelLobby0Window.AddItemToPointSpawn(SpawnPoint);
                if (SpawnPoint.ItemName != null)
                {
                    SpawnPoint.ItemIcon = SpawnPoint.ItemName.Contains('_') ? SpawnPoint.ItemName.Split('_')[0] : SpawnPoint.ItemName.Contains(' ') ? SpawnPoint.ItemName.Split(' ')[0] : SpawnPoint.ItemName;
                    Button SenderButton = (Button)e.OriginalSource;
                    SenderButton.Content = FindResource(SpawnPoint.ItemIcon);
                    SenderButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(SpawnPoint.Background));
                }
            }
        }
        public void StartSpawn()
        {
            LobbySpawnItemPoints.SpawnLobbyItems(15, 688 ,680);
        }
        public void Clear()
        {
            foreach(var point in LobbySpawnItemPoints.Points)
            {
                point.ItemName = null;
                point.ItemIcon = null;
                point.Background = "#FF474747";
            }
            foreach(var klickbutton  in AllWindowButtons)
            {
                klickbutton.Content = null;
                klickbutton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF474747"));
            }
        }
        public void Profile1()
        {
            foreach (var point in LobbySpawnItemPoints.Points)
            {
                point.ItemName = null;
                point.ItemIcon = null;
                point.Background = "#FF474747";
            }
            foreach (var button  in AllWindowButtons)
            {
                button.Content = null;
                button.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF474747"));
            }
            Top3.Content = FindResource("SpecialtyAmmo");
            LobbySpawnItemPoints.Points[2].ItemName = "SpecialtyAmmo";
            Top4.Content = FindResource("Shells");
            LobbySpawnItemPoints.Points[3].ItemName = "Shells";
            Top5.Content = FindResource("LittleBullets");
            LobbySpawnItemPoints.Points[4].ItemName = "LittleBullets";
            Top6.Content = FindResource("SniperBullets");
            LobbySpawnItemPoints.Points[5].ItemName = "SniperBullets";
            Top7.Content = FindResource("BigBullets");
            LobbySpawnItemPoints.Points[6].ItemName = "BigBullets";

            Right1.Content = FindResource("JAG7");
            Right1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFf7cd0f"));
            LobbySpawnItemPoints.Points[26].ItemName = "JAG7_Legendary";
            Right2.Content = FindResource("ThomasGun");
            Right2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFf7cd0f"));
            LobbySpawnItemPoints.Points[27].ItemName = "ThomasGun_Legendary";
            Right3.Content = FindResource("DualPistols");
            Right3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF8733c6"));
            LobbySpawnItemPoints.Points[28].ItemName = "DualPistols_Epic";
            Right8.Content = FindResource("Sniper");
            Right8.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFf7cd0f"));
            LobbySpawnItemPoints.Points[33].ItemName = "Sniper_Legendary";
            Right9.Content = FindResource("M16");
            Right9.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFf7cd0f"));
            LobbySpawnItemPoints.Points[34].ItemName = "M16_Legendary";

            Left1.Content = FindResource("Deagle");
            Left1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFf7cd0f"));
            LobbySpawnItemPoints.Points[14].ItemName = "Deagle_Legendary";
            Left2.Content = FindResource("SilencedPistol");
            Left2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFf7cd0f"));
            LobbySpawnItemPoints.Points[15].ItemName = "SilencedPistol_Legendary";
            Left3.Content = FindResource("Minigun");
            Left3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFf7cd0f"));
            LobbySpawnItemPoints.Points[16].ItemName = "Minigun_Legendary";
            //Left4.Content = FindResource("HuntingRifle");
            //Left4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00b5f2"));
            //LobbySpawnItemPoints.Points[17].ItemName = "HuntingRifle_Rare";

            Left7.Content = FindResource("Bow");
            Left7.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00b5f2"));
            LobbySpawnItemPoints.Points[20].ItemName = "Bow_Rare";
            Left8.Content = FindResource("SparrowLauncher");
            Left8.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFf7cd0f"));
            LobbySpawnItemPoints.Points[21].ItemName = "SparrowLauncher_Legendary";
            Left9.Content = FindResource("DartFly");
            Left9.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFf7cd0f"));
            LobbySpawnItemPoints.Points[22].ItemName = "DartFly_Legendary";
            Left10.Content = FindResource("BCG");
            Left10.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF8733c6"));
            LobbySpawnItemPoints.Points[23].ItemName = "BCG_Epic";

            Down1.Content = FindResource("tape");
            Down1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00b5f2"));
            LobbySpawnItemPoints.Points[7].ItemName = "tape 5";
            Down2.Content = FindResource("NinjaBooties");
            Down2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00b5f2"));
            LobbySpawnItemPoints.Points[8].ItemName = "NinjaBooties";
            Down3.Content = FindResource("juice");
            Down3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00b5f2"));
            LobbySpawnItemPoints.Points[9].ItemName = "juice 200";
            Down4.Content = FindResource("armor3");
            Down4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00b5f2"));
            LobbySpawnItemPoints.Points[10].ItemName = "armor3";
            //Down7.Content = FindResource("banana");
            //LobbySpawnItemPoints.Points[13].ItemName = "banana 10";
            //Down5.Content = FindResource("BananaForker");
            //Down5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00b5f2"));
            //LobbySpawnItemPoints.Points[11].ItemName = "BananaForker";
            //Down6.Content = FindResource("Cupgrade");
            //Down6.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00b5f2"));
            //LobbySpawnItemPoints.Points[12].ItemName = "Cupgrade";
                
        }
        public void Profile2()
        {
            foreach (var point in LobbySpawnItemPoints.Points)
            {
                point.ItemName = null;
                point.ItemIcon = null;
                point.Background = "#FF474747";
            }
            foreach (var button in AllWindowButtons)
            {
                button.Content = null;
                button.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF474747"));
            }
            Top3.Content = FindResource("SpecialtyAmmo");
            LobbySpawnItemPoints.Points[2].ItemName = "SpecialtyAmmo";
            Top4.Content = FindResource("Shells");
            LobbySpawnItemPoints.Points[3].ItemName = "Shells";
            Top5.Content = FindResource("LittleBullets");
            LobbySpawnItemPoints.Points[4].ItemName = "LittleBullets";
            Top6.Content = FindResource("SniperBullets");
            LobbySpawnItemPoints.Points[5].ItemName = "SniperBullets";
            Top7.Content = FindResource("BigBullets");
            LobbySpawnItemPoints.Points[6].ItemName = "BigBullets";
            Down1.Content = FindResource("tape");
            Down1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00b5f2"));
            LobbySpawnItemPoints.Points[7].ItemName = "tape 5";
            Down3.Content = FindResource("juice");
            Down3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00b5f2"));
            LobbySpawnItemPoints.Points[9].ItemName = "juice 200";
            //Down4.Content = FindResource("banana");
            //LobbySpawnItemPoints.Points[10].ItemName = "banana 10";
        }
    }
}
