using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Core.Models
{
    public class ServiceCreationModel
    {
        [Required(ErrorMessage = "Услуга должна иметь наименование")]
        [MaxLength (150,ErrorMessage ="Услуга должна иметь наименование короче 150 символов")]
        public string ServiceName { set; get; }
        [MaxLength(1000,ErrorMessage ="Описание услуги должно быть короче 1000 символов")]
        public string Description { set; get; }
        [Required(ErrorMessage = "Услуга должна иметь цену")]
        public double Price { set; get; }
    }
}
