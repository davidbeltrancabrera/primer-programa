using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.DynamicData;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace PuntoDeEncuentro.Models
{
    [MetadataType(typeof(itbevento))]
    public partial class tbevento
    {
        public void prueba()
        {  
        }
    }
    public interface itbevento {
        [Required] //debe tener algo de informacion
         object estado { get; set; }
        [MinLength(2)]
        object titulo { get; set; }

        [Key]
        object idevento { get; set; }
    }
}