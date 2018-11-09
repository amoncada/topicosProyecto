using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ControlObjetosPerdidos.MensajeServicios.TiposComunes
{
    [DataContract]
    public class RespuestaServicio
    {
        [DataMember(Order = 0)]
        public RespuestaServicioEncabezado Encabezado { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 1)]
        public RespuestaServicioContenido Contenido { get; set; }
    }

    [DataContract]
    public class RespuestaServicioEncabezado
    {
        [DataMember(Order = 0)]
        public StatusRespuesta Mensaje { get; set; }

        [DataMember(Order = 1)]
        public String Descripcion { get; set; }
    }

    [DataContract]
    public class RespuestaServicioContenido
    {

    }
}
