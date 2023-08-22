using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.MageWeapon.MageStarterWeapons
{
    public class StupidWand : MageStartedWeaponClass
    {
        private Random attackDamage = new Random();
        private const int minDmg = 2;
        private const int maxDmg = 3;

        public StupidWand()
        {

        }

        public override string Name { get; set; } = "Stupid Wand";

        public override int MinDmg { get; set; } = minDmg;

        public override int MaxDmg { get; set; } = maxDmg;

        public override Random CritChance { get; set; } = new Random();


        public override int AttackDamage => attackDamage.Next(MinDmg, MaxDmg);

        public override int AttackInitialize()
        {
            if (CritChance.Next(1, 100) >= 1)
            {
                return AttackDamage * 2;
            }

            return AttackDamage;
        }

        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("This is a wand made from a stupid person, little damage but 100% critical chance which makes no sense.. Thats why its called stupid wand");
            return sb.ToString();
        }
    }
}
