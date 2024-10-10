using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.WarriorWeapon
{
    public class Saber : WarriorWeaponsClass
    {
        private const int critChanceSuccessValue = 60;
        private const int minDmg = 20;
        private const int maxDmg = 37;
        private const int levelRequirement = 15;

        public Saber()
        {
            Name = "Saber";
            MaxDmg = maxDmg;
            MinDmg = minDmg;
            LevelRequirement = levelRequirement;
            CritChanceSuccessValue = critChanceSuccessValue;
            AttackInitialize();
        }
        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Sword, specifically used from the cavalries. 40% chance for a crit");
            return sb.ToString();
        }
    }
}
