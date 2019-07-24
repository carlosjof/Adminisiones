using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admisiones.Models
{
    public class PerfilUsuarioVM
    {
        public Direccion Direccion { get; set; }
        public PerfilUsuario PerfilUsuario { get; set; }
        public Provincia Provincia { get; set; }
        public Sector Sector { get; set; }
    }
}
