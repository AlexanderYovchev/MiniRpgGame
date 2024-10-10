using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MiniRpgGame.Monsters.Underworld_Monsters
{
    public class Hades : UnderworldMonstersAbstract
    {
        private Random attack = new Random();

        private int healthCap = 50000;
        private const int minDmg = 300;
        private const int maxDmg = 1000;
        private const int xpDrop = 100000;
        public Hades()
        {
            Name = "Hades";
            HealthCap = healthCap;
            MinDmg = minDmg;
            MaxDmg = maxDmg;
            XpDrop = xpDrop;
            AttackDmg = attack.Next(MinDmg, MaxDmg);

        }
        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/hadesImage.png"));
    }
}
