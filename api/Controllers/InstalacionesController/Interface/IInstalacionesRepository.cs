using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers.InstalacionesController.Interface
{
    public interface IInstalacionesRepository
    {
        Task<List<Instalaciones>> GetAllAsync();

        Task<Instalaciones> CreateAsync(Instalaciones instalacionModel);

        Task<Instalaciones?> GetByIdAsync(int id);

        Task<Instalaciones?> UpdateAsync (int id, UpdateInstalacionRequestDto instalacionDto);

        Task<Instalaciones?> DeleteAsync(int id);
    }
}