using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.ArcherWeapon.ArcherStarterWeapons
{
    public class Sling : ArcherStarterWeaponClass
    {
        private Random attackDamage = new Random();
        private const int minDmg = 2;
        private const int maxDmg = 6;

        public Sling()
        {

        }

        public override string Name { get; set; } = "Sling";

        public override int MinDmg { get; set; } = minDmg;

        public override int MaxDmg { get; set; } = maxDmg;

        public override Random CritChance { get; set; } = new Random();


        public override int AttackDamage => attackDamage.Next(MinDmg, MaxDmg);

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
            sb.Append("The opposite of the Simple bow. Low damage, higher critical chance.");
            return sb.ToString();
        }
    }
}
