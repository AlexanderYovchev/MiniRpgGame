using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.ArcherWeapon.ArcherStarterWeapons
{
    public class SimpleBow : ArcherStarterWeaponClass
    {
        private Random attackDamage = new Random();
        private const int minDmg = 5;
        private const int maxDmg = 9;

        public SimpleBow()
        {

        }

        public override string Name { get; set; } = "Simple Bow";

        public override int MinDmg { get; set; } = minDmg;

        public override int MaxDmg { get; set; } = maxDmg;

        public override Random CritChance { get; set; } = new Random();


        public override int AttackDamage => attackDamage.Next(MinDmg, MaxDmg);

        public override int AttackInitialize()
        {
            if (CritChance.Next(1, 100) >= 95)
            {
                return AttackDamage * 2;
            }

            return AttackDamage;
        }

        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("A very inaccurate bow. Very low critical chance.");
            return sb.ToString();
        }
    }
}
