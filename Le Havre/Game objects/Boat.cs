using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeHavre
{
    class Boat
    {
        public string Type { get; set; }
        public int Value { get; set; }
        public int Cost { get; set; }
        public int FoodProvided { get; set; }
        public int WoodCost { get; set; }
        public int EnergyCost { get; set; }
        public int IronCost { get; set; }
        public int SteelCost { get; set; }

        public Boat(string type, int value, int cost, int foodProvided, int woodCost, int ironCost, int energyCost, int steelCost)
        {
            Type = type;
            Value = value;
            Cost = cost;
            FoodProvided = foodProvided;
            WoodCost = woodCost;
            EnergyCost = energyCost;
            IronCost = ironCost;
            SteelCost = steelCost;
        }

    }
}
