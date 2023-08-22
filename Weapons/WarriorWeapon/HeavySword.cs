using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.WarriorWeapon
{
    public class HeavySword : WarriorWeaponsClass
    {
        private Random attackDamage = new Random();
        private const int minDmg = 15;
        private const int maxDmg = 20; 
        public override string Name { get; set; } = "Heavy Sword";

        public override int MinDmg { get; set; } = minDmg;

        public override int MaxDmg { get; set; } = maxDmg;

        public override int AttackDamage => attackDamage.Next(MinDmg,MaxDmg);

        public override Random CritChance { get; set; } = new Random();

        public override int AttackInitialize()
        {
            if (CritChance.Next(1,100) >= 60)
            {
                return AttackDamage * 2;
            }
            return AttackDamage;
        }

        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Heavier than the light sword but deals greater damage. 40% chance for a crit");
            return sb.ToString();
        }
    }
}
