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
    
    public partial class SNTt03_moneda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SNTt03_moneda()
        {
            this.PROt02_producto = new HashSet<PROt02_producto>();
            this.TNSt06_medioDePagoDtl = new HashSet<TNSt06_medioDePagoDtl>();
            this.TNSt01_comprobanteEmitido = new HashSet<TNSt01_comprobanteEmitido>();
        }
    
        public int idMoneda { get; set; }
        public string codMoneda { get; set; }
        public string codIsoMoneda { get; set; }
        public string codIsoNumMoneda { get; set; }
        public string descMoneda { get; set; }
        public string abrvMoneda { get; set; }
        public string simbolo { get; set; }
        public byte decimalCambio { get; set; }
        public string fraccion { get; set; }
        public bool activo { get; set; }
        public System.DateTime fecRegistro { get; set; }
        public Nullable<System.DateTime> fecModificacion { get; set; }
        public Nullable<System.DateTime> fecEliminacion { get; set; }
        public string idUsuario { get; set; }
        public string idUsuarioModificar { get; set; }
        public string idUsuarioEliminar { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROt02_producto> PROt02_producto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt06_medioDePagoDtl> TNSt06_medioDePagoDtl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt01_comprobanteEmitido> TNSt01_comprobanteEmitido { get; set; }
    }
}
