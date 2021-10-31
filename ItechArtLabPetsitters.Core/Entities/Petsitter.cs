using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Core.Entities
{
    public class Petsitter
    {
        public long _ID { set; get; }
        public string _Name { set; get; }
        public string _PhoneNumber { set; get; }
        public List<Review> _Reviews { set; get; }
        public List<Order> _Orders { set; get; }
    }
}
