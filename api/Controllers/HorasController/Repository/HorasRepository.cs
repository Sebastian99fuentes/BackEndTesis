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
        
         public async Task<List<Horas>> GetAllAsync()
         {
             return await _context.Horas.ToListAsync();
         }
        
         public async Task<Horas> CreateAsync(Horas horasModel)
         {
            await _context.Horas.addAsync(horasModel);
            await _context.SaveChangesAsync();
            return horasModel;

         }
         
         public async Task<Horas?> GetByIdAsync(int id)
         {
            return await _context.Horas.FirstOrDefaultAsync(c => c.Id == id);
         }

         public async Task<Horas?> UpdateAsync (int id, Horas updateDto)
        {
           var existingHora = await _contex.Horas.FindAsync(id); 
             if (existingHora == null)
            {
                return NotFound();
            } 
            existingHora.Status = updateDto.Status;
           
           await _context.SaveChangesAsync();

            return existingHora;
        } 

         public async Task<Horas?> DeleteAsync(int id)
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