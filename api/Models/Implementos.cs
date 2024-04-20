using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
     [Table("Implementos")]
    public class Implementos
    {
        
            public int Id { get; set; }
            
            public string nombreImplemento {get; set;}= string.Empty;

            public bool status {get; set;};
            public int cantidad {get; set;};

            
    }
}