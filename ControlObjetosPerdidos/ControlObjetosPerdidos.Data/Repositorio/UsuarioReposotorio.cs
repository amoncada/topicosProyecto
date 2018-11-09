using ControlObjetosPerdidos.Data.Conexion;
using ControlObjetosPerdidos.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlObjetosPerdidos.Data.Repositorio
{
    public class UsuarioReposotorio
    {
        #region Usuarios

        /// <summary>
        /// Inserta un usuario en la base de datos
        /// </summary>
        /// <param name="usuario">Usuario a insertar</param>
        /// <returns>True|False si el registro fue insertado</returns>
        public bool InsertarUsuario(TUsuario usuario)
        {
            bool result = false;

            using(DataBaseModel context = new DataBaseModel())
            {
                context.TUsuario.Add(usuario);
                result = context.SaveChanges() > 0 ? true : false;
            }

            return result;
        }

        /// <summary>
        /// Actualiza un usuario en la base de datos
        /// </summary>
        /// <param name="usuario">Usuario a actualizar</param>
        /// <returns>True|False si el registro fue actualizado</returns>
        public bool ActualizarRol(TUsuario usuario)
        {
            bool result = false;
            using (DataBaseModel context = new DataBaseModel())
            {
                var user = context.TUsuario.Where(u => u.IdUsuario.Equals(usuario.IdUsuario)).FirstOrDefault();
                user.IdRolUsuario = usuario.IdRolUsuario;
                result = context.SaveChanges() > 0 ? true : false;
            }
            return result;
        }

        /// <summary>
        /// Actualiza un usuario en la base de datos
        /// </summary>
        /// <param name="usuario">Usuario a actualizar</param>
        /// <returns>True|False si el registro fue actualizado</returns>
        public bool ActualizarEstado(TUsuario usuario)
        {
            bool result = false;
            using (DataBaseModel context = new DataBaseModel())
            {
                var user = context.TUsuario.Where(u => u.IdUsuario.Equals(usuario.IdUsuario)).FirstOrDefault();
                user.Estado = usuario.Estado;
                result = context.SaveChanges() > 0 ? true : false;
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<TUsuario> ConsultarUsuarios()
        {
            List<TUsuario> result = new List<TUsuario>();
            using (DataBaseModel context = new DataBaseModel())
            {
                result = context.TUsuario.ToList();
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public List<TUsuario> ConsultarUsuarioPorId(TUsuario usuario)
        {
            List<TUsuario> result = new List<TUsuario>();
            using (DataBaseModel context = new DataBaseModel())
            {
                result = context.TUsuario.Where(u => u.IdUsuario.Equals(usuario.IdUsuario)).ToList();
            }
            return result;
        }
        #endregion

    }
}
