using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers.HorariosController.Data.Dto
{
    public class CreateHorariosRequestDto
    {
        [Required]
        [Range(0, 7, ErrorMessage = "El valor debe estar entre 0 7")]
        public int Dia { get; set; }
        // public int? InstalacionesId { get; set; }

    }
}