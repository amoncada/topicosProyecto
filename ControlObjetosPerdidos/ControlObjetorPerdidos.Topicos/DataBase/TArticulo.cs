namespace ControlObjetorPerdidos.Topicos.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TArticulo")]
    public partial class TArticulo
    {
        [Key]
        public int IdArticulo { get; set; }

        public int IdSubCategoria { get; set; }

        [Required]
        [StringLength(100)]
        public string Marca { get; set; }

        [Required]
        [StringLength(100)]
        public string Modelo { get; set; }

        [Required]
        [StringLength(6)]
        public string Color { get; set; }

        public DateTime FechaExtravio { get; set; }

        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(60)]
        public string Estado { get; set; }

        public virtual TSubCategoria TSubCategoria { get; set; }
    }
}
