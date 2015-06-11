﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PuntoDeEncuentro.Models
{
    [MetadataType(typeof(tblugar))]
    public partial class tblugar
    {
    }
    public interface tblugar
    {
        [Required]
        [Key]
        object idvoto { get; set; }
        [Required]
        object titulo { get; set; }
        [Required]
        [RegularExpression("[0-9]", ErrorMessage = "Error")]
        object num_votes { get; set; }
        [Required]
        [RegularExpression("[0-9]", ErrorMessage = "Error")]
        object total_score { get; set; }
        [Required]
        object rating { get; set; }
        [Required]
        [RegularExpression("[0-9]", ErrorMessage = "Error")]
        object id { get; set; }
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