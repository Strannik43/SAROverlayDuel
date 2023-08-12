using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;


namespace SAR_Overlay_Duel
{
    internal class ButtonsGeneration : System.Windows.Controls.Button
    {
        public void CreateButton (Window window, int x, int y, RoutedEventHandler evh, string Tag, int W, int H)
        {
            System.Windows.Controls.Button btn = new System.Windows.Controls.Button();
            btn.HorizontalAlignment = HorizontalAlignment;
            btn.VerticalAlignment = VerticalAlignment.Top;
            btn.Width = W;
            btn.Height = H;
            btn.Margin = new Thickness(x,y,0,0);
            
            //btn.Click += "Players";
            btn.Tag = Tag;
            btn.Click += evh;
            
        }
    }
}
