﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeHavre.Resources
{
    class Brick:Resource
    {

        public Brick()
        {
            Name = "Brick";
            FrancsValue = 2;
            FoodValue = 0;
            EnergyValue = 0;
            Advanced = true;
        }
    }
}
