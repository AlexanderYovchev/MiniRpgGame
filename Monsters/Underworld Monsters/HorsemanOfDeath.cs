using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MiniRpgGame.Monsters.Underworld_Monsters
{
    public class HorsemanOfDeath : UnderworldMonstersAbstract
    {
        private Random attack = new Random();

        private int healthCap = 2500;
        private const int minDmg = 80;
        private const int maxDmg = 160;
        private const int xpDrop = 5000;
        public HorsemanOfDeath()
        {
            Name = "Horseman of death";
            HealthCap = healthCap;
            MinDmg = minDmg;
            MaxDmg = maxDmg;
            XpDrop = xpDrop;
            AttackDmg = attack.Next(MinDmg, MaxDmg);
        }
        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/horsemanImage.png"));
    }
}
