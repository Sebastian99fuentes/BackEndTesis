using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers.InstalacionesController.Repository
{
    public class InstalacionesRepository : IInstalacionesRepository
    {
            private readonly ApplicationDBContext _context;

        public InstalacionesRepository(ApplicationDBContext context)
       {
            _context = context;
        }
       public async Task<List<Instalaciones>> GetAllAsync()
       {
            var Instalaciones = _context.Instalaciones.Include(h => h.Horarios).AsQueryable();

            return await Instalaciones.ToListAsync();

       }

        public async  Task<Instalaciones> CreateAsync(Instalaciones instalacionModel)
        {
            await _context.Instalaciones.AddAsync(instalacionModel);
            await _context.SaveChangesAsync();
            return instalacionModel;
        }

        public async  Task<Instalaciones?> GetByIdAsync(int id)
        {
           return await _context.Instalaciones.Include(h => h.Horarios).FirstOrDefaultAsync(i => i.Id == id);
        }
    }
}