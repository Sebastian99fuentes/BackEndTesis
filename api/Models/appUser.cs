using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class appUser
    {
         public class AppUser :IdentityUser
    {
        public List<Reservas> Reservas {get; set; } = new List<Reservas>();
        public int ReservaInstalaciones { get; set; } = 0;
        public int ReservaImplementos { get; set; } = 0;
    }
    }
}