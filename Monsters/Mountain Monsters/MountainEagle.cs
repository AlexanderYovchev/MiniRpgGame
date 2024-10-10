using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MiniRpgGame.Monsters.Mountain_Monsters
{
    public class MountainEagle : MountainMonstersAbstract
    {
        private Random attack = new Random();

        private int healthCap = 300;
        private const int minDmg = 7;
        private const int maxDmg = 15;
        private const int xpDrop = 700;
        public MountainEagle()
        {
            Name = "Mountain Eagle";
            HealthCap = healthCap;
            MinDmg = minDmg;
            MaxDmg = maxDmg;
            XpDrop = xpDrop;
            AttackDmg = attack.Next(MinDmg, MaxDmg);


        }
        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/mountainEagleImage.png"));
    }
}
