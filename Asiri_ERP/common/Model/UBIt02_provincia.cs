//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace common.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class UBIt02_provincia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UBIt02_provincia()
        {
            this.UBIt01_distrito = new HashSet<UBIt01_distrito>();
        }
    
        public int idProvincia { get; set; }
        public string nombreProvincia { get; set; }
        public bool activo { get; set; }
        public System.DateTime fecRegistro { get; set; }
        public Nullable<System.DateTime> fecModificacion { get; set; }
        public Nullable<System.DateTime> fecEliminacion { get; set; }
        public string idUsuario { get; set; }
        public string idUsuarioModificar { get; set; }
        public string idUsuarioEliminar { get; set; }
        public int idRegion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UBIt01_distrito> UBIt01_distrito { get; set; }
        public virtual UBIt03_region UBIt03_region { get; set; }
    }
}
