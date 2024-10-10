using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.ArcherWeapon.ArcherStarterWeapons
{
    public class Sling : ArcherStarterWeaponClass
    {
        private const int critChanceSuccessValue = 40;
        private const int minDmg = 2;
        private const int maxDmg = 6;
        private const int levelRequirement = 0;

        public Sling()
        {
            Name = "Sling";
            MaxDmg = maxDmg;
            MinDmg = minDmg;
            LevelRequirement = levelRequirement;
            CritChanceSuccessValue = critChanceSuccessValue;
            AttackInitialize();
        }

        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("The opposite of the Simple bow. Low damage, higher critical chance.");
            return sb.ToString();
        }
    }
}
