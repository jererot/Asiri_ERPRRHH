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
    
    public partial class CLlt13_funcionVital
    {
        public long idFuncionVital { get; set; }
        public string sistole { get; set; }
        public string diastole { get; set; }
        public string pulsacion { get; set; }
        public string ritmoRespiratorio { get; set; }
        public string temperatura { get; set; }
        public string altura { get; set; }
        public string peso { get; set; }
        public string imc { get; set; }
        public long idAtencion { get; set; }
    
        public virtual CLlt03_atencion CLlt03_atencion { get; set; }
    }
}
