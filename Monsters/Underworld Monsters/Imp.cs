using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MiniRpgGame.Monsters.Underworld_Monsters
{
    public class Imp : UnderworldMonstersAbstract
    {
        private Random attack = new Random();

        private int healthCap = 360;
        private const int minDmg = 30;
        private const int maxDmg = 40;
        private const int xpDrop = 770;
        public Imp()
        {
            Name = "Imp";
            HealthCap = healthCap;
            MinDmg = minDmg;
            MaxDmg = maxDmg;
            XpDrop = xpDrop;
            AttackDmg = attack.Next(MinDmg, MaxDmg);
        }
        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/impImage.png"));
    }
}
