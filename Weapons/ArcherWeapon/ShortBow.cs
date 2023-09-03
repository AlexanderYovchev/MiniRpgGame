using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.ArcherWeapon
{
    public class ShortBow : ArcherWeaponsClass
    {
        private Random attackDamage = new Random();
        private const int minDmg = 7;
        private const int maxDmg = 13;

        public ShortBow()
        {

        }

        public override string Name { get; set; } = "Short Bow";

        public override int MinDmg { get; set; } = minDmg;

        public override int MaxDmg { get; set; } = maxDmg;

        public override Random CritChance { get; set; } = new Random();

        public override int LevelRequirement { get; set; } = 4;


        public override int AttackDamage => attackDamage.Next(MinDmg, MaxDmg);

        public override int AttackInitialize()
        {
            if (CritChance.Next(1, 100) >= 70)
            {
                return AttackDamage * 2;
            }

            return AttackDamage;
        }

        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Just a short bow. 30% chance for crit.");
            return sb.ToString();
        }
    }
}
