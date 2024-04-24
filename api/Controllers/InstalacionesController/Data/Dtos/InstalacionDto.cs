using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers.InstalacionesController.Data.Dtos
{
    public class InstalacionDto
    {
        public int Id { get; set; } 

        public  string nombreInstalacion {get; set;};
          
        public List<Horarios> Horarios { get; set; };
    }
}