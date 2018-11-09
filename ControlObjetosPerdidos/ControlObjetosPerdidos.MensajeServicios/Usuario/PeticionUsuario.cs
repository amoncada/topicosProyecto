using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ControlObjetosPerdidos.MensajeServicios.Usuario
{
    [DataContract]
    public class PeticionUsuario
    {
        [DataMember(IsRequired =true)]
        public string IdUsuario { get; set; }

        [DataMember(IsRequired = false)]
        public int IdRolUsuario { get; set; }

        [DataMember(IsRequired = false)]
        public string Contrasena { get; set; }

        [DataMember(IsRequired = false)]
        public string Nombre { get; set; }

        [DataMember(IsRequired = false)]
        public string Apellidos { get; set; }

        [DataMember(IsRequired = false)]
        public string Telefono { get; set; }
    }
    
}
