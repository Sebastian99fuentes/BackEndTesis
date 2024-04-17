using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Controllers.Interfaces;

namespace api.Controllers.Repository
{
    public class HorasRepository : IHorasRepository
    {   
        private readonly ApplicationDBContext _context
        public HorasRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        
         Task<List<Horas>> GetAllAsync()
         {
             return await _context.Horas.ToListAsync(query);
         }
        
         Task<Horas> CreateAsync(Horas horasModel)
         {
            await _context.Horas.addAsync(horasModel);
            await _context.SaveChangesAsync();
            return horasModel;

         }

        Task<Horas?> UpdateAsync (int id, UpdateHoraRequestDto updateDto)
        {
           var existingHora = await _contex.Horas.FirstOrDefaultAsync(x => x.Id == id); 
             if (existingHora == null)
            {
                return NotFound();
            } 
            existingHora.Status = updateDto.Status;
            existingHora.Hora = updateDto.Hora;
           
           await _context.SaveChangesAsync();

            return existingHora;
        } 

        Task<Horas?> DeleteAsync(int id)
        {
            var existingHora = await _contex.Horas.FirstOrDefaultAsync(x => x.Id == id); 
             if (existingHora == null)
            {
                return NotFound();
            } 
            _context.Horas.Remove(horaModel);
           await _context.SaveChanges();
           return existingHora;
        }
    }
}