using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Core.Models
{
    public class ReviewCreationModel
    {
        [Required(ErrorMessage ="Поле ID исполнителя не должно быть пустым")]
        public long PetsitterID { set; get; }
        [Required(ErrorMessage = "Поле ID клиента не должно быть пустым")]
        public long ClientID { set; get; }
        [Required(ErrorMessage = "Поле оценка не должно быть пустым")]
        [Range(0,5, ErrorMessage = "Оценка должна быть от 0 до 5")]// проверка на попадание в отрезок 0-5
        public byte Mark { set; get; }
        [MaxLength(1000, ErrorMessage ="Комментарий должен быть короче 1000 символов")]
        public string Comment { set; get; }
    }
}
