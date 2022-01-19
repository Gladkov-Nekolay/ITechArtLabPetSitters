using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechArtLabPetsitters.Core.Models
{
    public class PaginationSettingsModel
    {
        [Required(ErrorMessage = "Размер страницы должен быть установлен")]
        [Range(1, 100, ErrorMessage = "Cтраница должна содержать от 1 до 100 записей")]
        public int PageSize { set; get; }
        [Required(ErrorMessage = "Номер запрашиваемой страницы должен быть установлен")]
        [Range(1,int.MaxValue,ErrorMessage = "Номер станицы должен быть как минимум равен 1")]
        public int PageNumber { set; get; }
    }
}
