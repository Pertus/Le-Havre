using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeHavre.Misc
{
    static class BuildingFunctions
    {
        public static void ClayMound(Player player)
        {
            player.Clay += 3 + player.Hammers;
        }
        public static void Fishery(Player player)
        {
            player.Fish += 3 + player.FishingSymbols;
        }
        public static void Bakehouse(Player player)
        {
            new BakehouseForm(player).Show();
        }

        //public static void Cokery(Player player)
        //{
        //    player.Coke += 5;
        //}
        //public static void BridgeOverSeine(Player player)
        //{
        //    player.Francs += 100;
        //}
    }
}
