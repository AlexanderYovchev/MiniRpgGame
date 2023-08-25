using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MiniRpgGame.Monsters.Mountain_Monsters
{
    public class RockGolem : MountainMonstersAbstract
    {
        private Random attack = new Random();

        private const int minDmg = 11;
        private const int maxDmg = 18;
        private const int xpDrop = 320;
        public RockGolem()
        {
            Name = "Rock Golem";


        }

        public override int HealthCap { get; set; } = 1100;

        public override int MinDmg { get => minDmg; }

        public override int MaxDmg { get => maxDmg; }

        public override int AttackDmg => attack.Next(minDmg, maxDmg);

        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/rockGolemImage.png"));

        public override int XpDrop { get => xpDrop; }

        public override int CritChance { get => base.CritChance; set => base.CritChance = value; }
    }
}
