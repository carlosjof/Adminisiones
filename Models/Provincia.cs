using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Admisiones.Models
{
    public class Provincia
    {
        [Key]
        public int ProvinciaId { get; set; }

        [Display(Name = "Provincia*")]
        public string Nombre { get; set; }

        public int DireccionId { get; set; }

        [ForeignKey("DireccionId")]
        public Direccion Direccion { get; set; }

        public List<Sector> Sector { get; set; }
    }
}
