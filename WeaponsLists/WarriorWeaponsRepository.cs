using MiniRpgGame.Weapons;
using MiniRpgGame.Weapons.WarriorWeapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.WeaponsLists
{
    public class WarriorWeaponsRepository : WeaponsRepository
    {
        public override void PopulateList()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            var weaponTypes = assembly.GetTypes()
            .Where(type => typeof(WarriorWeaponsClass).IsAssignableFrom(type) && !type.IsAbstract);

            foreach (var weaponType in weaponTypes)
            {
                WarriorWeaponsClass weapon = (WarriorWeaponsClass)Activator.CreateInstance(weaponType);
                WeaponsList.Add(weapon);
            }

            WeaponsList.OrderBy(p => p.LevelRequirement).ToList();
        }
    }
}
