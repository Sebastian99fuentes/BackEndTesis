using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("ReservaInstalaciones")]
    public class ReservaInstalaciones
    {
        public int Id { get; set; } 

        public  string Instalacion {get; set;};

         public List<Horarios> Horario {get; set;} = new List<Horarios>();
    }
}