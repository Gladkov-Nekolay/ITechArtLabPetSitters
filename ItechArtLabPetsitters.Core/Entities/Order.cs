using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public long PetsitterID { set; get; } // много заказов к одному петситтеру
        public Petsitter Petsitter { set; get; }
        public long ClientID { set; get; } // много заказов к одному пользователю
        public Client Client { set; get; }
        public string Comment { set; get; }
        public Order( long serviceID, long petID, long petsitterID,  long clientID, string comment)
        {
            ServiceID = serviceID;
            PetID = petID;
            PetsitterID = petsitterID;
            ClientID = clientID;
            Comment = comment;
        }
    }
}
