using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Repository.Entities
{
    public class Petsitter
    {
        
        [Key]
        public long _ID { set; get; }
        public string _Name { set; get; }
        public string _PhoneNumber { set; get; }
        public List<Review> Reviews { set; get; }
        public List<Order> Orders { set; get; }
        public Petsitter(string name, string phoneNumber)
        {
            _Name = name;
            _PhoneNumber = phoneNumber;
        }
    }
}
