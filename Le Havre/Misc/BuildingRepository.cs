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

            standardBuildingList.Add(new Building(BuildingFunctions.Fishery, 10, 10, 1, 2, 0, 0, 0, 0, 0, true, false, false, false, true, false, true, Properties.Resources._3, 3));
            standardBuildingList.Add(new Building(BuildingFunctions.Bakehouse, 8, 8, 0, 2, 0, 0, 0, 1, 0, true, false, false, false, false, false, true, Properties.Resources._5, 5));
            standardBuildingList.Add(new Building(BuildingFunctions.CharcoalKiln, 8, 8, 0, 1, 0, 0, 0, 0, 0, true, false, false, false, false, false, true, Properties.Resources._7, 7));
            standardBuildingList.Add(new Building(BuildingFunctions.Smokehouse, 6, 6, 2, 1, 0, 0, 0, 2, 1, true, false, false, false, true, false, true, Properties.Resources._8, 8));
            standardBuildingList.Add(new Building(BuildingFunctions.Abattoir, 8, 8, 1, 1, 1, 0, 0, 0, 2, true, false, false, false, false, false, true, Properties.Resources._9, 9));
            standardBuildingList.Add(new Building(BuildingFunctions.ClayMound, 2, 2, 0, 0, 0, 0, 0, 1, 0, false, false, false, false, false, false, false, Properties.Resources._10, 10));

        }

        public Building GetBuilding(int id)
        {
            Building building = standardBuildingList.Where(x => x.Id == id).First();
            return (Building)building;
        }
    }
}
