using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Admisiones.Models
{
    public class Sector
    {
        [Key]
        public int SectorId { get; set; }

        [Display(Name = "Sector*")]
        public string Nombre { get; set; }

        public int ProvinciaId { get; set; }

        [ForeignKey("ProvinciaId")]
        public Provincia Provincia { get; set; }
    }
}
