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
    
    public partial class SISt01_parametro
    {
        public int idParametro { get; set; }
        public string codParametro { get; set; }
        public string nombreParametro { get; set; }
        public string descParametro { get; set; }
        public string valorDeTexto { get; set; }
        public Nullable<decimal> valorNumerico { get; set; }
        public string valorTextoDefault { get; set; }
        public Nullable<decimal> valorNumericoDefault { get; set; }
        public Nullable<System.DateTime> fecModificacion { get; set; }
        public string idUsuarioModificar { get; set; }
    }
}
