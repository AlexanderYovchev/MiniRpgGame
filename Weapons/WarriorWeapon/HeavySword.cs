using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.WarriorWeapon
{
    public class HeavySword : WarriorWeaponsClass
    {
        private const int critChanceSuccessValue = 60;
        private const int minDmg = 15;
        private const int maxDmg = 20;
        private const int levelRequirement = 12;

        public HeavySword()
        {
            Name = "Heavy Sword";
            MaxDmg = maxDmg;
            MinDmg = minDmg;
            LevelRequirement = levelRequirement;
            CritChanceSuccessValue = critChanceSuccessValue;
            AttackInitialize();
        }
        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Heavier than the light sword but deals greater damage. 40% chance for a crit");
            return sb.ToString();
        }
    }
}
