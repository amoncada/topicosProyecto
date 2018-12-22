namespace ControlObjetorPerdidos.Entidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TCategoria")]
    public partial class TCategoria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TCategoria()
        {
            TSubCategoria = new HashSet<TSubCategoria>();
        }

        [Key]
        public int IdCategoria { get; set; }

        [Required]
        [StringLength(160)]
        public string Nombre { get; set; }

        [StringLength(160)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSubCategoria> TSubCategoria { get; set; }
    }
}
