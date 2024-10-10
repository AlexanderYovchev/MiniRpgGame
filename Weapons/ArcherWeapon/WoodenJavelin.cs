using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.ArcherWeapon
{
    public class WoodenJavelin : ArcherWeaponsClass
    {
        private const int critChanceSuccessValue = 50;
        private Random attackDamage = new Random();
        private const int minDmg = 9;
        private const int maxDmg = 15;
        private const int levelRequirement = 8;

        public WoodenJavelin()
        {
            Name = "Wooden Javelin";
            MaxDmg = maxDmg;
            MinDmg = minDmg;
            LevelRequirement = levelRequirement;
            CritChanceSuccessValue = critChanceSuccessValue;
            AttackInitialize();
        }
        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Simple made wooden javelin, that requires good amount of skill to be thrown. 50% chance for crit.");
            return sb.ToString();
        }
    }
}
