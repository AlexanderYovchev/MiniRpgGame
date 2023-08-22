using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Monsters.Forest_Monsters
{
    public class Squirrel : ForestMonstersAbstract
    {
        private Random attack = new Random();

        private const int minDmg = 3;
        private const int maxDmg = 5;
        private const int xpDrop = 32;
        public Squirrel()
        {
            Name = "Squirrel";

        }

        public override int MinDmg { get => minDmg; }

        public override int MaxDmg { get => maxDmg; }

        public override int AttackDmg => attack.Next(minDmg, maxDmg);

        public override int XpDrop { get => xpDrop; }

        public override int CritChance { get => base.CritChance; set => base.CritChance = value; }
    }
}
