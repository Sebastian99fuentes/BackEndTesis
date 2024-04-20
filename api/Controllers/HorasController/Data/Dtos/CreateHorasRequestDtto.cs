using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Data.Dtos.HorasDtos
{
    public class CreateHorasRequestDtto
    {
        [Required]
        [Range(7, 18, ErrorMessage = "El valor debe estar entre 7 y 18.")]
        public int Hora {get; set;}
        public bool  Status {get; set;} = false;
    }
}