using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.ArcherWeapon
{
    public class SmallCrossbow : ArcherWeaponsClass
    {
        private const int critChanceSuccessValue = 30;
        private Random attackDamage = new Random();
        private const int minDmg = 10;
        private const int maxDmg = 20;
        private const int levelRequirement = 10;

        public SmallCrossbow()
        {
            Name = "Small Crossbow";
            MaxDmg = maxDmg;
            MinDmg = minDmg;
            LevelRequirement = levelRequirement;
            CritChanceSuccessValue = critChanceSuccessValue;
            AttackInitialize();
        }
        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Compact crossbow perfect for killing small/medium monsters. 70% chance for crit.");
            return sb.ToString();
        }
    }
}
