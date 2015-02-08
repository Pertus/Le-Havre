using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeHavre.Resources
{
    class Steel:Resource
    {
        public Steel()
        {
            Name = "Steel";
            FrancsValue = 8;
            FoodValue = 0;
            EnergyValue = 0;
            Advanced = true;
        }
    }
}
