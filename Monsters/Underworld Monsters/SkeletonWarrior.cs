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

        private int healthCap = 180;
        private const int minDmg = 15;
        private const int maxDmg = 38;
        private const int xpDrop = 570;
        public SkeletonWarrior()
        {
            Name = "Skeleton Warrior";
            HealthCap = healthCap;
            MinDmg = minDmg;
            MaxDmg = maxDmg;
            XpDrop = xpDrop;
            AttackDmg = attack.Next(MinDmg, MaxDmg);
        }
        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/skeletonWarriorImage.png"));
    }
}
