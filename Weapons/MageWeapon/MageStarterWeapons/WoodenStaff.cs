using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.MageWeapon.MageStarterWeapons
{
    public class WoodenStaff : MageStartedWeaponClass
    {
        private Random attackDamage;
        private const int minDmg = 1;
        private const int maxDmg = 12;

        public WoodenStaff()
        {

        }

        public override string Name { get; set; } = "Wooden Staff";

        public override int MinDmg { get; set; } = minDmg;

        public override int MaxDmg { get => maxDmg;}

        public override Random CritChance { get; set; }


        public override int AttackDamage => attackDamage.Next(MinDmg, MaxDmg);

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
            sb.Append("This is a knife with 2 edges. It can do massive damage or no damage at all. Medium critical chance.");
            return sb.ToString();
        }
    }
}
