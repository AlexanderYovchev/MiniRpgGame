using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Monsters.Swamp_Monsters
{
    public class MudGhoul : SwampsMonsterAbstract
    {
        private Random attack = new Random();

        private const int minDmg = 12;
        private const int maxDmg = 16;
        private const int xpDrop = 400;
        public MudGhoul()
        {
            Name = "Mud Ghoul";

        }
        public override int HealthCap { get; set; } = 180;

        public override int MinDmg { get => minDmg; }

        public override int MaxDmg { get => maxDmg; }

        public override int AttackDmg => attack.Next(minDmg, maxDmg);

        public override int XpDrop { get => xpDrop; }

        public override int CritChance { get => base.CritChance; set => base.CritChance = value; }
    }
}
