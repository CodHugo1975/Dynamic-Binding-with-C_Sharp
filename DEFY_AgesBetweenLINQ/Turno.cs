//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DEFY_AgesBetweenLINQ
{
    using System;
    using System.Collections.Generic;
    
    public partial class Turno
    {
        public int id { get; set; }
        public Nullable<System.DateTime> FechaDesde { get; set; }
        public Nullable<System.DateTime> FechaHasta { get; set; }
        public Nullable<int> idOrden { get; set; }
    
        public virtual Orden Orden { get; set; }
    }
}
