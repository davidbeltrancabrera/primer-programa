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
    
    public partial class tbpersona
    {
        public long idpersona { get; set; }
        public string nombre { get; set; }
        public string paterno { get; set; }
        public string materno { get; set; }
        public string ci { get; set; }
        public Nullable<System.DateTime> fechanac { get; set; }
        public System.DateTime fechacreacion { get; set; }
        public System.DateTime fechamodificacion { get; set; }
        public Nullable<int> estado { get; set; }
    
        public virtual tbusuario tbusuario { get; set; }
    }
}
