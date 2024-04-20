using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Data.Mappers
{
    public static class HorasMappers
    {

        public static HoraDto ToHorastDto(this Horas commentModel)
        {
            return new HoraDto
            {
                    Id = commentModel.Id,
                    Hora = commentModel.Hora,
                    Status = commentModel.Status,
                    HorariosId = commentModel.HorariosId
            };
        }


        public static  Horas ToHorasFromCreate(this CreateHorasRequestDtto  HorasModel, int HorariosId)
        {
                return new Horas 
                {
                  
                    Hora = HorasModel.Hora,
                    HorariosId = HorariosId
                  
                };
        }
        
        public static Horas ToHorasFromUpdate(this UpdateHoraRequestDto HorariosId, int stockId)
        {
            return new Horas
            { 
                    Status = HoraModel.Status,
                    HorariosId = HorariosId
            };
        }
    }
}