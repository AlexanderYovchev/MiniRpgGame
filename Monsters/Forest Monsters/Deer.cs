﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MiniRpgGame.Monsters.Forest_Monsters
{
    public class Deer : ForestMonstersAbstract
    {
        private Random attack = new Random();

        private int healthCap = 100;
        private const int minDmg = 4;
        private const int maxDmg = 8;
        private const int xpDrop = 50;
        public Deer()
        {
            Name = "Deer";
            HealthCap = healthCap;
            MinDmg = minDmg;
            MaxDmg = maxDmg;
            XpDrop = xpDrop;

        }
 


        public override ImageSource MonsterImage { get; set; } = new BitmapImage(new Uri(@"pack://application:,,,/MiniRpgGame;component/images/deerImage.png"));

        

        

        
    }
}
