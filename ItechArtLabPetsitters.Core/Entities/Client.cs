using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Repository.Entities
{
    public class Client
    {
        [Key]
        public long ID { set; get; }
        public string Name { set; get; }
        public string PhoneNumber { set; get; }
        public List<Review> Reviews { set; get; }
        public List<Order> Orders { set; get; }
        public Client(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }
}
