using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Monsters.Forest_Monsters
{
    public class Deer : ForestMonstersAbstract
    {
        private Random attack = new Random();

        private const int minDmg = 4;
        private const int maxDmg = 8;
        private const int xpDrop = 50;
        public Deer()
        {
            Name = "Deer";

        }

        public override int MinDmg { get => minDmg; }

        public override int MaxDmg { get => maxDmg; }

        public override int AttackDmg => attack.Next(minDmg, maxDmg);

        public override int XpDrop { get => xpDrop; }

        public override int CritChance { get => base.CritChance; set => base.CritChance = value; }

        
    }
}
