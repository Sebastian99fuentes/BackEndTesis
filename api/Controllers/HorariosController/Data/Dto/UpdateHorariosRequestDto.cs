using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers.HorariosController.Data.Mapper.Dto
{
    public class UpdateHorariosRequestDto
    {
         [Required]
        public bool  Dia {get; set;}
    }
}