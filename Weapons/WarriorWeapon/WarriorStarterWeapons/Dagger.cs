using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.WarriorWeapon
{
    public class Dagger : WarriorStartedWeapon
    {
        private const int critChanceSuccessValue = 75;
        private const int minDmg = 5;
        private const int maxDmg = 7;
        private const int levelRequirement = 0;

        public Dagger()
        {
            Name = "Dagger";
            MaxDmg = maxDmg;
            MinDmg = minDmg;
            LevelRequirement = levelRequirement;
            CritChanceSuccessValue = critChanceSuccessValue;
            AttackInitialize();
        }
        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("A small basic dagger, perfect for small monsters. 25% chance for a crit");
            return sb.ToString();
        }
    }
}
