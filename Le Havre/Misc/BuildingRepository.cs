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

            standardBuildingList.Add(new Building(BuildingFunctions.Fishery, 10, 1, 2, 0, 0, 0, 0, 0, true, false, false, false, true, false, Properties.Resources._3, 3));
            standardBuildingList.Add(new Building(BuildingFunctions.Bakehouse, 8, 0, 2, 0, 0, 0, 1, 0, true, false, false, false, false, false, Properties.Resources._5, 5));

        }

        public Building GetBuilding(int id)
        {
            Building building = standardBuildingList.Where(x => x.Id == id).First();
            return (Building)building;
        }
    }
}
