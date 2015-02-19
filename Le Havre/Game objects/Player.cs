using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeHavre
{
    class Player
    {
        public int Points { get; set; }

        public int Francs { get; set; }
        public int Fish { get; set; }
        public int Wood { get; set; }
        public int Clay { get; set; }
        public int Grain { get; set; }
        public int Iron { get; set; }
        public int Cattle { get; set; }
        public int Coal { get; set; }
        public int Hides { get; set; }
        public int SmokedFish { get; set; }
        public int Charcoal { get; set; }
        public int Bricks { get; set; }
        public int Bread { get; set; }
        public int Steel { get; set; }
        public int Meat { get; set; }
        public int Coke { get; set; }
        public int Leather { get; set; }

        //private List<Resource> resourceList;
        private List<Boat> boatList;

        public int Houses { get; set; }
        public int Industries { get; set; }
        public int GovernmentBuildings { get; set; }
        public int FishingSymbols { get; set; }
        public int Hammers { get; set; }
        public int Loans { get; set; }
        public string Color { get; set; }

        public Player(String color)
        {
            Francs = 2;
            Fish = 2;
            Wood = 2;
            Clay = 0;
            Grain = 0;
            Iron = 0;
            Cattle = 0;
            Coal = 1;
            Hides = 0;
            SmokedFish = 0;
            Charcoal = 0;
            Bricks = 0;
            Bread = 0;
            Steel = 0;
            Meat = 0;
            Coke = 0;
            Leather = 0;

            //resourceList = new List<Resource>() { new Franc(), new Franc(), new Fish(), new Fish(), new Wood(), new Wood(), new Coal()};
            boatList = new List<Boat>();
            Houses = 0;
            Industries = 0;
            GovernmentBuildings = 0;
            Loans = 0;
            FishingSymbols = 0;
            Hammers = 0;
            Points = CalculatePoints();
            Color = color;
        }


        public int CalculatePoints()
        {
            int result=0;

            //var francs = resourceList.OfType<Franc>();
            //foreach (Franc f in francs)
            //{
            //    result++;
            //}
            result = result + Francs;
            result -= Loans * 7;

            return result;
        }

        //public void AddResource(Resource resource, int amount)
        //{
        //    for (int i = 0; i < amount; i++)
        //    {
        //        resourceList.Add(resource);
        //    }

        //}

        //public void PayResource(String resource, int amount)
        //{
        //    var temp = resourceList.Find(x => x.Name == resource);
        //    resourceList.Remove(temp);
        //}

        //public int GetNumberOfAResource(string resource)
        //{
        //    int result = resourceList.Where(x => x.Name == resource).Count();
        //    return result;
        //}

        public int GetAmmountOfFoodFromBoats()
        {
            int result = 0;
            foreach (Boat b in boatList)
            {
                result += b.FoodProvided;
            }
            return result;
        }




    }
}
