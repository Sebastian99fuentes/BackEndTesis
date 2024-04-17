using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Reservas
    {
             public string AppUserId { get; set; }

             public int ReservaImplementosId { get; set; } 

              public int ReservaInstalacionesId { get; set; }   

             public AppUser AppUser {get; set;}

             public ReservaImplementos ReservaImplementos {get; set;}

             public ReservaInstalaciones ReservaInstalaciones {get; set;}


    }
}
