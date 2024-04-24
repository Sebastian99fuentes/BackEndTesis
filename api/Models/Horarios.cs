using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
     [Table("Horarios")]
    public class Horarios
    {
         public int Id { get; set; } 
         public int Dia { get; set; }

         public int? InstalacionesId { get; set; }
         public Instalaciones? Instalaciones { get; set; }

        public List<Horas> Horarios {get; set;} = new List<Horas>();

    }
}