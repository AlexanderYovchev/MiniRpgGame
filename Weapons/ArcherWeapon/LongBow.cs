using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.ArcherWeapon
{
    public class LongBow : ArcherWeaponsClass
    {
        private const int critChanceSuccessValue = 25;
        private const int minDmg = 15;
        private const int maxDmg = 25;
        private const int levelRequirement = 12;

        public LongBow()
        {
            Name = "Long Bow";
            MaxDmg = maxDmg;
            MinDmg = minDmg;
            LevelRequirement = levelRequirement;
            CritChanceSuccessValue = critChanceSuccessValue;
            AttackInitialize();
        }

        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Long bow used by the saxons from long time, it requires a strong grip and a steady hand to land a perfect shot. 75% chance for crit.");
            return sb.ToString();
        }
    }
}
