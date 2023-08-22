using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.CharacterClasses
{
    public class Archer : CharacterAbstractClass
    {
        public override int Health { get; set; } = 110;

        public override void LevelUp()
        {
            Level++;
            XpCap += 400;
            Xp = XpCap - Xp;
            Health += 25;
            this.Weapon.MinDmg += 3;
            this.Weapon.MaxDmg += 3;

        }
    }
}
