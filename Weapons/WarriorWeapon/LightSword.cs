using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.WarriorWeapon
{
    public class LightSword : WarriorWeaponsClass
    {
        private const int critChanceSuccessValue = 75;
        private const int minDmg = 10;
        private const int maxDmg = 12;
        private const int levelRequirement = 5;

        public LightSword()
        {
            Name = "Light Sword";
            MaxDmg = maxDmg;
            MinDmg = minDmg;
            LevelRequirement = levelRequirement;
            CritChanceSuccessValue = critChanceSuccessValue;
            AttackInitialize();
        }
        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("A sword little bit stronger than the dagger, it has a sharp edge that can thrust through harder armor. 25% chance for a crit");
            return sb.ToString();
        }


    }
}
