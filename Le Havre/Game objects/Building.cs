using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LeHavre
{
    class Building
    {
        public int Id { get; set; }
        public Action<Player> effect;
        public Image _Image { get; set; }
        public bool Occupied { get; set; }
        public int CostInWood { get; set; }
        public int CostInClay { get; set; }
        public int CostInIron { get; set; }
        public int CostInBricks { get; set; }
        public int CostInSteel { get; set; }
        public int FoodFee { get; set; }
        public int FrancsFee { get; set; }
        public bool HouseSymbol { get; set; }
        public bool IndustrySymbol { get; set; }
        public bool GovernmentSymbol { get; set; }
        public bool CitySymbol { get; set; }
        public bool FishingSymbol { get; set; }
        public bool Hammer { get; set; }

        
        
        
        public int CostInFrancs { get; set; }

        public Building(Action<Player> use, int costInfrancs, int costInWood, int costInClay, int costInIron, 
            int costInBricks, int costInSteel, int foodFee, int francsFee, bool houseSymbol, bool industrySymbol, bool governmentSymbol, bool citySymbol, 
            bool fishingSymbol, bool hammer, Image image, int id)
        {
            Id = id;
            effect = use;
            CostInFrancs = costInfrancs;
            CostInWood = costInWood;
            CostInClay = costInClay;
            CostInIron = costInIron;
            CostInBricks = costInBricks;
            CostInSteel = costInSteel;
            FoodFee = foodFee;
            FrancsFee = francsFee;
            HouseSymbol = houseSymbol;
            IndustrySymbol = industrySymbol;
            GovernmentSymbol = governmentSymbol;
            CitySymbol = citySymbol;
            FishingSymbol = fishingSymbol;
            Hammer = hammer;
            _Image = image;
            Occupied = false;
        }
        

        public void Use(Player player)
        {
          this.effect(player);
        }
    }
}
