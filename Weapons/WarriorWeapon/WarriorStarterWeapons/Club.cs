using MiniRpgGame.Weapons.WarriorWeapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.WarriorWeapons
{
    public class Club : WarriorStartedWeapon
    {
        private const int critChanceSuccessValue = 70;
        private const int minDmg = 3;
        private const int maxDmg = 9;
        private const int levelRequirement = 0;

        public Club()
        {
            Name = "Club";
            MaxDmg = maxDmg;
            MinDmg = minDmg;
            LevelRequirement = levelRequirement;
            CritChanceSuccessValue = critChanceSuccessValue;
            AttackInitialize();
        }
        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Prehistoric club might deal low or high damage");
            return sb.ToString();
        }
    }
}
