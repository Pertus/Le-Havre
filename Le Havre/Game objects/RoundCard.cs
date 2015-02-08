using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeHavre
{
    class RoundCard
    {
        public int RoundNr { get; set; }
        public int FoodNeeded { get; set; }
        public bool Harvest { get; set; }
        public bool SpecialBuilding { get; set; }
        public bool BuildBuilding { get; set; }

        public RoundCard(int roundNr, int foodNeeded, bool harvest, bool specialBuilding, bool buildBuilding)
        {
            RoundNr = roundNr;
            FoodNeeded = foodNeeded;
            Harvest = harvest;
            SpecialBuilding = specialBuilding;
            BuildBuilding = buildBuilding;
        }
    }
}
