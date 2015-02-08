using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeHavre
{
    class BuildingCard
    {
        public BuildingCard(Action<Player> use)
        {
            effect = use;
        }
        public Action<Player> effect;

        public void Use(Player player)
        {
          this.effect(player);
        }
    }
}
