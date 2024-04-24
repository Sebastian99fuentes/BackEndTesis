using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers.InstalacionesController.Data.Dtos
{
    public class UpdateInstalacionRequestDto
    {
        [Required]
        public string  nombreInstalacion {get; set;}
    }
}