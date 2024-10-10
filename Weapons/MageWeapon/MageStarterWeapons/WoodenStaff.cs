using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.MageWeapon.MageStarterWeapons
{
    public class WoodenStaff : MageStartedWeaponClass
    {
        private const int critChanceSuccessValue = 50;
        private const int minDmg = 1;
        private const int maxDmg = 12;
        private const int levelRequirement = 0;

        public WoodenStaff()
        {
            Name = "Wooden Staff";
            MaxDmg = maxDmg;
            MinDmg = minDmg;
            LevelRequirement = levelRequirement;
            CritChanceSuccessValue = critChanceSuccessValue;
            AttackInitialize();
        }
        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("This is a knife with 2 edges. It can do massive damage or no damage at all. Medium critical chance.");
            return sb.ToString();
        }
    }
}
