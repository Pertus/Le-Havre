using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeHavre
{
    class Wood:Resource
    {
        public Wood()
        {
            Name = "Wood";
            FrancsValue = 0;
            FoodValue = 0;
            EnergyValue = 1;
            Advanced = false;
        }
    }
}
