using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MiniRpgGame.Monsters.Sea_Monsters
{
    public class Kraken : SeaMonstersAbstract
    {
        private Random attack = new Random();

        private int healthCap = 20000;
        private const int minDmg = 80;
        private const int maxDmg = 240;
        private const int xpDrop = 20000;
        public Kraken()
        {
            Name = "Kraken";
            HealthCap = healthCap;
            MinDmg = minDmg;
            MaxDmg = maxDmg;
            XpDrop = xpDrop;
            AttackDmg = attack.Next(MinDmg, MaxDmg);


        }
        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/krakenImage.png"));
    }
}
