using ControlObjetorPerdidos.Entidad;
using ControlObjetosPerdidos.Data.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlObjetosPerdidos.Data.Repositorio
{
    public class ArticuloRepositorio
    {
        
        public bool RegistrarArticulo(TArticulo articulo, TContacto contacto = null)
        {
            bool resultado = false;

            using(DataBaseModel context = new DataBaseModel())
            {
                if(contacto!= null)
                {
                    var email = (from c in context.TContacto where c.Email.Equals(contacto.Email) select c.Email).FirstOrDefault();
                    if (!string.IsNullOrEmpty(email))
                    {
                        articulo.Email = email;
                    }
                    else
                    {
                        articulo.TContacto = contacto;
                        context.TArticulo.Add(articulo);
                        resultado = context.SaveChanges() > 0 ? true : false;
                    }
                }
            }

            return resultado;
        }

        public List<TArticulo> GetArticulos()
        {
            List<TArticulo> articulos = new List<TArticulo>();



            return articulos;
        }
    }
}
