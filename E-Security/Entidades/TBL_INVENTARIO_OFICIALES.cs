//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_INVENTARIO_OFICIALES
    {
        public int ID_INVENTARIO_OFICIAL { get; set; }
        public int ID_INVENTARIO { get; set; }
        public int ID_OFICIAL { get; set; }
    
        public virtual TBL_INVENTARIO TBL_INVENTARIO { get; set; }
        public virtual TBL_OFICIALES TBL_OFICIALES { get; set; }
    }
}