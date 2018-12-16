namespace ControlObjetorPerdidos.Topicos.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TArticuloImagen")]
    public partial class TArticuloImagen
    {
        [Key]
        public int IdImagen { get; set; }

        public int? IdArticulo { get; set; }

        public byte[] Imagen { get; set; }
    }
}
