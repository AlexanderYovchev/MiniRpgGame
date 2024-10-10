using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MiniRpgGame.Monsters.Swamp_Monsters
{
    public class MudGhoul : SwampsMonsterAbstract
    {
        private Random attack = new Random();

        private int healthCap = 180;
        private const int minDmg = 12;
        private const int maxDmg = 16;
        private const int xpDrop = 400;
        public MudGhoul()
        {
            Name = "Mud Ghoul";
            HealthCap = healthCap;
            MinDmg = minDmg;
            MaxDmg = maxDmg;
            XpDrop = xpDrop;
            AttackDmg = attack.Next(MinDmg, MaxDmg);
        }
        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/mudGhoulImage.png"));
    }
}
