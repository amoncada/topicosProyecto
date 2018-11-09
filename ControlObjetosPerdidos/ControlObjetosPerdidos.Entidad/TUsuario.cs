namespace ControlObjetosPerdidos.Entidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TUsuario")]
    public partial class TUsuario
    {
        [Key]
        [StringLength(100)]
        public string IdUsuario { get; set; }

        public int IdRolUsuario { get; set; }

        [StringLength(100)]
        public string Contrasena { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(10)]
        public string Telefono { get; set; }

        public virtual TRolUsuario TRolUsuario { get; set; }
    }
}
