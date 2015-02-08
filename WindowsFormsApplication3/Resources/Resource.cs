using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeHavre
{
    public abstract class Resource
    {
        public string Name { get; set; }
        public int FrancsValue { get; set; }
        public int FoodValue { get; set; }
        public bool Advanced { get; set; }
        public int EnergyValue { get; set; }


    }
}
