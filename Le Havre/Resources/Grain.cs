using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeHavre.Resources
{
    class Grain:Resource
    {
        public Grain()
        {
            Name = "Grain";
            FrancsValue = 1;
            FoodValue = 0;
            EnergyValue = 0;
            Advanced = false;
        }
    }
}
