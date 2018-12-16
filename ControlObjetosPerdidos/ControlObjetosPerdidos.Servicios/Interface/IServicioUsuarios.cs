using ControlObjetosPerdidos.MensajeServicios.TiposComunes;
using ControlObjetosPerdidos.MensajeServicios.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ControlObjetosPerdidos.Servicios.Interface
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioUsuarios" in both code and config file together.
    [ServiceContract]
    public interface IServicioUsuarios
    {
        [OperationContract]
        RespuestaServicio InsertarUsuario(PeticionUsuario peticionUsuario);

        [OperationContract]
        RespuestaServicio ActualizarRol(PeticionUsuario peticionUsuario);

        [OperationContract]
        RespuestaServicio ActualizarEstado(PeticionUsuario peticionUsuario);

        [OperationContract]
        RespuestaServicio EchoTest(string prueba);

    }
}
