using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeHavre.Resources
{
    class Cattle:Resource
    {
        public Cattle()
        {
            Name = "Cattle";
            FrancsValue = 3;
            FoodValue = 0;
            EnergyValue = 0;
            Advanced = false;
        }
    }
}
