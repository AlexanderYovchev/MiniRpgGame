using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MiniRpgGame.Monsters.Underworld_Monsters
{
    public class SkeletonWarrior : UnderworldMonstersAbstract
    {
        private Random attack = new Random();

        private const int minDmg = 15;
        private const int maxDmg = 38;
        private const int xpDrop = 570;
        public SkeletonWarrior()
        {
            Name = "Skeleton Warrior";


        }

        public override int HealthCap { get; set; } = 180;

        public override int MinDmg { get => minDmg; }

        public override int MaxDmg { get => maxDmg; }

        public override int AttackDmg => attack.Next(minDmg, maxDmg);

        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/skeletonWarriorImage.png"));

        public override int XpDrop { get => xpDrop; }

        public override int CritChance { get => base.CritChance; set => base.CritChance = value; }
    }
}
