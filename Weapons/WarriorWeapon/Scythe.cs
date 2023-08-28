using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.WarriorWeapon
{
    public class Scythe : WarriorWeaponsClass
    {
        private Random attackDamage = new Random();
        private const int minDmg = 10;
        private const int maxDmg = 12;
        public override string Name { get; set; } = "Scythe";

        public override int MinDmg { get; set; } = minDmg;
        public override int MaxDmg { get; set; } = maxDmg;

        public override int LevelRequirement { get; set; } = 3;

        public override int AttackDamage => attackDamage.Next(MinDmg, MaxDmg);

        public override Random CritChance { get; set; } = new Random();

        public override int AttackInitialize()
        {
            if (CritChance.Next(1, 100) >= 90)
            {
                return AttackDamage * 2;
            }
            return AttackDamage;
        }

        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("A villagers scythe for harvesting wheat. 10% chance for a crit");
            return sb.ToString();
        }
    }
}
