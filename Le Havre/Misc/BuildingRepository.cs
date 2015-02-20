using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeHavre.Misc
{
    class BuildingRepository
    {
        private List<Building> standardBuildingList;

        public BuildingRepository()
        {
            standardBuildingList = new List<Building>();

            standardBuildingList.Add(new Building(BuildingFunctions.BridgeOverSeine, 2, Properties.Resources._27, 27));
            standardBuildingList.Add(new Building(BuildingFunctions.Cokery, 3, Properties.Resources._25, 25));
        }

        public Building GetBuilding(int id)
        {
            Building building = standardBuildingList.Where(x => x.Id == id).First();
            return (Building)building;
        }
    }
}
