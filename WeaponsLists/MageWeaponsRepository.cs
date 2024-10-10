using MiniRpgGame.Weapons;
using MiniRpgGame.Weapons.MageWeapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.WeaponsLists
{
    public class MageWeaponsRepository : WeaponsRepository
    {
        public override void PopulateList()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            var weaponTypes = assembly.GetTypes()
            .Where(type => typeof(MageWeaponsClass).IsAssignableFrom(type) && !type.IsAbstract);

            foreach (var weaponType in weaponTypes)
            {
                MageWeaponsClass weapon = (MageWeaponsClass)Activator.CreateInstance(weaponType);
                WeaponsList.Add(weapon);
            }

            WeaponsList.OrderBy(p => p.LevelRequirement).ToList();
        }
    }
}
