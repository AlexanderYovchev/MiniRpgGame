using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.MageWeapon.MageStarterWeapons
{
    public class StupidWand : MageStartedWeaponClass
    {
        private const int critChanceSuccessValue = 1;
        private const int minDmg = 2;
        private const int maxDmg = 3;
        private const int levelRequirement = 0;

        public StupidWand()
        {
            Name = "Stupid Wand";
            MaxDmg = maxDmg;
            MinDmg = minDmg;
            LevelRequirement = levelRequirement;
            CritChanceSuccessValue = critChanceSuccessValue;
            AttackInitialize();
        }
        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("This is a wand made from a stupid person, little damage but 100% critical chance which makes no sense.. Thats why its called stupid wand");
            return sb.ToString();
        }
    }
}
