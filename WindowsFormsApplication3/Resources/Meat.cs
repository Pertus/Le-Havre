using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeHavre.Resources
{
    class Meat:Resource
    {
        public Meat()
        {
            Name = "Meat";
            FrancsValue = 2;
            FoodValue = 3;
            EnergyValue = 0;
            Advanced = true;
        }
    }
}
