using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PuntoDeEncuentro.Models
{
    [MetadataType(typeof(tbcatlugar))]
    public partial class tbcatlugar
    {
    }
    public interface tbcatlugar
    {
        [Required]
        [Key]
        object idcatlugares { get; set; }
        [Required]
        [RegularExpression("[0-9]", ErrorMessage = "Error")]
        object idcategorias { get; set; }
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