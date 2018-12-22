namespace ControlObjetorPerdidos.Entidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TArticuloImagen")]
    public partial class TArticuloImagen
    {
        private string _hexImagen = string.Empty;
        [Key]
        public int IdImagen { get; set; }

        public int? IdArticulo { get; set; }

        public byte[] Imagen { get; set; }

        [NotMapped]
        public string HexImagen
        { get
            {
                try
                {
                    if(Imagen != null)
                    {
                        if(Imagen.Length > 2)
                        {
                           _hexImagen = BitConverter.ToString(Imagen).Replace("-", "");
                        }
                    }
                }
                catch (Exception)
                {
                    
                }
                return _hexImagen;
            }
        }
    }
}
