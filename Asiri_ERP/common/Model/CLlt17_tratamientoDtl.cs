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
    
    public partial class CLlt17_tratamientoDtl
    {
        public long idTratamientoDtl { get; set; }
        public bool esServicio { get; set; }
        public string indicacionServicio { get; set; }
        public long idTratamiento { get; set; }
        public long idProducto { get; set; }
        public long idServicio { get; set; }
    
        public virtual CLlt16_tratamiento CLlt16_tratamiento { get; set; }
        public virtual PROt02_producto PROt02_producto { get; set; }
        public virtual PROt04_servicio PROt04_servicio { get; set; }
    }
}
