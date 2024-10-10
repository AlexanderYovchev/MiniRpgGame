using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MiniRpgGame.Monsters.Forest_Monsters
{
    public class ForestRat : ForestMonstersAbstract
    {
        private Random attack = new Random();

        private int healthCap = 30;
        private const int minDmg = 1;
        private const int maxDmg = 3;
        private const int xpDrop = 12;
        public ForestRat()
        {
            Name = "Forest Rat";
            HealthCap = healthCap;
            MinDmg = minDmg;
            MaxDmg = maxDmg;
            XpDrop = xpDrop;

        }

        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/ratImage.png"));

        
    }
}
