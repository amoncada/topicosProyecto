using ControlObjetosPerdidos.MensajeServicios.TiposComunes;
using ControlObjetosPerdidos.MensajeServicios.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlObjetosPerdidos.Logica
{
    public class Acciones
    {
        #region Variables
        private AdministrarUsuarios _administrarUsuarios = null;
        #endregion

        #region Methods
        public RespuestaServicio InsertarUsuario(PeticionUsuario peticionUsuario)
        {
            var result = _administrarUsuarios.InsertarUsuario(peticionUsuario);
            return result;
        }
        #endregion

        #region Constructor
        public Acciones()
        {
            _administrarUsuarios = new AdministrarUsuarios();
        }
        #endregion
    }
}
