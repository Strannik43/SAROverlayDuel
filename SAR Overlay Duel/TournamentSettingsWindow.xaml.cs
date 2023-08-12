using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Логика взаимодействия для TournamentSettingsWindow.xaml
    /// </summary>
    public partial class TournamentSettingsWindow : Window
    {
        static TournamentDuelInfoWindow TournamentDuelInfoWindow;
        public TournamentDuelScript TournamentDuelScript; 

        public TournamentSettingsWindow(TournamentDuelInfoWindow tournamentDuelInfoWindow)
        {
            InitializeComponent();
            Left = 70;
            Top = 730;
            TournamentDuelInfoWindow = tournamentDuelInfoWindow;
            TournamentDuelScript = new TournamentDuelScript(TournamentDuelInfoWindow);

        }
        private void NextRoundClick(object sender, RoutedEventArgs e) => TournamentDuelScript.StartNextRound();

        private void FinishedRoundClick(object sender, RoutedEventArgs e) => TournamentDuelScript.TournamentFinishedThisRound();

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            TournamentDuelScript.participate = true;
        }
        private void checkBox1_Unchecked(object sender, RoutedEventArgs e)
        {
            TournamentDuelScript.participate = false;
        }
        private void TeleAllToLocationsClick(object sender, RoutedEventArgs e) => TournamentDuelScript.PlayersTeleToLocations();

        private void TeleAllToLobbyClick(object sender, RoutedEventArgs e) => TournamentDuelScript.PlayersTeleToLobby();

    }
}
