using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.ArcherWeapon
{
    public class RepeatingCrossbow : ArcherWeaponsClass
    {
        private const int critChanceSuccessValue = 60;
        private const int minDmg = 5;
        private const int maxDmg = 10;
        private const int levelRequirement = 15;

        public RepeatingCrossbow()
        {
            Name = "Repeating Crossbow";
            MaxDmg = maxDmg;
            MinDmg = minDmg;
            LevelRequirement = levelRequirement;
            CritChanceSuccessValue = critChanceSuccessValue;
            AttackInitialize();
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
