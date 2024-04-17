using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Data.Mappers
{
    public static class HorasMappers
    {
        public static   Horas ToHoras(this  HorasModel)
        {
                return new Horas 
                {
                    Id = HorasModel.Id,
                    Hora = HorasModel.Hora,
                    Status = HorasModel.Status
                  
                };
        }
        
        public static Horas ToHorasFromCreateDto(this CreateHorasRequestDtto horasdto)
        {
            return new Horas
            { 
                Hora = horasdto.Hora,
                Status = horasdto.Status

            };
        }
    }
}