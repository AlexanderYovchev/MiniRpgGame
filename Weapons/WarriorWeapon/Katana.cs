using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.WarriorWeapon
{
    public class Katana : WarriorWeaponsClass
    {
        private Random attackDamage = new Random();
        private const int minDmg = 25;
        private const int maxDmg = 45;
        public override string Name { get; set; } = "Katana";

        public override int MinDmg { get; set; } = minDmg;
        public override int MaxDmg { get; set; } = maxDmg;

        public override int LevelRequirement { get; set; } = 20;

        public override int AttackDamage => attackDamage.Next(MinDmg, MaxDmg);

        public override Random CritChance { get; set; } = new Random();

        public override int AttackInitialize()
        {
            if (CritChance.Next(1, 100) >= 40)
            {
                return AttackDamage * 2;
            }
            return AttackDamage;
        }

        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("One of the most famous samurai swords, known to be forged in front of the warrior so his soul merges with the weapon. 60% chance for a crit");
            return sb.ToString();
        }
    }
}
