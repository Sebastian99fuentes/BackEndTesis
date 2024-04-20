using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("Instalaciones")]
    public class Instalaciones
    {
        public int Id { get; set; } 

        public  string nombreInstalacion {get; set;};
         
        public List<Horarios> Horarios { get; set; } = new List<Horarios>();
    }
}