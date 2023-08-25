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

        private const int minDmg = 20;
        private const int maxDmg = 30;
        private const int xpDrop = 4000;
        public MountainDragon()
        {
            Name = "Mountain Dragon";


        }

        public override int HealthCap { get; set; } = 1500;

        public override int MinDmg { get => minDmg; }

        public override int MaxDmg { get => maxDmg; }

        public override int AttackDmg => attack.Next(minDmg, maxDmg);

        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/mountainDragon.png"));

        public override int XpDrop { get => xpDrop; }

        public override int CritChance { get => base.CritChance; set => base.CritChance = value; }
    }
}
