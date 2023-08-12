using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Interop;

namespace SAR_Overlay_Duel
{
    internal static class SARCommandsInput
    {
        public static void Spawn(string ItemName)
        {
            if (ItemName.Contains('_'))
            {
                SARCommandsInput.SARGunSpawn(SARCommandsInput.SARGunsID[ItemName.Split('_')[0]], SARCommandsInput.SARRareID[ItemName.Split('_')[1]]);
            }
            else
            {
                if (SARCommandsInput.SARAmmoID.ContainsKey(ItemName)) { SARCommandsInput.SARAmmoSpawn(SARCommandsInput.SARAmmoID[ItemName]); }
                else if (SARCommandsInput.SARUtilID.ContainsKey(ItemName)) { SARCommandsInput.SARUtilSpawn(SARCommandsInput.SARUtilID[ItemName]); }
                else { SARCommandsInput.SARSendCommand(ItemName); }
            }
        }
        public static void SARGunSpawn(int WeaponID, int RarityID )
        {
            SARSendCommand($"gun{WeaponID} {RarityID}");
        }
        public static void SARUtilSpawn(int UtilID)
        {
            SARSendCommand($"util{UtilID}");
        }
        public static void SARAmmoSpawn(int AmmoID) 
        {
            SARSendCommand($"ammo{AmmoID} 30");
        }
        
        public static void SARSendCommand(string command )
        {
            if (SARFocusWindow.OpenSAR())
            {
                Thread.Sleep(Parameters.DelayChat);
                SendKeys.SendWait(Parameters.OpenChatKey);
                Thread.Sleep(Parameters.DelayChat);
                SendKeys.SendWait($"/{command}");
                Thread.Sleep(Parameters.DelayChat);
                SendKeys.SendWait("{ENTER}");
            }
            
        }
        public static Dictionary<string, int> SARGunsID = new Dictionary<string, int>()
        {
            ["Pistol"] = 0,
            ["DualPistols"] = 1,
            ["Magnum"] = 2,
            ["Deagle"] = 3,
            ["SilencedPistol"] = 4,
            ["Shotgun"] = 5,
            ["JAG7"] = 6,
            ["SMG"] = 7,    
            ["ThomasGun"] = 8,
            ["AK"] = 9,
            ["M16"] = 10,
            ["DognasDartGun"] = 11,
            ["DartFly"] = 12,
            ["HuntingRifle"] = 13,
            ["Sniper"] = 14,
            ["SuperiteLaser"] = 15,
            ["Minigun"] = 16,
            ["Bow"] = 17,
            ["SparrowLauncher"] = 18,
            ["BCG"] = 19,
        };
        public static Dictionary<string, int> SARUtilID = new Dictionary<string, int>()
        {
            ["ClawBoots"] = 0,
            ["BananaForker"] = 1,
            ["NinjaBooties"] = 2,
            ["SkunkGasSnorkel"] = 3,
            ["Cupgrade"] = 4,
            ["ImposibleTape"] = 5,
            ["SuperBandoiler"] = 6,
            ["SuperJuicer"] = 7,
        };
        public static Dictionary<string, int> SARAmmoID = new Dictionary<string, int>()
        {
            ["LittleBullets"] = 0,
            ["Shells"] = 1,
            ["BigBullets"] = 2,
            ["SniperBullets"] = 3,
            ["SpecialtyAmmo"] = 4,
            ["SuperiteCartridges"] = 5,
        };
        public static Dictionary<string, int> SARRareID = new Dictionary<string, int>()
        {
            ["Common"] = 0,
            ["Uncommon"] = 1,
            ["Rare"] = 2,
            ["Epic"] = 3,
            ["Legendary"] = 4,
        };

    }
}
