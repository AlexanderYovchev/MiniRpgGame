using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.CharacterClasses
{
    public class Mage : CharacterAbstractClass
    {
        public override int Health { get; set; } = 130;

        public override void LevelUp()
        {
            Level++;
            XpCap += 400;
            Xp = XpCap - Xp;
            Health += 30;
            this.Weapon.MinDmg += 1;
            this.Weapon.MaxDmg += 4;
        }
    }
}
