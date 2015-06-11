using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PuntoDeEncuentro.Models
{
    [MetadataType(typeof(tbvotousuario))]
    public partial class tbvotousuario
    {
    }
    public interface tbvotousuario
    {
        [Required]
        [Key]
        object idvotousuario { get; set; }
        [Required]
        [RegularExpression("[0-9]",ErrorMessage="Error")]
        object idlugar { get; set; }
        [Required]
        [RegularExpression("[0-9]", ErrorMessage = "Error")]
        object iduser { get; set; }
        [Required]
        object scor { get; set; }
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