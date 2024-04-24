using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers.ReservasController.Interface
{
    public interface IReservaReposotory
    {
        Task<List<Instalaciones>> GetUserReserva(AppUser user);
        Task<Reservas> CreateAsync(Reservas portfolio);
        Task<Reservas> DeleteReserva(AppUser appUser, string id);
    }
}