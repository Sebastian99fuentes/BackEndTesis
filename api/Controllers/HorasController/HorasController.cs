using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    
    [Route("api/horas")]
    [ApiController]
    public class HorasController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IHorasRepository _horasRepo;
        
        public HorasController(ApplicationDBContext context, IHorasRepository horasRepo)
        {
            _context = context;
            _horasRepo = horasRepo;
        }

        [httpGet]
        // public async Task<IActionResult> GetAll([FromQuery] QueryObject query)
        public async Task<IActionResult> GetAll()
        {
            // var Horas =  await _context.Horas.ToListAsync(query);
            // var Horas =  await _context.Horas.ToListAsync();
            // var Horas = Horas.Select(s => s.ToHoras()).ToList();
            // return Ok(Horas);
            var Horas =  await _horasRepo.GetAllAsync();
            var HorasDto = Horas.Select(s => s.ToHorastDto());
            return Ok(HorasDto);
        }

        [HttpGet("{id:int}")]   
        public async Task<IActionResult> GetById([FromRoute]int id)
        {

            // var hora = await _context.Horas.FindAsync(id);
            // if (hora == null)
            // {
            //     return NotFound();
            // }
            // return Ok(hora.ToHoras());

            var hora = await _horasRepo.GetByIdAsync(id);
            if (hora == null)
            {
                return NotFound();
            }
            return Ok(hora.ToHorastDto());
        }


        [HttpPost]
        public async Task<IActionResult>  Create([FromBody] CreateHorasRequestDtto HoraDto)
        { 
           
            //  var HoraModel = HoraDto.ToHorasFromCreateDto();

            //  await _context.Horas.addAsync(HoraModel);
            //  await _context.SaveChangesAsync();
            // return CreatedAtAction(nameof(GetById), new {id = HoraModel.Id}, HoraModel.ToHoras());

        //     if(!ModelState.IsValid)
        //         return BadRequest(ModelState);
                
            var HoraModel = HoraDto.ToHorasFromCreateDto();
           await _horasRepo.CreateAsync(HoraModel);
            return CreatedAtAction(nameof(GetById), new {id = HoraModel.Id}, HoraModel.ToHoras());
        }  

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update([FromRoute]int id, [FromBody] UpdateHoraRequestDto updateDto)
        {
            
        //     var HoraModel = await _contex.Horas.FirstOrDefaultAsync(x => x.Id == id); 
        //      if (HoraModel == null)
        //     {
        //         return NotFound();
        //     } 
        //     HoraModel.Status = updateDto.Status;

        //    await _context.SaveChangesAsync();
        //     return Ok(HoraModel.ToHorastDto());

            //  if(!ModelState.IsValid)
            //     return BadRequest(ModelState);
                
            var HoraModel = await _horasRepo.UpdateAsync(id, updateDto); 
             if (HoraModel == null)
            {
                return NotFound();
            } 

           
            return Ok(HoraModel.ToStockDto());

        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete ([FromRoute] int id)
        {

        //     var horaModel = await _context.Horas.FirstOrDefaultAsync(x => x.Id);
        //     if (horaModel == null)
        //     {
        //         return NotFound();
        //     } 
        //     _context.Horas.Remove(horaModel);
        //    await _context.SaveChanges();
        //     return NoContent();

            var HoraModel = await _horasRepo.DeleteAsync(id);
             if (HoraModel == null)
            {
                return NotFound();
            } 

            return NoContent();

        } 


    }
}