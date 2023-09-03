﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.ArcherWeapon
{
    public class WoodenJavelin : ArcherWeaponsClass
    {
        private Random attackDamage = new Random();
        private const int minDmg = 9;
        private const int maxDmg = 15;

        public WoodenJavelin()
        {

        }

        public override string Name { get; set; } = "Wooden Javelin";

        public override int MinDmg { get; set; } = minDmg;

        public override int MaxDmg { get; set; } = maxDmg;

        public override Random CritChance { get; set; } = new Random();

        public override int LevelRequirement { get; set; } = 8;


        public override int AttackDamage => attackDamage.Next(MinDmg, MaxDmg);

        public override int AttackInitialize()
        {
            if (CritChance.Next(1, 100) >= 50)
            {
                return AttackDamage * 2;
            }

            return AttackDamage;
        }

        public override string WeaponInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Simple made wooden javelin, that requires good amount of skill to be thrown. 50% chance for crit.");
            return sb.ToString();
        }
    }
}
