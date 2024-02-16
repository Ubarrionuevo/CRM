using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebadmiClient.Models
{
    public class MovimientoCuenta
    {
        

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int Fhmovimiento { get; set; }
        [Required]
        //debito negativo , credito positivo
        public decimal Importe { get; set; }
        [Required]
        [StringLength(150)]
        public string Descripcion { get; set; }
        public bool Activo { get; internal set; }
    }
}