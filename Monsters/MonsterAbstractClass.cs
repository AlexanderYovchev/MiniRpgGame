using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MiniRpgGame.Monsters
{
    public abstract class MonsterAbstractClass : IMonster
    {
        private Random attack = new Random();



        public string Name { get; set; }

        public virtual int HealthCap { get; set; }
        public virtual int Health { get; set; }

        public virtual int MinDmg { get; set; }

        public virtual int MaxDmg { get; set; }

        public virtual int AttackDmg { get => attack.Next(MinDmg, MaxDmg) ; set => attack.Next(MinDmg,MaxDmg); }

        public virtual ImageSource MonsterImage { get; set; }

        public virtual Random RandomCritGenerator { get; set; } = new Random();
        public virtual int CritChance { get; set; }
        public virtual int XpDrop { get; }

        public virtual int MonsterAttack()
        {
            if (RandomCritGenerator.Next(1,100) <= CritChance)
            {
                return AttackDmg *= 2;
            }

            return AttackDmg;
        }
    }
}
