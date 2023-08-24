using MiniRpgGame.CharacterClasses.CharacterClassInterface;
using MiniRpgGame.Monsters;
using MiniRpgGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.CharacterClasses
{
    public abstract class CharacterAbstractClass : ICharacterClasses
    {
        public CharacterAbstractClass()
        {

        }
        public virtual string Name { get; set; }

        public virtual int HealthCap { get; set; }
        public virtual int Health { get ; set; }
        public virtual int Mana { get; set; }
        public virtual IWeapon Weapon { get; set; }
        public virtual int Level { get; set; }
        public IMonster MonsterKilled { get; set; }

        public virtual int Xp { get; set; }

        public virtual int XpCap { get; set; }

        public virtual void MonsterKillAction()
        {
            Xp += MonsterKilled.XpDrop;
        }

        public virtual void LevelUp()
        {
            if (Xp >= XpCap)
            {
                Level++;
                XpCap += 400;
                Xp = XpCap - Xp;
                
            }
        }
    }
}
