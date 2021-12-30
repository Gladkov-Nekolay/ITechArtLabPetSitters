using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Core.Models
{
    public class UserAuthentificationModel
    {
        [Required(ErrorMessage = "Email не может быть пустым")]
        public string Email { set; get; }
        [Required(ErrorMessage = "Пароль не может быть пустым")]
        public string Password { set; get; }
    }
}
