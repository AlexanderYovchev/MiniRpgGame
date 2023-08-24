using MiniRpgGame.Monsters;
using MiniRpgGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.CharacterClasses.CharacterClassInterface
{
    public interface ICharacterClasses
    {
        public string Name { get; set; }

        public int HealthCap { get; set; }
        public int Health { get; set; }

        public int Mana { get; set; }

        public IWeapon Weapon { get; set; }

        public int Level { get; set; }

        public IMonster MonsterKilled { get; set; }

        public int Xp { get; set; }

        public int XpCap { get; set; }

        public void LevelUp();


    }
}
