using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Monsters
{
    public class SwampsMonsterAbstract : MonsterAbstractClass
    {
        private Random attack = new Random();


        public SwampsMonsterAbstract()
        {

        }

        public string Name { get; set; }
        public override int Health { get; set; }

        public override int MinDmg { get; set; }

        public override int MaxDmg { get; set; }
        public override int AttackDmg => attack.Next(MinDmg, MaxDmg);

        public override Random RandomCritGenerator { get; set; } = new Random();
        public override int CritChance { get; set; }
        public override int XpDrop { get; }

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
