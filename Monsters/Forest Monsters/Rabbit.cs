using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MiniRpgGame.Monsters.Forest_Monsters
{
    public class Rabbit : ForestMonstersAbstract
    {
        private Random attack = new Random();

        private const int minDmg = 2;
        private const int maxDmg = 3;
        private const int xpDrop = 24;
        public Rabbit()
        {
            Name = "Rabbit";
            

        }
        public override int HealthCap { get; set; } = 50;

        public override int MinDmg { get => minDmg; }

        public override int MaxDmg { get => maxDmg; }

        public override int AttackDmg => attack.Next(minDmg, maxDmg);

        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/rabbitImage.png"));

        public override int XpDrop { get => xpDrop; }

        public override int CritChance { get => base.CritChance; set => base.CritChance = value; }
    }
}
