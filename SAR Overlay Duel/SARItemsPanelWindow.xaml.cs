
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
    /// Логика взаимодействия для SARItemsPanelWindow.xaml
    /// </summary>
    public partial class SARItemsPanelWindow : Window
    {
        private string PointItemName;
        private bool SpawnLobby;
        private Button Button;
        public bool FlagButtonAktiv = false;
        
        public SARItemsPanelWindow(bool SpawnLobby = true)
        {
            this.SpawnLobby = SpawnLobby;
            InitializeComponent();
            Left = 750;
            Top = 300;
            if (SpawnLobby)
            {
                BossButton.Visibility = Visibility.Collapsed;
                EmuButton.Visibility = Visibility.Collapsed;
                SoccerButton.Visibility = Visibility.Collapsed;
                HamsterBallButton.Visibility = Visibility.Collapsed;

            }
        }
        private void TagItems(object sender, RoutedEventArgs e)
        {
            FlagButtonAktiv = true;
            string ItemName = (string)((Button)e.OriginalSource).Tag;
            if (SpawnLobby)
            {
                PointItemName = ItemName;
                Button = e.Source as Button;
            }
            else{SARCommandsInput.Spawn(ItemName);}
        }
        
        public void AddItemToPointSpawn(Point point)
        {
            if(PointItemName != null && FlagButtonAktiv) 
            {
                point.ItemName = PointItemName;
                point.Background = Button.Background.ToString();
                PointItemName = null;
            }
            FlagButtonAktiv = false;
        }
        public bool FlagAktive()
        {
            return FlagButtonAktiv ? FlagButtonAktiv : false;
        }
        /* private int TagCommand(string ItemName)
         {
             else if (SARCommandsInput.SARGunsID.ContainsKey(ItemName)) { return SARCommandsInput.SARGunsID[ItemName]; }
             else if (SARCommandsInput.SARRareID.ContainsKey(ItemName)) { return SARCommandsInput.SARRareID[ItemName]; }
             else if (SARCommandsInput.SARUtilID.ContainsKey(ItemName)) { return SARCommandsInput.SARUtilID[ItemName]; }
             else return -1;
         }*/
    }   
}
