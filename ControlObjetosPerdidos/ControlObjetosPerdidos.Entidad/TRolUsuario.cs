namespace ControlObjetosPerdidos.Entidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRolUsuario")]
    public partial class TRolUsuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRolUsuario()
        {
            TUsuario = new HashSet<TUsuario>();
        }

        [Key]
        public int IdRolUsuario { get; set; }

        [Required]
        [StringLength(60)]
        public string Nombre { get; set; }

        [StringLength(60)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TUsuario> TUsuario { get; set; }
    }
}
