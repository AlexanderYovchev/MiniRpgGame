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
        public override int Health { get; set; } = 200;

        public override void LevelUp()
        {
            Level++;
            XpCap += 400;
            Xp = XpCap - Xp;
            Health += 50;
            this.Weapon.MinDmg += 2;
            this.Weapon.MaxDmg += 2;
        }
    }
}
