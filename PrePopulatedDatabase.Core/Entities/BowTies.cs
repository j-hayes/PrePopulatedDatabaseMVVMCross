using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrePopulatedDatabase.Core.Entities
{
    public class BowTie
    {
        public int ID { get; set; }
        public string PrimaryColor { get; set; }
        public string AccentColor { get; set; }
        public string TieName { get; set; }
        public string Brand { get; set; }
        public int RemainingStock { get; set; }
        public string RelImageUrl { get; set; }
        public bool IsClipOn { get; set; }

        
        

    }
}
