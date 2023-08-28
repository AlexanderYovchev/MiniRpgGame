using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.WarriorWeapon
{
    public class Saber : WarriorWeaponsClass
    {
        private Random attackDamage = new Random();
        private const int minDmg = 20;
        private const int maxDmg = 37;
        public override string Name { get; set; } = "Saber";

        public override int MinDmg { get; set; } = minDmg;
        public override int MaxDmg { get; set; } = maxDmg;

        public override int LevelRequirement { get; set; } = 15;

        public override int AttackDamage => attackDamage.Next(MinDmg, MaxDmg);

        public override Random CritChance { get; set; } = new Random();

        public override int AttackInitialize()
        {
            if (CritChance.Next(1, 100) >= 60)
            {
                return AttackDamage * 2;
            }
            return AttackDamage;
        }

        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Sword, specifically used from the cavalries. 40% chance for a crit");
            return sb.ToString();
        }
    }
}
