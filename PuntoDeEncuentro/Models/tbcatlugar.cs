//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PuntoDeEncuentro.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbcatlugar
    {
        public int idcatlugares { get; set; }
        public Nullable<int> idcategorias { get; set; }
        public Nullable<int> idlugares { get; set; }
        public System.DateTime fechacreacion { get; set; }
        public System.DateTime fechamodificacion { get; set; }
        public Nullable<int> estado { get; set; }
    
        public virtual tb_categorias tb_categorias { get; set; }
        public virtual tblugares tblugares { get; set; }
    }
}
