using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAnnotationsExtensions;

namespace ItechArtLabPetsitters.Core.Models
{
    public class UserAuthentificationModel
    {
        [Required(ErrorMessage = "Email не может быть пустым")]
        [Email(ErrorMessage = "Ошибка. Email не валидный")]
        public string Email { set; get; }
        [Required(ErrorMessage = "Пароль не может быть пустым")]
        public string Password { set; get; }
    }
}
