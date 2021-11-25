using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Repository.Entities;

namespace ItechArtLabPetsitters.Repository.Entities
{
    public class User
    {
        [Key]
        public long ID { set; get; }
        public string Email { set; get; }
        public string Name { set; get; }
        public List<Review> Reviews { set; get; }
        [InverseProperty("Petsitter")]
        public List<Order> DoerOrders { set; get; } // список заказов как исполнитель
        [InverseProperty("Client")]
        public List<Order> PostedOrder { set; get; } // список заказов как закасчика
        public List<Pet> Pets { set; get; }
    }
}
