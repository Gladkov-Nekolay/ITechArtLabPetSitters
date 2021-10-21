using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Web.Entities
{
    public class Orders
    {
        public long _ID { set; get; }
        public string _Remarks { set; get; }
        public List<Service> _ServicesList { set; get; }
    }
}
