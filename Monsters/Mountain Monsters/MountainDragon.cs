using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MiniRpgGame.Monsters.Mountain_Monsters
{
    public class MountainDragon : MountainMonstersAbstract
    {
        private Random attack = new Random();

        private int healthCap = 1500;
        private const int minDmg = 20;
        private const int maxDmg = 30;
        private const int xpDrop = 4000;
        public MountainDragon()
        {
            Name = "Mountain Dragon";
            HealthCap = healthCap;
            MinDmg = minDmg;
            MaxDmg = maxDmg;
            XpDrop = xpDrop;
            AttackDmg = attack.Next(MinDmg, MaxDmg);
        }

        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/mountainDragon.png"));

        
    }
}
