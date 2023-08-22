using MiniRpgGame.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Regions
{
    public class IRegion
    {
        public string Name { get; set; }

        public int LevelRequirement { get; set; }

        public ICollection<IMonster> MonstersList { get; set; }
    }
}
