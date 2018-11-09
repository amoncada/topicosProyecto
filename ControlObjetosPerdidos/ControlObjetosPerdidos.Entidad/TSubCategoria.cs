namespace ControlObjetosPerdidos.Entidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TSubCategoria")]
    public partial class TSubCategoria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSubCategoria()
        {
            TArticulo = new HashSet<TArticulo>();
        }

        [Key]
        public int IdSubCategoria { get; set; }

        public int IdCategoria { get; set; }

        [Required]
        [StringLength(60)]
        public string Nombre { get; set; }

        [StringLength(60)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TArticulo> TArticulo { get; set; }

        public virtual TCategoria TCategoria { get; set; }
    }
}
