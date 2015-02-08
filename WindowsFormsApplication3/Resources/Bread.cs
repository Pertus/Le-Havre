using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeHavre.Resources
{
    class Bread:Resource
    {
        public Bread()
        {
            Name = "Bread";
            FrancsValue = 3;
            FoodValue = 2;
            EnergyValue = 0;
            Advanced = true;
        }
    }
}
