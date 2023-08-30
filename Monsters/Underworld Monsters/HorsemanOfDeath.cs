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

        private const int minDmg = 80;
        private const int maxDmg = 160;
        private const int xpDrop = 5000;
        public HorsemanOfDeath()
        {
            Name = "Horseman of death";


        }

        public override int HealthCap { get; set; } = 2500;

        public override int MinDmg { get => minDmg; }

        public override int MaxDmg { get => maxDmg; }

        public override int AttackDmg => attack.Next(minDmg, maxDmg);

        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/horsemanImage.png"));

        public override int XpDrop { get => xpDrop; }

        public override int CritChance { get => base.CritChance; set => base.CritChance = value; }
    }
}
