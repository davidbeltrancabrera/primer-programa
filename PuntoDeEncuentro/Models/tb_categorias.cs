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
    
    public partial class tb_categorias
    {
        public tb_categorias()
        {
            this.tbcatlugar = new HashSet<tbcatlugar>();
        }
    
        public int idcategorias { get; set; }
        public string nombre { get; set; }
        public Nullable<int> responsable { get; set; }
        public Nullable<int> padre { get; set; }
        public System.DateTime fechacreacion { get; set; }
        public System.DateTime fechamodificacion { get; set; }
        public Nullable<int> estado { get; set; }
    
        public virtual ICollection<tbcatlugar> tbcatlugar { get; set; }
    }
}