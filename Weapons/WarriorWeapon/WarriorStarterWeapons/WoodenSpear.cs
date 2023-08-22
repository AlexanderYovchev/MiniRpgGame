using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.WarriorWeapon.WarriorStarterWeapons
{
    public class WoodenSpear : WarriorStartedWeapon
    {
        private Random attackDamage = new Random();
        private const int minDmg = 6;
        private const int maxDmg = 8;

        public WoodenSpear()
        {

        }

        public override string Name { get; set; } = "Wooden Spear";

        public override int MinDmg { get; set; } = minDmg;

        public override int MaxDmg { get; set; } = maxDmg;

        public override Random CritChance { get; set; } = new Random();


        public override int AttackDamage => attackDamage.Next(MinDmg, MaxDmg);

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
            sb.Append("Simple made spear from wood. As it might deals a great damage it has low critical chance.");
            return sb.ToString();
        }
    }
}
