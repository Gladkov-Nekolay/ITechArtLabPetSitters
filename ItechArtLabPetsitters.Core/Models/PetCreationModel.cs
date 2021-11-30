using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Core.Models
{
    public class PetCreationModel
    {
        public string PetName { set; get; }
        public string PetType { set; get; }
        public byte Age { set; get; }
        public string Description { set; get; }
        public long OwnerID { set; get; }
    }
}
