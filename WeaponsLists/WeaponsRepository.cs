using MiniRpgGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.WeaponsLists
{
    public abstract class WeaponsRepository
    {
        public virtual List<Type> WeaponsList { get; } = new List<Type>();

        public virtual IWeapon FindWeapon(string weapon)
        {
            return (IWeapon)WeaponsList.First(w => w.Name == weapon);
        }

        public virtual bool MeetsRequirements(IWeapon weapon, int charLevel)
        {
            if (weapon.LevelRequirement > charLevel)
            {
                return false;
            }
            return true;
        }

        public abstract void PopulateList();
    }
}
