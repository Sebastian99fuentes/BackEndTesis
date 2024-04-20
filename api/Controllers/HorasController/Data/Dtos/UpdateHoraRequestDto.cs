using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Data.Dtos.HorasDtos
{
    public class UpdateHoraRequestDto
    {
        
        [Required]
        public bool  Status {get; set;}
        
    }
}