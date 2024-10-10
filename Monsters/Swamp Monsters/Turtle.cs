using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MiniRpgGame.Monsters.Swamp_Monsters
{
    public class Turtle : SwampsMonsterAbstract
    {
        private Random attack = new Random();

        private int healthCap = 200;
        private const int minDmg = 2;
        private const int maxDmg = 8;
        private const int xpDrop = 24;
        public Turtle()
        {
            Name = "Snapping Turtle";
            HealthCap = healthCap;
            MinDmg = minDmg;
            MaxDmg = maxDmg;
            XpDrop = xpDrop;
            AttackDmg = attack.Next(MinDmg, MaxDmg);
        }
        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/snappingTurtleImage.png"));
    }
}
