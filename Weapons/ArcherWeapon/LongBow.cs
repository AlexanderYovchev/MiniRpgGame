using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.ArcherWeapon
{
    public class LongBow : ArcherWeaponsClass
    {
        private Random attackDamage = new Random();
        private const int minDmg = 15;
        private const int maxDmg = 25;

        public LongBow()
        {

        }

        public override string Name { get; set; } = "Long Bow";

        public override int MinDmg { get; set; } = minDmg;

        public override int MaxDmg { get; set; } = maxDmg;

        public override Random CritChance { get; set; } = new Random();

        public override int LevelRequirement { get; set; } = 12;


        public override int AttackDamage => attackDamage.Next(MinDmg, MaxDmg);

        public override int AttackInitialize()
        {
            if (CritChance.Next(1, 100) >= 25)
            {
                return AttackDamage * 2;
            }

            return AttackDamage;
        }

        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Long bow used by the saxons from long time, it requires a strong grip and a steady hand to land a perfect shot. 75% chance for crit.");
            return sb.ToString();
        }
    }
}
