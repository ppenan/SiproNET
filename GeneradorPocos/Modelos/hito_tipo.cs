namespace GeneradorPocos.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sipro.hito_tipo")]
    public partial class hito_tipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hito_tipo()
        {
            hito = new HashSet<hito>();
        }

        public int id { get; set; }

        [StringLength(1000)]
        public string nombre { get; set; }

        [StringLength(4000)]
        public string descripcion { get; set; }

        public int estado { get; set; }

        public int dato_tipoid { get; set; }

        [Required]
        [StringLength(30)]
        public string usuario_creo { get; set; }

        [StringLength(30)]
        public string usuario_actualizacion { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime fecha_creacion { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? fecha_actualizacion { get; set; }

        public virtual dato_tipo dato_tipo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hito> hito { get; set; }
    }
}
