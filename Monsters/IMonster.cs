using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MiniRpgGame.Monsters
{
    public interface IMonster
    {
        public string Name { get; set; }

        public int HealthCap { get; set; }
        public int Health { get; set; }

        public int MinDmg { get; set; }

        public int MaxDmg { get; set; }

        public int AttackDmg { get; set; }

        public ImageSource MonsterImage { get; set; }

        public Random RandomCritGenerator { get; set; }

        public int CritChance { get; set; }

        public int XpDrop { get; }

        public int MonsterAttack();
        


    }
}
