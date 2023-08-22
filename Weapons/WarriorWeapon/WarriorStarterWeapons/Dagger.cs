using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.WarriorWeapon
{
    public class Dagger : WarriorStartedWeapon
    {
        private Random attackDamage = new Random();
        private const int minDmg = 5;
        private const int maxDmg = 7;

        public Dagger()
        {

        }

        public override string Name { get; set; } = "Dagger";

        public override int MinDmg { get; set; } = minDmg;

        public override int MaxDmg { get; set; } = maxDmg;

        public override Random CritChance { get; set; } = new Random();


        public override int AttackDamage => attackDamage.Next(MinDmg,MaxDmg);

        public override int AttackInitialize()
        {
            if (CritChance.Next(1,100) >= 75)
            {
                return AttackDamage * 2;
            }

            return AttackDamage;
        }

        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("A small basic dagger, perfect for small monsters. 25% chance for a crit");
            return sb.ToString();
        }
    }
}
