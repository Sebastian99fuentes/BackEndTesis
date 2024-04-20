using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers.HorasController.Data.Dtos
{
    public class HoraDto
    {
        public int Id { get; set; } 
        
        public int Hora {get; set;} 

        public bool  Status {get; set;} = false;

        public int? HorariosId { get; set; }
    }
}