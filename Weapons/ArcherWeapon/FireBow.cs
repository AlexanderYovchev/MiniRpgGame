using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.ArcherWeapon
{
    public class FireBow : ArcherWeaponsClass
    {
        private const int critChanceSuccessValue = 10;
        private const int minDmg = 30;
        private const int maxDmg = 50;
        private const int levelRequirement = 20;

        public FireBow()
        {
            Name = "FireBow";
            MaxDmg = maxDmg;
            MinDmg = minDmg;
            LevelRequirement = levelRequirement;
            CritChanceSuccessValue = critChanceSuccessValue;
            AttackInitialize();
        }

        public override int AttackDamage => base.AttackDamage;

        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("This bow doesnt require ammo. As soon as its string is pulled, a fire arrow is materialized. Thats why its critical chance is higher. 90% chance for crit.");
            return sb.ToString();
        }
    }
}
