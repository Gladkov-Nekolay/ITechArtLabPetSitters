using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Core.Entities
{
    public class Pet
    {
        public long _ID { set; get; }
        public string _PetName { set; get; }
        public string _PetType { set; get; }
        public byte _Age { set; get; }
        public string _Description { set; get; }
        public List<Order> _Orders { set; get; }
    }
}
