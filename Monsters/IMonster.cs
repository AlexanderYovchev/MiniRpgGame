using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Monsters
{
    public interface IMonster
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public int AttackDmg { get; set; }

        public Random RandomCritGenerator { get; set; }

        public int CritChance { get; set; }

        public int XpDrop { get; }

        public int MonsterAttack();
        


    }
}
