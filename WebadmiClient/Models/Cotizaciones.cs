using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebadmiClient.Models
{
    public class Cotizaciones
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string ClienteNombre { get; set; }
        [Required]
        [StringLength(50)]
        public string ClienteDireccion { get; set; }
        
        public DateTime Fecha { get; set; }
        [Required]
        public decimal Total { get; set; }
       







    }
}