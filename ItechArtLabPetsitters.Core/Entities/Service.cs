using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Core.Entities
{
    public class Service
    {
        [Key]
        public long _ID { set; get; }
        public string _ServiceName { set; get; }
        public string _Description { set; get; }
        public decimal _Price { set; get; }
        public List<Order> _Orders { set; get; }
        public Service(string serviceName, string description, decimal price)
        {
            _ServiceName = serviceName;
            _Description = description;
            _Price = price;
        }
    }
}
