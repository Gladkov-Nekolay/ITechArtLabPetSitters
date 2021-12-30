using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Core.Models
{
    public class OrderCreationModel
    {
        [Required(ErrorMessage = "ID услуги не должно быть пустым")]
        public long serviceID { set; get; }
        [Required(ErrorMessage ="ID питомца не должно быть пустым")]
        public long petID { set; get; }
        [Required(ErrorMessage = "ID заказчика не должно быть пустым")]
        public long clientID { set; get; }
        [MaxLength(1000,ErrorMessage ="Комментарий к заказу должен быть короче 1000 символов")]
        public string comment { set; get; }
    }
}
