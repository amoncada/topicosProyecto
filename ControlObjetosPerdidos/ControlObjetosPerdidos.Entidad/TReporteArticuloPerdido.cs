namespace ControlObjetosPerdidos.Entidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TReporteArticuloPerdido")]
    public partial class TReporteArticuloPerdido
    {
        [Key]
        public int IdReporte { get; set; }

        [Required]
        [StringLength(250)]
        public string Caracteristicas { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(10)]
        public string Telefono { get; set; }

        [StringLength(100)]
        public string Correo { get; set; }
    }
}
