using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers.HorariosController.Repository
{
    public class HorariosRepository : IHorariosRepository
    {
        private readonly ApplicationDBContext _context;
        public HorariosRepository(ApplicationDBContext context)
        {
            _context = context;
            
        }
      
        public async Task<List<Horarios>> GetAllAsync()
        {
            var Horarios =  _context.Horarios.Include(h => h.Horarios).AsQueryable();
           
            return await Horarios.ToHorariosDto().ToListAsync();

        }
  
        Task<Horarios> CreateAsync(Horarios horarioModel)
        {

            await _context.Horarios.addAsync(horarioModel);
            await _context.SaveChangesAsync();
            return horaModel;
        }

        Task<Horarios?> GetByIdAsync(int id)
        {
            return await _context.horaModel.Include(h => h.Horarios).FirstOrDefaultAsync(h => h.Id == id);
        }

        // Task<Horarios?> UpdateAsync (int id, UpdateHorariosRequestDto HorarioDto)
        // {

        // }

        // Task<Horarios?> DeleteAsync(int id)
        // {

        // }
    }
}