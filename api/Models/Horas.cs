using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
     [Table("Horas")]
    public class Horas
    {
        public int Id { get; set; } 
        
        public string Hora {get; set;}

        public bool  Status {get; set;}
    }
}