using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers.InstalacionesController.Data.Mappers
{
    public static class InstalacionMappers
    {
        public static InstalacionesDto ToInstalacionDto (this Instalaciones InstalacionModel)
        {
            return new InstalacionesDto
            {
                Id = instalacionModel.Id,
                nombreInstalacion = instalacionModel.nombreInstalacion,
                Horarios = instalacionModel.Instalaciones.Select( i => i.ToHorariosDto()).ToList();
            }
        }

          public static Instalaciones ToInstalacionFromCreate (this Instalaciones InstalacionModel)
        {
            return new Instalaciones
            {
                nombreInstalacion = instalacionModel.nombreInstalacion,
                Horarios = instalacionModel.Instalaciones.Select( i => i.ToHorariosDto()).ToList();
            }
        }

          public static Instalaciones ToInstalacionFromUpdate (this Instalaciones InstalacionModel)
        {
            return new Instalaciones
            {
                Id = instalacionModel.Id,
                nombreInstalacion = instalacionModel.nombreInstalacion,
                Horarios = instalacionModel.Instalaciones.Select( i => i.ToHorariosDto()).ToList();
            }
        }

    }
}