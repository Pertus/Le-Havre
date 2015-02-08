using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeHavre.Resources
{
    class Fish:Resource
    {
        public Fish()
        {
            Name = "Fish";
            FrancsValue = 1;
            FoodValue = 1;
            EnergyValue = 0;
            Advanced = false;
        }
    }
}
