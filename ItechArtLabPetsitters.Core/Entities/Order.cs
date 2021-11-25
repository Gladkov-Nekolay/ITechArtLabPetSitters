using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Repository.Entities
{
    public class Order
    {


        [Key]
        public long ID { set; get; }
        public long ServiceID { set; get; } // много заказов к одной услуге
        public Service Service { set; get; }
        public long PetID { set; get; } // много заказов к одному питомцу
        public Pet Pet { set; get; }
        [ForeignKey("DoerOrders")]
        public long ? PetsitterID { set; get; } // много заказов к одному петситтеру
        public User Petsitter { set; get; }
        [ForeignKey("PostedOrder")]
        [Required]
        public long ClientID { set; get; } // много заказов к одному пользователю
        public User Client { set; get; }
        public string Comment { set; get; }
    }
}
