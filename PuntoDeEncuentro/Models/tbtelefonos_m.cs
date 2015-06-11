using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PuntoDeEncuentro.Models
{
    [MetadataType(typeof(tbtelefonos))]
    public partial class tbtelefonos
    {
    }
    public interface tbtelefonos
    {
        [Required]
        [Key]
        object idtelefonos { get; set; }
        [Required]
        [RegularExpression("[0-9]", ErrorMessage = "Error")]
        object numero { get; set; }
        [Required]
        [RegularExpression("[0-9]", ErrorMessage = "Error")]
        object tipo { get; set; }
        [Required]
        [RegularExpression("[0-9]", ErrorMessage = "Error")]
        object codigoarea { get; set; }
        [Required]
        [RegularExpression("[0-9]", ErrorMessage = "Error")]
        object idlugares { get; set; }
        [Required]
        [DataType(DataType.Text, ErrorMessage = "error fecha")]
        object fechacreacion { get; set; }
        [Required]
        [DataType(DataType.Text, ErrorMessage = "error fecha")]
        object fechamodificacion { get; set; }
        [Required]
        object estado { get; set; }
    }
}