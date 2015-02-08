using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeHavre
{
    class EndTurnArgs:EventArgs
    {
        public string NewActivePlayer { get; set; }

        public EndTurnArgs(string newActivePlayer)
        {
            NewActivePlayer = newActivePlayer;
        }
    }
}
