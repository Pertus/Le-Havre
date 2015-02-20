﻿using System;
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

        public static void Cokery(Player player)
        {
            player.Coke += 5;
        }
        public static void BridgeOverSeine(Player player)
        {
            player.Francs += 100;
        }
    }
}
