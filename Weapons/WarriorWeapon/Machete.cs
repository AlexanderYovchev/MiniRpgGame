using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.WarriorWeapon
{
    public class Machete : WarriorWeaponsClass
    {
        private Random attackDamage = new Random();
        private const int minDmg = 15;
        private const int maxDmg = 30;
        public override string Name { get; set; } = "Machete";

        public override int MinDmg { get; set; } = minDmg;
        public override int MaxDmg { get; set; } = maxDmg;

        public override int LevelRequirement { get; set; } = 10;

        public override int AttackDamage => attackDamage.Next(MinDmg, MaxDmg);

        public override Random CritChance { get; set; } = new Random();

        public override int AttackInitialize()
        {
            if (CritChance.Next(1, 100) >= 50)
            {
                return AttackDamage * 2;
            }
            return AttackDamage;
        }

        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Very sharp, wide knife. Can cut through branches and other hard surfaces with ease. 50% chance for a crit");
            return sb.ToString();
        }
    }
}
