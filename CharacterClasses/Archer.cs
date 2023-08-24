using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.CharacterClasses
{
    public class Archer : CharacterAbstractClass
    {
        public override int HealthCap { get; set; } = 110;
        public override int Health { get; set; } = 110;

        public override void LevelUp()
        {
            Level++;
            XpCap += 400;
            Xp = XpCap - Xp;
            HealthCap += 25;
            Health = HealthCap;
            this.Weapon.MinDmg += 3;
            this.Weapon.MaxDmg += 3;

        }
    }
}
