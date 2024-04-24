using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers.HorariosController.Data.Mapper.Dto
{
    public static class HorariosMapper
    {
        
        public static HorariosDto ToHorariosDto(this Horarios HorariosModel)
        {
            return new Horarios
            {
                    Id = HorariosModel.Id,
                    Dia = HorariosModel.Dia,
                    InstalacionesId = HorariosModel.InstalacionesId,
                    Horarios =HorariosModel.Horarios.Select( c => c.ToHorastDto()).ToList();
            };
        }

            public static Horarios ToHorasFromCreate(this CreateHorariosRequestDto HorariosModel)
        {
            return new Horarios
            {
                  
                    Dia = HorariosModel.Dia
            };
        }

            public static Horarios ToHorasFromUpdate(this UpdateHorariosRequestDto HorariosModel)
        {
            return new Horarios
            {  
                    Dia = HorariosModel.Dia
            };
        }
    }
}