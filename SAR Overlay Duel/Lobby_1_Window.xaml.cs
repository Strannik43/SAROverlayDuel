using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SAR_Overlay_Duel
{
    /// <summary>
    /// Логика взаимодействия для Lobby_1_Window.xaml
    /// </summary>
    public partial class Lobby_1_Window : Window
    {
        public SARItemsPanelWindow SARItemsPanelLobby1Window;
        List<Button> AllWindowButtons = new List<Button>();
        public SARSpawnPoints LobbySpawnItemPoints = new SARSpawnPoints(new List<Point>
            {
                new Point(3536, 2820),
                new Point(3536, 2797),
                new Point(3536, 2774),
                new Point(3536, 2751),
                new Point(3536, 2728),
                new Point(3536, 2705),

                new Point(3567, 2820),
                new Point(3567, 2797),
                new Point(3567, 2774),
                new Point(3567, 2751),
                new Point(3567, 2728),
                new Point(3567, 2705),

                new Point(3600, 2820),
                new Point(3600, 2797),
                new Point(3600, 2774),
                new Point(3600, 2751),
                new Point(3600, 2728),
                new Point(3600, 2705),

                new Point(3631, 2820),
                new Point(3631, 2797),
                new Point(3631, 2774),
                new Point(3631, 2751),
                new Point(3631, 2728),
                new Point(3631, 2705),

                new Point(3515, 2665),
                new Point(3540, 2665),
                new Point(3565, 2665),
                new Point(3590, 2665),
                new Point(3615, 2665),
                new Point(3640, 2665),
                new Point(3665, 2665),

                new Point(3515, 2640),
                new Point(3540, 2640),
                new Point(3565, 2640),
                new Point(3590, 2640),
                new Point(3615, 2640),
                new Point(3640, 2640),
                new Point(3665, 2640),
            });
        public Lobby_1_Window(SARItemsPanelWindow SARItemsPanelLobby1Window)
        {
            InitializeComponent();
            Left = 70;
            Top = 300;
            AllWindowButtons = new List<Button>()
            {
                Left1, Left2, Left3, Left4, Left5, Left6,
                Left7, Left8, Left9, Left10, Left11, Left12,
                Right1, Right2, Right3, Right4, Right5, Right6,
                Right7, Right8, Right9, Right10, Right11, Right12,
                Down1, Down2, Down3, Down4, Down5, Down6, Down7,
                Down8, Down9, Down10, Down11, Down12, Down13, Down14,
               
            };
            this.SARItemsPanelLobby1Window = SARItemsPanelLobby1Window;
        }
        private void SpawnPoints(object sender, RoutedEventArgs e)
        {
            if (SARItemsPanelLobby1Window.FlagButtonAktiv)
            {
                int PointIndex = Int32.Parse((string)((Button)e.OriginalSource).Tag);
                Point SpawnPoint = LobbySpawnItemPoints.Points[PointIndex];
                SARItemsPanelLobby1Window.AddItemToPointSpawn(SpawnPoint);
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
            LobbySpawnItemPoints.SpawnLobbyItems(15, 3590, 2665);
        }
        public void Clear()
        {
            foreach (var point in LobbySpawnItemPoints.Points)
            {
                point.ItemName = null;
                point.ItemIcon = null;
                point.Background = "#FF474747";
            }
            foreach (var klickbutton in AllWindowButtons)
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
            foreach (var button in AllWindowButtons)
            {
                button.Content = null;
                button.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF474747"));
            }
      
            Right6.Content = FindResource("JAG7");
            Right6.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFf7cd0f"));
            LobbySpawnItemPoints.Points[17].ItemName = "JAG7_Legendary";
            Right5.Content = FindResource("ThomasGun");
            Right5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFf7cd0f"));
            LobbySpawnItemPoints.Points[16].ItemName = "ThomasGun_Legendary";
            Right4.Content = FindResource("DualPistols");
            Right4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF8733c6"));
            LobbySpawnItemPoints.Points[15].ItemName = "DualPistols_Epic";
            Right12.Content = FindResource("M16");
            Right12.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFf7cd0f"));
            LobbySpawnItemPoints.Points[23].ItemName = "M16_Legendary";
            Right11.Content = FindResource("Sniper");
            Right11.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFf7cd0f"));
            LobbySpawnItemPoints.Points[22].ItemName = "Sniper_Legendary";         
            Right10.Content = FindResource("BCG");
            Right10.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF8733c6"));
            LobbySpawnItemPoints.Points[21].ItemName = "BCG_Epic";
            Left6.Content = FindResource("Deagle");
            Left6.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFf7cd0f"));
            LobbySpawnItemPoints.Points[5].ItemName = "Deagle_Legendary";
            Left5.Content = FindResource("SilencedPistol");
            Left5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFf7cd0f"));
            LobbySpawnItemPoints.Points[4].ItemName = "SilencedPistol_Legendary";
            Left4.Content = FindResource("Minigun");
            Left4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFf7cd0f"));
            LobbySpawnItemPoints.Points[3].ItemName = "Minigun_Legendary";
            //Left3.Content = FindResource("HuntingRifle");
            //Left3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00b5f2"));
            //Lobby_1_SpawnItemPoints.Points[2].ItemName = "HuntingRifle_Rare";

            Left12.Content = FindResource("Bow");
            Left12.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00b5f2"));
            LobbySpawnItemPoints.Points[11].ItemName = "Bow_Rare";
            Left11.Content   = FindResource("SparrowLauncher");
            Left11.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFf7cd0f"));
            LobbySpawnItemPoints.Points[10].ItemName = "SparrowLauncher_Legendary";
            Left10.Content =    FindResource("DartFly");
            Left10.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFf7cd0f"));
            LobbySpawnItemPoints.Points[9].ItemName = "DartFly_Legendary";

            Down3.Content = FindResource("tape");
            Down3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00b5f2"));
            LobbySpawnItemPoints.Points[26].ItemName = "tape 5";
            Down4.Content = FindResource("NinjaBooties");
            Down4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00b5f2"));
            LobbySpawnItemPoints.Points[27].ItemName = "NinjaBooties";
            Down5.Content = FindResource("juice");
            Down5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00b5f2"));
            LobbySpawnItemPoints.Points[28].ItemName = "juice 200";
            //Down6.Content = FindResource("banana");
            //LobbySpawnItemPoints.Points[29].ItemName = "banana 10";
            //Down7.Content = FindResource("BananaForker");
            //Down7.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00b5f2"));
            //LobbySpawnItemPoints.Points[30].ItemName = "BananaForker";
            Down2.Content = FindResource("armor3");
            Down2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00b5f2"));
            LobbySpawnItemPoints.Points[25].ItemName = "armor3";
            //Down1.Content = FindResource("Cupgrade");
            //Down1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00b5f2"));
            //LobbySpawnItemPoints.Points[24].ItemName = "Cupgrade";

            Down9.Content = FindResource("SpecialtyAmmo");
            LobbySpawnItemPoints.Points[32].ItemName = "SpecialtyAmmo";
            Down10.Content = FindResource("Shells");
            LobbySpawnItemPoints.Points[33].ItemName = "Shells";
            Down11.Content = FindResource("LittleBullets");
            LobbySpawnItemPoints.Points[34].ItemName = "LittleBullets";
            Down12.Content = FindResource("SniperBullets");
            LobbySpawnItemPoints.Points[35].ItemName = "SniperBullets";
            Down13.Content = FindResource("BigBullets");
            LobbySpawnItemPoints.Points[36].ItemName = "BigBullets";

            Down14.Content = FindResource("LittleBullets");
            LobbySpawnItemPoints.Points[37].ItemName = "LittleBullets";
            Down8.Content = FindResource("BigBullets");
            LobbySpawnItemPoints.Points[31].ItemName = "BigBullets";


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
            Down9.Content = FindResource("SpecialtyAmmo");
            LobbySpawnItemPoints.Points[32].ItemName = "SpecialtyAmmo";
            Down10.Content = FindResource("Shells");
            LobbySpawnItemPoints.Points[33].ItemName = "Shells";
            Down11.Content = FindResource("LittleBullets");
            LobbySpawnItemPoints.Points[34].ItemName = "LittleBullets";
            Down14.Content = FindResource("LittleBullets");
            LobbySpawnItemPoints.Points[36].ItemName = "LittleBullets";
            Down12.Content = FindResource("SniperBullets");
            LobbySpawnItemPoints.Points[35].ItemName = "SniperBullets";
            Down13.Content = FindResource("BigBullets");
            LobbySpawnItemPoints.Points[36].ItemName = "BigBullets";
            Down8.Content = FindResource("BigBullets");
            LobbySpawnItemPoints.Points[31].ItemName = "BigBullets";
            Down3.Content = FindResource("tape");
            Down3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00b5f2"));
            LobbySpawnItemPoints.Points[26].ItemName = "tape 5";
            Down5.Content = FindResource("juice");
            Down5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00b5f2"));
            LobbySpawnItemPoints.Points[28].ItemName = "juice 200";
            //Down6.Content = FindResource("banana");
            //LobbySpawnItemPoints.Points[29].ItemName = "banana 10";

        }
    }
}
