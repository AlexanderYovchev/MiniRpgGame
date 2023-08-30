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

        private const int minDmg = 40;
        private const int maxDmg = 80;
        private const int xpDrop = 1800;
        public WolfPack()
        {
            Name = "Wolf Pack";


        }

        public override int HealthCap { get; set; } = 950;

        public override int MinDmg { get => minDmg; }

        public override int MaxDmg { get => maxDmg; }

        public override int AttackDmg => attack.Next(minDmg, maxDmg);

        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/wolfPackImage.png"));

        public override int XpDrop { get => xpDrop; }

        public override int CritChance { get => base.CritChance; set => base.CritChance = value; }
    }
}
