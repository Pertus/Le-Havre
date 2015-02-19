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
        public Action<Player> effect;
        public Image _Image { get; set; }

        
        
        
        public int CostInFrancs { get; set; }

        public Building(Action<Player> use, int costInfrancs, string imagePath)
        {

            effect = use;
            CostInFrancs = costInfrancs;
            _Image = Image.FromFile(imagePath);
        }
        

        public void Use(Player player)
        {
          this.effect(player);
        }
    }
}
