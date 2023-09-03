using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.ArcherWeapon
{
    public class RepeatingCrossbow : ArcherWeaponsClass
    {
        private Random attackDamage = new Random();
        private const int minDmg = 5;
        private const int maxDmg = 10;

        public RepeatingCrossbow()
        {

        }

        public override string Name { get; set; } = "Repeating Crossbow";

        public override int MinDmg { get; set; } = minDmg;

        public override int MaxDmg { get; set; } = maxDmg;

        public override Random CritChance { get; set; } = new Random();

        public override int LevelRequirement { get; set; } = 15;


        public override int AttackDamage => attackDamage.Next(MinDmg, MaxDmg);

        public override int AttackInitialize()
        {
            if (CritChance.Next(1, 100) >= 60)
            {
                return AttackDamage * 8;
            }

            return AttackDamage;
        }

        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("This crossbow doesn't seem to do a lot of damage , but dont be fooled! It can shoot up to 8 bolts on a single load, " +
                "thats why its critical is multiplied by 8. It was used by the chinese elite army called 'Chu ko nu'. 40% chance for crit. (Critical damage is multiplied by 8)");
            return sb.ToString();
        }
    }
}
