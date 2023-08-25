using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MiniRpgGame.Monsters.Mountain_Monsters
{
    public class MountainLion : MountainMonstersAbstract
    {
        private Random attack = new Random();

        private const int minDmg = 7;
        private const int maxDmg = 12;
        private const int xpDrop = 210;
        public MountainLion()
        {
            Name = "Mountain Lion";


        }

        public override int HealthCap { get; set; } = 210;

        public override int MinDmg { get => minDmg; }

        public override int MaxDmg { get => maxDmg; }

        public override int AttackDmg => attack.Next(minDmg, maxDmg);

        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/mountainLionImage.png"));

        public override int XpDrop { get => xpDrop; }

        public override int CritChance { get => base.CritChance; set => base.CritChance = value; }
    }
}
