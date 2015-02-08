using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeHavre.Resources
{
    class Leather:Resource
    {
        public Leather()
        {
            Name = "Leather";
            FrancsValue = 4;
            FoodValue = 0;
            EnergyValue = 0;
            Advanced = true;
        }
    }
}
