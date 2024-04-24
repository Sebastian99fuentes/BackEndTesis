using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers.ReservasController.Repository
{
    public class ReservaRepository :IReservaReposotory
    {
        private readonly ApplicationDBContext _context;
        public ReservaRepository(ApplicationDBContext context)
        {
            _context= context;
        }
        
        public async Task<List<Reservas>> GetUserReserva(AppUser user)
        {
            returnn await _context.Reservas.Where(u => u.AppUserId == user.Id)
            .Select(instalaciones => new Instalaciones
            {
                Id = instalaciones.Id,
                nombreInstalacion = instalaciones.nombreInstalacion

            }).ToListAsync();
        }

        public async Task<Reservas> CreateAsync(Reservas reserva)
        {
            await _context.Reservas.AddAsync(reserva);
            await _context.SaveChangesAsync();
            return reserva;

        }

        public async Task<Reservas> DeleteReserva(AppUser appUser, string instalacionName)
        {
            var reservaModel = await _context.Reservas.FirstOrDefaultAsync(u => u.AppUserId == appUser.Id  && u.Instalaciones.nombreInstalacion.ToLower() == instalacionName.ToLower());

            if(reservaModel == null)
            {
                return null;
            }

            _context.Reservas.Remove(portfolioModel);
            await _context.SaveChangesAsync();
            return reservaModel;
        }
    }
}