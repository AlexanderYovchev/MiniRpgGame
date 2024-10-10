using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.MageWeapon
{
    public abstract class MageWeaponsClass : IWeapon
    {
        public virtual string Name { get; set; }

        public virtual int MinDmg { get; set; }

        public virtual int MaxDmg { get; set; }

        public virtual int LevelRequirement { get; set; }

        public virtual int AttackDamage => Random.Shared.Next(MinDmg, MaxDmg);

        public virtual Random CritChance { get; set; } = new Random();

        public int CritChanceSuccessValue { get; set; }

        public virtual int AttackInitialize()
        {
            if (CritChance.Next(1, 100) >= CritChanceSuccessValue)
            {
                return AttackDamage * 2;
            }

            return AttackDamage;
        }

        public virtual string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            return sb.ToString();
        }
    }
}
