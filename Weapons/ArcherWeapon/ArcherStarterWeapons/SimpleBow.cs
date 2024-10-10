using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.ArcherWeapon.ArcherStarterWeapons
{
    public class SimpleBow : ArcherStarterWeaponClass
    {
        private const int critChanceSuccessValue = 95;
        private const int minDmg = 5;
        private const int maxDmg = 9;
        private const int levelRequirement = 0;

        public SimpleBow()
        {
            Name = "Simple Bow";
            MaxDmg = maxDmg;
            MinDmg = minDmg;
            LevelRequirement = levelRequirement;
            CritChanceSuccessValue = critChanceSuccessValue;
            AttackInitialize();
        }


        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("A very inaccurate bow. Very low critical chance.");
            return sb.ToString();
        }
    }
}
