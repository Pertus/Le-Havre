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

        
        
        
        public int CostInFrancs { get; set; }

        public Building(Action<Player> use, int costInfrancs, Image image, int id)
        {
            Id = id;
            effect = use;
            CostInFrancs = costInfrancs;
            _Image = image;
            Occupied = false;
        }
        

        public void Use(Player player)
        {
          this.effect(player);
        }
    }
}
