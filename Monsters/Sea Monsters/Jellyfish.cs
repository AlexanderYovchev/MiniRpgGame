using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MiniRpgGame.Monsters.Sea_Monsters
{
    public class Jellyfish : SeaMonstersAbstract
    {
        private Random attack = new Random();

        private int healthCap = 150;
        private const int minDmg = 8;
        private const int maxDmg = 21;
        private const int xpDrop = 250;
        public Jellyfish()
        {
            Name = "Jellyfish";
            HealthCap = healthCap;
            MinDmg = minDmg;
            MaxDmg = maxDmg;
            XpDrop = xpDrop;
            AttackDmg = attack.Next(MinDmg, MaxDmg);

        }
        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/jellyfishImage.png"));
    }
}
