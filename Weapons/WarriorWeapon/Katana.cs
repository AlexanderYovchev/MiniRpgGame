using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.WarriorWeapon
{
    public class Katana : WarriorWeaponsClass
    {
        private const int critChanceSuccessValue = 40;
        private const int minDmg = 25;
        private const int maxDmg = 45;
        private const int levelRequirement = 20;

        public Katana()
        {
            Name = "Katana";
            MaxDmg = maxDmg;
            MinDmg = minDmg;
            LevelRequirement = levelRequirement;
            CritChanceSuccessValue = critChanceSuccessValue;
            AttackInitialize();
        }
        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("One of the most famous samurai swords, known to be forged in front of the warrior so his soul merges with the weapon. 60% chance for a crit");
            return sb.ToString();
        }
    }
}
