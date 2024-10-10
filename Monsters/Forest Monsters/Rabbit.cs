using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MiniRpgGame.Monsters.Forest_Monsters
{
    public class Rabbit : ForestMonstersAbstract
    {
        private Random attack = new Random();

        private int healthCap = 50;
        private const int minDmg = 2;
        private const int maxDmg = 3;
        private const int xpDrop = 24;
        public Rabbit()
        {
            Name = "Rabbit";
            HealthCap = healthCap;
            MinDmg = minDmg;
            MaxDmg = maxDmg;
            XpDrop = xpDrop;

        }

        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/rabbitImage.png"));

        
    }
}
