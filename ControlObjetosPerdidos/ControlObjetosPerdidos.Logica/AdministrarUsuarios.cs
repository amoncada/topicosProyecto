using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlObjetosPerdidos.Data.Repositorio;
using ControlObjetosPerdidos.Entidad;
using ControlObjetosPerdidos.MensajeServicios.TiposComunes;
using ControlObjetosPerdidos.MensajeServicios.Usuario;

namespace ControlObjetosPerdidos.Logica
{
    internal class AdministrarUsuarios
    {
        #region Variables
        private UsuarioReposotorio _usuarioReposotorio = null;
        private AdministrarRepuestas _administrarRepuestas = null;
        #endregion

        #region Methods
        internal RespuestaServicio InsertarUsuario(PeticionUsuario peticionUsuario)
        {
            RespuestaServicio respuesta = new RespuestaServicio();
            try
            {
                TUsuario nuevoUsuario = new TUsuario()
                {
                    Apellidos = peticionUsuario.Apellidos,
                    Contrasena = peticionUsuario.Contrasena,
                    Estado = 1,
                    IdRolUsuario= peticionUsuario.IdRolUsuario,
                    IdUsuario = peticionUsuario.IdUsuario,
                    Nombre = peticionUsuario.Nombre,
                    Telefono = peticionUsuario.Telefono,
                };

                if (_usuarioReposotorio.InsertarUsuario(nuevoUsuario))
                {
                    respuesta = _administrarRepuestas.ConstruirRespuestaExitosa("El usuario fue creado correctamente.");
                }
                else
                {
                    respuesta = _administrarRepuestas.ConstruirRespuestaDeAlerta("El usuario no fue crado.");
                }
                
            }
            catch (Exception ex)
            {
                //Activar logs
                respuesta = _administrarRepuestas.ConstruirRespuestaDeError("Ocurrio un error al procesar la peticion.");
            }
            return respuesta;
        }
        #endregion

        #region Constructor

        internal AdministrarUsuarios()
        {
            _usuarioReposotorio = new UsuarioReposotorio();
            _administrarRepuestas = new AdministrarRepuestas();
        }
        #endregion
    }
}
