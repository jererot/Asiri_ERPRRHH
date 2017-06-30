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
    
    public partial class RHUt07_paciente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RHUt07_paciente()
        {
            this.CLlt05_cita = new HashSet<CLlt05_cita>();
            this.CLlt15_seguroPaciente = new HashSet<CLlt15_seguroPaciente>();
        }
    
        public long idPaciente { get; set; }
        public string codPaciente { get; set; }
        public string numHistoriaClinica { get; set; }
        public string grupoSanguineo { get; set; }
        public string activo { get; set; }
        public System.DateTime fecRegistro { get; set; }
        public Nullable<System.DateTime> fecModificacion { get; set; }
        public Nullable<System.DateTime> fecEliminacion { get; set; }
        public string idUsuario { get; set; }
        public string idUsuarioModificar { get; set; }
        public string idUsuarioEliminar { get; set; }
        public Nullable<long> idPersona { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLlt05_cita> CLlt05_cita { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLlt15_seguroPaciente> CLlt15_seguroPaciente { get; set; }
        public virtual RHUt09_persona RHUt09_persona { get; set; }
    }
}
