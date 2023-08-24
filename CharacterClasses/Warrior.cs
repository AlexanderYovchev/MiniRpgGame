using MiniRpgGame.Weapons;
using MiniRpgGame.Weapons.WarriorWeapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.CharacterClasses
{
    public class Warrior : CharacterAbstractClass
    {
        public override int HealthCap { get; set; } = 200;
        public override int Health { get; set; } = 200;

        public override void LevelUp()
        {
            Level++;
            XpCap += 400;
            Xp = XpCap - Xp;
            HealthCap += 50;
            Health = HealthCap;
            this.Weapon.MinDmg += 2;
            this.Weapon.MaxDmg += 2;
        }
    }
}
