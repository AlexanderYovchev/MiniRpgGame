using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Monsters.Swamp_Monsters
{
    public class Turtle : SwampsMonsterAbstract
    {
        private Random attack = new Random();

        private const int minDmg = 2;
        private const int maxDmg = 8;
        private const int xpDrop = 24;
        public Turtle()
        {
            Name = "Snapping Turtle";

        }
        public override int HealthCap { get; set; } = 200;

        public override int MinDmg { get => minDmg; }

        public override int MaxDmg { get => maxDmg; }

        public override int AttackDmg => attack.Next(minDmg, maxDmg);

        public override int XpDrop { get => xpDrop; }

        public override int CritChance { get => base.CritChance; set => base.CritChance = value; }
    }
}
