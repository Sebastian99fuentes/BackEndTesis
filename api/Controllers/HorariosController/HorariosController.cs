using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.HorariosController
{
    [ApiController]
    [Route("api/Horarios")]
    public class HorariosController : ControllerBase
    {
         private readonly IHorariosRepository _horariosRepo;
         public HorariosController(IHorariosRepository horariosRepo)
         {
            _horariosRepo = horariosRepo;
         }

         [HttpGet]
        public async Task<IActionResult> GetAll()
        {
           var horarios = await _horariosRepo.GetAllAsync();
           var HorariosDto = Horarios.Select( h => h.ToHorariosDto()).ToList();
           return Ok(HorarioDto);

        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]Horarios horariodto)
        {
            var HorarioModel = horariodto.ToHorasFromCreate();
            await _horariosRepo.CreateAsync(HorarioModel);
            return CreatedAtAction(nameof(GetById), new{id = HorarioModel.Id},HorarioModel.ToHorariosDto());

        }

        [HttpGet("{id:int}")]
        public async  Task<IActionResult> GetById([FromRoute]int id)
        {
            var horario = await _horariosRepo.GetByIdAsync(id);
            if(horario == null)
            {
                return NotFound();
            }
            return Ok(horario.ToHorariosDto());

        }


        // public async  Task<Horarios?> Update (int id, UpdateHorariosRequestDto HorarioDto)
        // {

        // }

        //  public async  Task<Horarios?> Delete(int id)
        // {

        // }

    }
}