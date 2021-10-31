using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Core.Entities
{
    public class Order
    {
        public long _ID { set; get; }
        public long _ServiceID { set; get; } // много заказов к одной услуге
        public Service _Service { set; get; }
        public long _PetID { set; get; } // много заказов к одному питомцу
        public Pet _Pet { set; get; }
        public long _PetsitterID { set; get; } // много заказов к одному петситтеру
        public Petsitter _Petsitter { set; get; }
        public long _ClientID { set; get; } // много заказов к одному пользователю
        public Client _Client { set; get; }
        public string _Comment { set; get; }
    }
}
