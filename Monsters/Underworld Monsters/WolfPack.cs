using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MiniRpgGame.Monsters.Underworld_Monsters
{
    public class WolfPack : UnderworldMonstersAbstract
    {
        private Random attack = new Random();

        private int healthCap = 950;
        private const int minDmg = 40;
        private const int maxDmg = 80;
        private const int xpDrop = 1800;
        public WolfPack()
        {
            Name = "Wolf Pack";
            HealthCap = healthCap;
            MinDmg = minDmg;
            MaxDmg = maxDmg;
            XpDrop = xpDrop;
            AttackDmg = attack.Next(MinDmg, MaxDmg);
        }
        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/wolfPackImage.png"));
    }
}
