using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers.InstalacionesController.Data.Dto
{
    public class CreateInstalacionRequestDto
    {
      [Required]
      [MaxLength(10, ErrorMessage = "nombre de la instalacion no puede pasar los 10 caracteres")]
        public string nombreInstalacion { get; set; }
     
    }
}