using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Core.Entities
{
    public class Service
    {
        public long _ID { set; get; }
        public string _ServiceName { set; get; }
        public string _Description { set; get; }
        public decimal _Price { set; get; }
        public List<Order> _Orders { set; get; }
        public Service(long ID, string ServiceName, string Description) 
        {
            _ID = ID;
            _ServiceName = ServiceName;
            _Description = Description;
        }
    }
}
