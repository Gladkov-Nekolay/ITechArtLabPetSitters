using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAnnotationsExtensions;

namespace ItechArtLabPetsitters.Core.Models
{
    public class UserCreationModel
    {
        [Required(ErrorMessage = "Email не может быть пустым")]
        [Email(ErrorMessage = "Ошибка. Email не валидный")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Имя обязательно к заполнению")]
        [MaxLength(100, ErrorMessage ="Имя должно иметь менее 100 символов")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Пароль не может быть пустым")]
        [MinLength(4, ErrorMessage ="Пароль должен быть не короче четырех символов")]
        public string Password { get; set; }
    }
}
