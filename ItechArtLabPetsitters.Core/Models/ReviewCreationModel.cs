using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Core.Models
{
    public class ReviewCreationModel
    {
        public long PetsitterID { set; get; }
        public long ClientID { set; get; }
        public byte Mark { set; get; }
        public string Comment { set; get; }
    }
}
