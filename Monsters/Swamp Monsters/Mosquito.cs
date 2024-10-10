using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MiniRpgGame.Monsters.Swamp_Monsters
{
    public class Mosquito : SwampsMonsterAbstract
    {
        private Random attack = new Random();

        private int healthCap = 20;
        private const int minDmg = 3;
        private const int maxDmg = 5;
        private const int xpDrop = 20;
        public Mosquito()
        {
            Name = "Mosquito";
            HealthCap = healthCap;
            MinDmg = minDmg;
            MaxDmg = maxDmg;
            XpDrop = xpDrop;
            AttackDmg = attack.Next(MinDmg, MaxDmg);
        }
        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/mosquitoImage.jpg"));
    }
}
