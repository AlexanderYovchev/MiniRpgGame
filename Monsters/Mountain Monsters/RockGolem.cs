using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MiniRpgGame.Monsters.Mountain_Monsters
{
    public class RockGolem : MountainMonstersAbstract
    {
        private Random attack = new Random();

        private int healthCap = 1100;
        private const int minDmg = 11;
        private const int maxDmg = 18;
        private const int xpDrop = 320;
        public RockGolem()
        {
            Name = "Rock Golem";
            HealthCap = healthCap;
            MinDmg = minDmg;
            MaxDmg = maxDmg;
            XpDrop = xpDrop;
            AttackDmg = attack.Next(MinDmg, MaxDmg);

        }
        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/rockGolemImage.png"));
    }
}
