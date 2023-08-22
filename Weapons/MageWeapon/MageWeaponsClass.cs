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

        public virtual int AttackDamage { get; set; }

        public virtual Random CritChance { get; set; }

        public virtual int AttackInitialize()
        {
            return AttackDamage;
        }

        public virtual string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            return sb.ToString();
        }
    }
}
