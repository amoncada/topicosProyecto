using ControlObjetosPerdidos.MensajeServicios.TiposComunes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlObjetosPerdidos.Logica
{
    public class AdministrarRepuestas
    {
        #region Methdos
        public RespuestaServicio ConstruirRespuestaExitosa(string descripcion)
        {
            return new RespuestaServicio()
            {
                Encabezado = new RespuestaServicioEncabezado()
                {
                    Mensaje = StatusRespuesta.Success,
                    Descripcion = descripcion
                }
            };
        }

        public RespuestaServicio ConstruirRespuestaDeError(string descripcion)
        {
            return new RespuestaServicio()
            {
                Encabezado = new RespuestaServicioEncabezado()
                {
                    Mensaje = StatusRespuesta.Error,
                    Descripcion = descripcion
                }
            };
        }

        public RespuestaServicio ConstruirRespuestaDeAlerta(string descripcion)
        {
            return new RespuestaServicio()
            {
                Encabezado = new RespuestaServicioEncabezado()
                {
                    Mensaje = StatusRespuesta.Warning,
                    Descripcion = descripcion
                }
            };
        }
        #endregion

    }
}
