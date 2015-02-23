using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeHavre.Misc
{
    static class BuildingFunctions
    {

        public static void Fishery(Player player)
        {
            player.Fish += 3 + player.FishingSymbols;
        }
        public static void Bakehouse(Player player)
        {
            new BakehouseForm(player).ShowDialog();
        }
        public static void CharcoalKiln(Player player)
        {
            new CharcoalKilnForm(player).ShowDialog();
        }
        public static void Smokehouse(Player player)
        {
            if (player.TotalEnergy < 1)
                System.Windows.Forms.MessageBox.Show("You don't have the energy needed!");
            else
                new SmokehouseForm(player).ShowDialog();
        }
        public static void Abattoir(Player player)
        {
            new AbattoirForm(player).ShowDialog();
        }

        public static void ClayMound(Player player)
        {
            player.Clay += 3 + player.Hammers;
        }

    }
}
