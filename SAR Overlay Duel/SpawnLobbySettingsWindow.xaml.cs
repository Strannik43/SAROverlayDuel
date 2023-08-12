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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SAR_Overlay_Duel
{
    /// <summary>
    /// Логика взаимодействия для SpawnLobbySettingsWindow.xaml
    /// </summary>
    public partial class SpawnLobbySettingsWindow : Window
    {
        public  SARItemsPanelWindow sARItemsPanelWindow;
        public Lobby_0_Window lobby_0_window;
        public Lobby_1_Window lobby_1_window;

        public List<Window> lobbywindows = new List<Window>();
        public Window AktivLobbyWindow;

        public SpawnLobbySettingsWindow(Lobby_0_Window lobby_0_Window, Lobby_1_Window lobby_1_Window )
        {
            Left = 70;
            Top = 730;
            InitializeComponent();

            this.lobby_0_window = lobby_0_Window;
            this.lobby_1_window = lobby_1_Window;
            lobbywindows.Add(lobby_0_window);
            lobbywindows.Add(lobby_1_window);
            AktivLobbyWindow = lobbywindows[0];
        }
        private void NextLobby(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < lobbywindows.Count; i++)
            {
                if (lobbywindows[i] == AktivLobbyWindow && i != lobbywindows.Count - 1)
                {
                    AktivLobbyWindow.Hide();      
                    AktivLobbyWindow = lobbywindows[i += 1];
                    AktivLobbyWindow.Show();
                    return;
                }
                else if(lobbywindows[i] == AktivLobbyWindow && i == lobbywindows.Count - 1)
                {
                    AktivLobbyWindow.Hide();
                    AktivLobbyWindow = lobbywindows[0];
                    AktivLobbyWindow.Show();
                    return;
                }
            }
        }
        private void LastLobby(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < lobbywindows.Count; i++)
            {
                if (lobbywindows[i] == AktivLobbyWindow && i != 0)
                {
                    AktivLobbyWindow.Hide();
                    AktivLobbyWindow = lobbywindows[i -= 1];
                    AktivLobbyWindow.Show();
                    return;
                }
                else if (lobbywindows[i] == AktivLobbyWindow && i == 0)
                {
                    AktivLobbyWindow.Hide();
                    AktivLobbyWindow = lobbywindows[lobbywindows.Count - 1];
                    AktivLobbyWindow.Show();
                    return;
                }
            }
        }
        private void StartSpawnClick(object sender, RoutedEventArgs e)
        {
            if (AktivLobbyWindow == lobby_0_window && lobby_0_window.LobbySpawnItemPoints.FlagStopSpawn) { lobby_0_window.StartSpawn(); }
            else if (AktivLobbyWindow == lobby_1_window && lobby_1_window.LobbySpawnItemPoints.FlagStopSpawn) { lobby_1_window.StartSpawn(); }
        }
        private void ClearSpawnClick(object sender, RoutedEventArgs e)
        {
            if (AktivLobbyWindow == lobby_0_window) { lobby_0_window.Clear(); }
            else if (AktivLobbyWindow == lobby_1_window) { lobby_1_window.Clear(); }
        }
        private void Profile1Click(object sender, RoutedEventArgs e)
        {
            if (AktivLobbyWindow == lobby_0_window) { lobby_0_window.Profile1(); }
            else if (AktivLobbyWindow == lobby_1_window) { lobby_1_window.Profile1(); }
        }
        private void Profile2Click(object sender, RoutedEventArgs e)
        {
            if (AktivLobbyWindow == lobby_0_window) { lobby_0_window.Profile2(); }
            else if (AktivLobbyWindow == lobby_1_window) { lobby_1_window.Profile2(); }
        }
    }
}
