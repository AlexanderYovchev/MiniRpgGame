using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MiniRpgGame.Monsters.Mountain_Monsters
{
    public class MountainGoat : MountainMonstersAbstract
    {
        private Random attack = new Random();

        private int healthCap = 180;
        private const int minDmg = 6;
        private const int maxDmg = 10;
        private const int xpDrop = 120;
        public MountainGoat()
        {
            Name = "Mountain Goat";
            HealthCap = healthCap;
            MinDmg = minDmg;
            MaxDmg = maxDmg;
            XpDrop = xpDrop;
            AttackDmg = attack.Next(MinDmg, MaxDmg);


        }
        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/mountainGoatImage.png"));
    }
}
