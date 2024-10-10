using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MiniRpgGame.Monsters.Sea_Monsters
{
    public class Shark : SeaMonstersAbstract
    {
        private Random attack = new Random();

        private int healthCap = 600;
        private const int minDmg = 20;
        private const int maxDmg = 38;
        private const int xpDrop = 760;
        public Shark()
        {
            Name = "Shark";
            HealthCap = healthCap;
            MinDmg = minDmg;
            MaxDmg = maxDmg;
            XpDrop = xpDrop;
            AttackDmg = attack.Next(MinDmg, MaxDmg);

        }
        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/sharkImage.png"));
    }
}
