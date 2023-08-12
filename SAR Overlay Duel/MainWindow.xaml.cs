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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SAR_Overlay_Duel
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private SARItemsPanelWindow SARItemspanel = new SARItemsPanelWindow(false);
        private static SARItemsPanelWindow SARItemspanelLobbySetting = new SARItemsPanelWindow();
        private static Lobby_0_Window lobby_0_Window = new Lobby_0_Window(SARItemspanelLobbySetting);
        private static Lobby_1_Window lobby_1_Window = new Lobby_1_Window(SARItemspanelLobbySetting);
        private static Window DefaultLobbyWindow = lobby_0_Window;
        private SpawnLobbySettingsWindow lobby_settings_window = new SpawnLobbySettingsWindow(lobby_0_Window, lobby_1_Window);
        private static TournamentDuelInfoWindow TournamentDuelInfoWindow = new TournamentDuelInfoWindow();
        private CommandsWindow CommandsWindow = new CommandsWindow();

        private static TournamentSettingsWindow TournamentSettingsWindow = new TournamentSettingsWindow(TournamentDuelInfoWindow);

        SettingsWindow SettingsWindow = new SettingsWindow();
        List<Window> windows = new List<Window>();
        List<Window> LobbyWindows = new List<Window>();


        public MainWindow()
        {
            InitializeComponent();
            Left = 0;
            Top = 300;
            SARItemspanel.Left = 70;
            windows.Add(lobby_settings_window);
            windows.Add(SettingsWindow);
            windows.Add(SARItemspanel);
            windows.Add(SARItemspanelLobbySetting);
            windows.Add(TournamentDuelInfoWindow);
            windows.Add(TournamentSettingsWindow);
            windows.Add(CommandsWindow);
            LobbyWindows.Add(lobby_1_Window);
            LobbyWindows.Add(lobby_0_Window);

        }
        public void OpenWindow(Window windowopen)
        {
            if (!windowopen.IsVisible)
            {
                foreach (var window in windows)
                {
                    if (window != windowopen)
                    {
                        window.Hide();
                    }
                }
                foreach (var window in LobbyWindows)
                {
                    if (window.IsVisible) { DefaultLobbyWindow = window; }
                }
                DefaultLobbyWindow.Hide();
                if (windowopen == lobby_settings_window) { DefaultLobbyWindow.Show(); SARItemspanelLobbySetting.Show(); }
                windowopen.Show();
                if(windowopen == TournamentSettingsWindow) { TournamentDuelInfoWindow.Show();}
            }
            else
            {
                windowopen.Hide();
                if (windowopen == lobby_settings_window)
                {
                    foreach (var window in LobbyWindows)
                    {
                        if (window.IsVisible) { DefaultLobbyWindow = window; }
                    }
                    DefaultLobbyWindow.Hide();
                    SARItemspanelLobbySetting.Hide();
                }
                if(windowopen == TournamentSettingsWindow) { TournamentDuelInfoWindow.Hide(); }
            }
        }
        private void LobbyWindowClick(object sender, RoutedEventArgs e) => OpenWindow(lobby_settings_window);
        private void SpawnItemsTableClick(object sender, RoutedEventArgs e) => OpenWindow(SARItemspanel);
        private void StartMatchClick(object sender, RoutedEventArgs e)
        {
            TournamentSettingsWindow.TournamentDuelScript.StartMatch();
            Parameters.SpawnStartMatch = true;
        }
        private void TournamentInfoClick(object sender, RoutedEventArgs e) => OpenWindow(TournamentSettingsWindow);
        private void CommandsWindowClick(object sender, RoutedEventArgs e) => OpenWindow(CommandsWindow);
    }
}
