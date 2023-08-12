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
    /// Логика взаимодействия для CommandsWindow.xaml
    /// </summary>
    public partial class CommandsWindow : Window
    {
        public CommandsWindow()
        {
            InitializeComponent();
            Left = 70;
            Top = 300;
        }
        private void CommandsInputClick(object sender, RoutedEventArgs e) => SARCommandsInput.SARSendCommand((string)((Button)e.OriginalSource).Tag);


    }
}
