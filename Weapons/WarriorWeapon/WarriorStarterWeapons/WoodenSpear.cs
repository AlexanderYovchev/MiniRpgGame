using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.WarriorWeapon.WarriorStarterWeapons
{
    public class WoodenSpear : WarriorStartedWeapon
    {
        private const int critChanceSuccessValue = 90;
        private const int minDmg = 6;
        private const int maxDmg = 8;
        private const int levelRequirement = 0;

        public WoodenSpear()
        {
            Name = "Wooden Spear";
            MaxDmg = maxDmg;
            MinDmg = minDmg;
            LevelRequirement = levelRequirement;
            CritChanceSuccessValue = critChanceSuccessValue;
            AttackInitialize();
        }
        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Simple made spear from wood. As it might deals a great damage it has low critical chance.");
            return sb.ToString();
        }
    }
}
