using MiniRpgGame.Weapons;
using MiniRpgGame.Weapons.ArcherWeapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.WeaponsLists
{
    public class ArcherWeaponsRepository : WeaponsRepository
    {

        public bool MeetsRequirements(IWeapon weapon, int charLevel)
        {
            return base.MeetsRequirements(weapon, charLevel);
        }


        public override void PopulateList()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            var weaponTypes = assembly.GetTypes()
            .Where(type => typeof(ArcherWeaponsClass).IsAssignableFrom(type) && !type.IsAbstract);

            foreach (var weaponType in weaponTypes)
            {
                ArcherWeaponsClass weapon = (ArcherWeaponsClass)Activator.CreateInstance(weaponType);
                WeaponsList.Add(weapon);
            }

            WeaponsList.OrderBy(p => p.LevelRequirement).ToList();
        }
    }
}
