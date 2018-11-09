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
        public bool InsertarUsuario(TUsuario usuario)
        {
            bool result = false;

            using(DataBaseModel context = new DataBaseModel())
            {
                context.TUsuario.Add(usuario);
                context.SaveChanges();
            }

            return result;
        }
    }
}
