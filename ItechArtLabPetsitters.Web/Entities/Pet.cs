using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Web.Entities
{
    public class Pet
    {
        public string _PetType { set; get; }
        public string _PetName { set; get; }
        public byte _Age { set; get; }
        public string _Description { set; get; }
    }
}
