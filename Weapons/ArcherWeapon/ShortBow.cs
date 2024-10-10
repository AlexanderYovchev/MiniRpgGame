using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.ArcherWeapon
{
    public class ShortBow : ArcherWeaponsClass
    {
        private const int critChanceSuccessValue = 70;
        private const int minDmg = 7;
        private const int maxDmg = 13;
        private const int levelRequirement = 4;

        public ShortBow()
        {
            Name = "Short Bow";
            MaxDmg = maxDmg;
            MinDmg = minDmg;
            LevelRequirement = levelRequirement;
            CritChanceSuccessValue = critChanceSuccessValue;
            AttackInitialize();
        }
        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Just a short bow. 30% chance for crit.");
            return sb.ToString();
        }
    }
}
