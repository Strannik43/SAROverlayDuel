using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace SAR_Overlay_Duel
{
    public static class SARFocusWindow
    {
        public static IntPtr hWnd { get; private set; }
        public static bool isNavigationDrawerItemEnabled = false;
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindsowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr handle, UInt32 message, IntPtr w, IntPtr l);

        public static bool OpenSAR()
        {
            hWnd = FindWindow(null, "Super Animal Royale");
            if (!hWnd.Equals(IntPtr.Zero))
                return SetForegroundWindow(hWnd);
            return false;
        }
    }
}
