using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons
{
    public interface IWeapon
    {
        public string Name { get; set; }

        public int MinDmg { get; set; }

        public int MaxDmg { get; set; }

        public int LevelRequirement { get; set; }

        public int AttackDamage => Random.Shared.Next(MinDmg, MaxDmg);

        public Random CritChance { get; }

        public int CritChanceSuccessValue { get; set; }

        public int AttackInitialize();

        public string WeaponInfo();


    }
}
