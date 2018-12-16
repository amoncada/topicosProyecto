namespace ControlObjetorPerdidos.Topicos.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TContacto")]
    public partial class TContacto
    {
        [Key]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellido { get; set; }

        [StringLength(100)]
        public string Cedula { get; set; }

        [StringLength(100)]
        public string Telefono { get; set; }
    }
}
