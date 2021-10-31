using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Core.Entities
{
    public class Review
    {
        public long _ReviewID { set; get; }
        public long _PetsitterID { set; get; }
        public Petsitter _Petsitter { set; get; }
        public long _ClientID { set; get; }
        public Client _Client { set; get; }
        public byte _Mark { set; get; }
        public string _Comment { set; get; }
    }
}
