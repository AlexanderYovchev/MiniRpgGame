using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MiniRpgGame.Monsters.Sea_Monsters
{
    public class Whale : SeaMonstersAbstract
    {
        private Random attack = new Random();

        private int healthCap = 2000;
        private const int minDmg = 30;
        private const int maxDmg = 55;
        private const int xpDrop = 2000;
        public Whale()
        {
            Name = "Whale";
            HealthCap = healthCap;
            MinDmg = minDmg;
            MaxDmg = maxDmg;
            XpDrop = xpDrop;
            AttackDmg = attack.Next(MinDmg, MaxDmg);

        }
        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/whaleImage.png"));
    }
}
