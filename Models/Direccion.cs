using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Admisiones.Models
{
    public class Direccion
    {
        [Key]
        public int DireccionId { get; set; }

        [Display(Name = "Pais de origen*")]
        public string PaisOrigen { get; set; }

        [Display(Name = "Residencial")]
        public string Residencial { get; set; }

        [Display(Name = "Direccion*")]
        public string Descripcion { get; set; }

        [Display(Name = "Numero*")]
        public int Numero { get; set; }

        public int PerfilusuarioId { get; set; }

        [ForeignKey("PerfilusuarioId")]
        public PerfilUsuario PerfilUsuario { get; set; }

        public List<Provincia> Provincia { get; set; }
    }
}
