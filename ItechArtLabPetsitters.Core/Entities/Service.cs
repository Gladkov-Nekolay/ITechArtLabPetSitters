using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Repository.Entities
{
    public class Service
    {
        [Key]
        public long ID { set; get; }
        public string ServiceName { set; get; }
        public string Description { set; get; }
        public decimal Price { set; get; }
        public List<Order> Orders { set; get; }
        public Service(string serviceName, string description, decimal price)
        {
            ServiceName = serviceName;
            Description = description;
            Price = price;
        }
    }
}
