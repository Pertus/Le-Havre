using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeHavre
{
    class RoundMarker
    {
        public int Id { get; set; }
        public string FirstResource { get; set; }
        public string SecondResource { get; set; }
        public bool Interest { get; set; }

        public RoundMarker(string firstResource, string secondResource, bool interest, int id)
        {
            Id = id;
            FirstResource = firstResource;
            SecondResource = secondResource;      
            Interest = interest;
        }
    }
}
