using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
     [Table("ReservaImplementos")]
    public class ReservaImplementos
    {
        
            public int Id { get; set; }
            
            public  string Implemento {get; set;};

            public List<Horarios> Horario {get; set;} = new List<Horarios>();
    }
}