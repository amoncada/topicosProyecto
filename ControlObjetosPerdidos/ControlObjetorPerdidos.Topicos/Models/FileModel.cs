using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControlObjetorPerdidos.Topicos.Models
{
    public class FileModel
    {
        [Display(Name = "Browse File")]
        public HttpPostedFileBase[] files { get; set; }

        [Display(Name = "Articulo")]
        public string  Articulo  { get; set; }

        public int IdArticulo { get; set; }

    }
}