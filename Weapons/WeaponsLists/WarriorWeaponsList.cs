using MiniRpgGame.Weapons.WarriorWeapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpgGame.Weapons.WeaponsLists
{
    public class WarriorWeaponsList
    {
        public List<WarriorWeaponsClass> WeaponsList { get; }

        public WarriorWeaponsList()
        {

        }

        public string GetWeapon(string name)
        {
            return WeaponsList.FirstOrDefault(w => w.Name == name).ToString();
        }
    }
}
