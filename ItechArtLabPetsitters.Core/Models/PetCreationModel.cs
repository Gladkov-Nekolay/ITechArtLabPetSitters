using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Core.Models
{
    public class PetCreationModel
    {
        [Required(ErrorMessage ="Имя питомца не должно быть пустым")]
        [MaxLength(100, ErrorMessage ="Имя должно иметь менее 100 символов")]
        public string PetName { set; get; }
        [Required(ErrorMessage = "Тип питомца не должно быть пустым")]
        [MaxLength(100, ErrorMessage = "Имя должно иметь менее 100 символов")]
        public string PetType { set; get; }
        [Range(0,10000,ErrorMessage ="Возраст не может быть меньще 0 или больше 10000")]
        public byte Age { set; get; }
        [MaxLength(1000,ErrorMessage ="Описание питомца должно быть короче 1000 символов")]
        public string Description { set; get; }
        [Required(ErrorMessage ="Хозяин питомца не должно быть пустым")]
        public long OwnerID { set; get; }
    }
}
