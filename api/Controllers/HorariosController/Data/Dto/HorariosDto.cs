using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers.HorariosController.Data.Dto
{
    public class HorariosDto
    { 
        public int Id { get; set; } 

        public int Dia { get; set; }

        public int? InstalacionesId { get; set; }
        
        public List<Horas> Horarios {get; set;}

    }
}