using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.WarriorWeapon
{
    public class Scythe : WarriorWeaponsClass
    {
        private const int critChanceSuccessValue = 90;
        private const int minDmg = 10;
        private const int maxDmg = 12;
        private const int levelRequirement = 3;

        public Scythe()
        {
            Name = "Scythe";
            MaxDmg = maxDmg;
            MinDmg = minDmg;
            LevelRequirement = levelRequirement;
            CritChanceSuccessValue = critChanceSuccessValue;
            AttackInitialize();
        }
        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("A villagers scythe for harvesting wheat. 10% chance for a crit");
            return sb.ToString();
        }
    }
}
