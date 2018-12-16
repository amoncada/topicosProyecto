using ControlObjetosPerdidos.MensajeServicios.TiposComunes;
using ControlObjetosPerdidos.MensajeServicios.Usuario;
using ControlObjetosPerdidos.Servicios.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ControlObjetosPerdidos.Servicios.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioUsuarios" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicioUsuarios.svc or ServicioUsuarios.svc.cs at the Solution Explorer and start debugging.
    public class ServicioUsuarios : IServicioUsuarios
    {
        public RespuestaServicio ActualizarEstado(PeticionUsuario peticionUsuario)
        {
            throw new NotImplementedException();
        }

        public RespuestaServicio ActualizarRol(PeticionUsuario peticionUsuario)
        {
            throw new NotImplementedException();
        }

        public void DoWork()
        {
        }

        public RespuestaServicio InsertarUsuario(PeticionUsuario peticionUsuario)
        {
            throw new NotImplementedException();
        }

        public RespuestaServicio EchoTest(string prueba)
        {
            RespuestaServicio respuestaServicio = new RespuestaServicio()
            {
                Encabezado = new RespuestaServicioEncabezado()
                {
                    Mensaje = StatusRespuesta.Success,
                    Descripcion = "EchoTest exitoso"
                }
            };

            return respuestaServicio;
        }
    }
}
