using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
namespace api.Controllers.Interfaces
{
    public interface IHorasRepository
    {
        Task<List<Horas>> GetAllAsync();

        Task<Horas> CreateAsync(Horas horaModel);

        Task<Horas?> UpdateAsync (int id, UpdateHoraRequestDto horaDto);

        Task<Horas?> DeleteAsync(int id);

    }
}