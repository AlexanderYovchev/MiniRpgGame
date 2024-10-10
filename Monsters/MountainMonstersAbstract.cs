using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Monsters
{
    public class MountainMonstersAbstract : MonsterAbstractClass
    {
        public MountainMonstersAbstract()
        {

        }

        public override int MonsterAttack()
        {
            if (RandomCritGenerator.Next(1, 100) <= CritChance)
            {
                return AttackDmg *= 2;
            }

            return AttackDmg;
        }
    }
}
