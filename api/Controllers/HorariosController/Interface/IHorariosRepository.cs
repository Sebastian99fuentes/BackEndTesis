using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers.HorariosController.Interface
{
    public interface IHorariosRepository
    {
        Task<List<Horarios>> GetAllAsync();

        Task<Horarios> CreateAsync(Horarios horaModel);

        Task<Horarios?> GetByIdAsync(int id);

        Task<Horarios?> UpdateAsync (int id, UpdateHorariosRequestDto HorarioDto);

        Task<Horarios?> DeleteAsync(int id);

    }
}