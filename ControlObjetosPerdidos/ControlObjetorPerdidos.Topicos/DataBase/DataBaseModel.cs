namespace ControlObjetorPerdidos.Topicos.DataBase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataBaseModel : DbContext
    {
        public DataBaseModel()
            : base("name=DataBaseModel")
        {
        }

        public virtual DbSet<TArticulo> TArticulo { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<TArticuloImagen> TArticuloImagen { get; set; }
        public virtual DbSet<TCategoria> TCategoria { get; set; }
        public virtual DbSet<TContacto> TContacto { get; set; }
        public virtual DbSet<TRegistros> TRegistros { get; set; }
        public virtual DbSet<TSubCategoria> TSubCategoria { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TCategoria>()
                .HasMany(e => e.TSubCategoria)
                .WithRequired(e => e.TCategoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TContacto>()
                .Property(e => e.rol)
                .IsUnicode(false);

            modelBuilder.Entity<TSubCategoria>()
                .HasMany(e => e.TArticulo)
                .WithRequired(e => e.TSubCategoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.RoleName)
                .IsUnicode(false);
        }
    }
}
