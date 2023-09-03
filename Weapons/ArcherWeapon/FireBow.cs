using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.ArcherWeapon
{
    public class FireBow : ArcherWeaponsClass
    {
        private Random attackDamage = new Random();
        private const int minDmg = 30;
        private const int maxDmg = 50;

        public FireBow()
        {

        }

        public override string Name { get; set; } = "Fire Bow";

        public override int MinDmg { get; set; } = minDmg;

        public override int MaxDmg { get; set; } = maxDmg;

        public override Random CritChance { get; set; } = new Random();

        public override int LevelRequirement { get; set; } = 20;


        public override int AttackDamage => attackDamage.Next(MinDmg, MaxDmg);

        public override int AttackInitialize()
        {
            if (CritChance.Next(1, 100) >= 10)
            {
                return AttackDamage * 2;
            }

            return AttackDamage;
        }

        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("This bow doesnt require ammo. As soon as its string is pulled, a fire arrow is materialized. Thats why its critical chance is higher. 90% chance for crit.");
            return sb.ToString();
        }
    }
}
