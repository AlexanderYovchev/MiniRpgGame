using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.ArcherWeapon
{
    public class SmallCrossbow : ArcherWeaponsClass
    {
        private Random attackDamage = new Random();
        private const int minDmg = 10;
        private const int maxDmg = 20;

        public SmallCrossbow()
        {

        }

        public override string Name { get; set; } = "Small Crossbow";

        public override int MinDmg { get; set; } = minDmg;

        public override int MaxDmg { get; set; } = maxDmg;

        public override Random CritChance { get; set; } = new Random();

        public override int LevelRequirement { get; set; } = 10;


        public override int AttackDamage => attackDamage.Next(MinDmg, MaxDmg);

        public override int AttackInitialize()
        {
            if (CritChance.Next(1, 100) >= 30)
            {
                return AttackDamage * 2;
            }

            return AttackDamage;
        }

        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Compact crossbow perfect for killing small/medium monsters. 70% chance for crit.");
            return sb.ToString();
        }
    }
}
