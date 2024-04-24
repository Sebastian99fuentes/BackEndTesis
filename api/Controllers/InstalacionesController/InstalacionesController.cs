using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.InstalacionesController
{
    [ApiController]
    [Route("api/Instalaciones")]
    public class InstalacionesController : ControllerBase
    {
        private readonly IInstalacionesRepository _instalacionesRepo;

        public InstalacionesController(IInstalacionesRepository instalacionesRepo)
        {
            _instalacionesRepo = instalacionesRepo;
        }

        [HttpGet]
      public async  Task<IActionResult> GetAll()
      {
        var Instalaciones =  await _instalacionesRepo.GetAllAsync();
        var InstalacionesDto = Instalaciones.Select(i => i.ToInstalacionDto()).ToList();
        return Ok(InstalacionesDto);
      }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Instalaciones instalacionDto)
        {
            var instalacionModel = instalacionDto.ToInstalacionFromCreate();
            await _instalacionesRepo.CreateAsync(instalacionModel);
            return CreatedAtAction(nameof(GetById), new{id = instalacionModel.Id},instalacionModel.ToHorariosDto());

        }

        [HttpGet("{id:int}")]
         public async Task<IActionResult> GetByID([FromRoute] int id)
        {
            var instalacion = await _instalacionesRepo.GetByIdAsync(id);
            if(instalacion == null)
            {
                return NotFound();
            }
            return Ok(instalacion.ToInstalacionDto());
        }
        
    }
}