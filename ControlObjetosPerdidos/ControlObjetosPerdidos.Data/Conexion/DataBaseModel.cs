namespace ControlObjetosPerdidos.Data.Conexion
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using ControlObjetosPerdidos.Entidad;
    using System.Text;
    using System.Configuration;

    internal partial class DataBaseModel : DbContext
    {
        #region Constructor

        /// <summary>
        /// Constructor default
        /// </summary>
        public DataBaseModel()
        {
            this.Database.Connection.ConnectionString = CreateConnectionString();
            this.Configuration.LazyLoadingEnabled = false;
            this.Database.Connection.Open();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Propiedad DataSet de la Tabla TArticulo
        /// </summary>
        internal virtual DbSet<TArticulo> TArticulo { get; set; }

        /// <summary>
        /// Propiedad DataSet de la Tabla TCategoria
        /// </summary>
        internal virtual DbSet<TCategoria> TCategoria { get; set; }

        /// <summary>
        /// Propiedad DataSet de la Tabla TReporteArticuloPerdido
        /// </summary>
        internal virtual DbSet<TReporteArticuloPerdido> TReporteArticuloPerdido { get; set; }

        /// <summary>
        /// Propiedad DataSet de la Tabla TRolUsuario
        /// </summary>
        internal virtual DbSet<TRolUsuario> TRolUsuario { get; set; }

        /// <summary>
        /// Propiedad DataSet de la Tabla TSubCategoria
        /// </summary>
        internal virtual DbSet<TSubCategoria> TSubCategoria { get; set; }

        /// <summary>
        /// Propiedad DataSet de la Tabla TUsuario
        /// </summary>
        internal virtual DbSet<TUsuario> TUsuario { get; set; }

        #endregion

        #region Methods

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TCategoria>()
                .HasMany(e => e.TSubCategoria)
                .WithRequired(e => e.TCategoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRolUsuario>()
                .HasMany(e => e.TUsuario)
                .WithRequired(e => e.TRolUsuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TSubCategoria>()
                .HasMany(e => e.TArticulo)
                .WithRequired(e => e.TSubCategoria)
                .WillCascadeOnDelete(false);
        }

        private string CreateConnectionString()
        {
            StringBuilder connectionString = new StringBuilder();
            connectionString.AppendFormat("Server={0}; ", ConfigurationManager.AppSettings["PrimaryServer"], true);
            connectionString.AppendFormat("Database={0};", ConfigurationManager.AppSettings["PrimaryDataBase"], true);
            connectionString.Append("integrated security=True;");
            connectionString.Append("MultipleActiveResultSets=True;");
            connectionString.Append("Connect Timeout=30;");
            connectionString.Append("Encrypt=False;");
            connectionString.Append("TrustServerCertificate=True;");
            connectionString.Append("ApplicationIntent=ReadWrite;");
            connectionString.Append("MultiSubnetFailover=False;App=EntityFramework");
            return connectionString.ToString();
        }

        #endregion
    }
}
