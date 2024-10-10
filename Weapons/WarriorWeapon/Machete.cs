using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.WarriorWeapon
{
    public class Machete : WarriorWeaponsClass
    {
        private const int critChanceSuccessValue = 50;
        private const int minDmg = 15;
        private const int maxDmg = 30;
        private const int levelRequirement = 10;

        public Machete()
        {
            Name = "Machete";
            MaxDmg = maxDmg;
            MinDmg = minDmg;
            LevelRequirement = levelRequirement;
            CritChanceSuccessValue = critChanceSuccessValue;
            AttackInitialize();
        }
        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Very sharp, wide knife. Can cut through branches and other hard surfaces with ease. 50% chance for a crit");
            return sb.ToString();
        }
    }
}
