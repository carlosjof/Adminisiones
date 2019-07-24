using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admisiones.Models
{
    public class PerfilUsuario
    {
        [Key]
        public int PerfilusuarioId { get; set; }

        [Display(Name = "Primer Nombre*")]
        public string PrimerNombre { get; set; }

        [Display(Name = "Segundo Nombre")]
        public string SegundoNombre { get; set; }

        [Display(Name = "Primer Apellido*")]
        public string PrimerApellido { get; set; }

        [Display(Name = "Segundo Apellido")]
        public string SegundoApellido { get; set; }

        [Display(Name = "Fecha de Nacimiento*")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "Lugar de nacimiento*")]
        public string LugarNacimiento { get; set; }

        [Display(Name = "Genero*")]
        public string Genero { get; set; }

        [Display(Name = "Estado civil")]
        public string EstadoCivil { get; set; }

        [Display(Name = "Correo primario*")]
        [DataType(DataType.EmailAddress)]
        public string CorreoPrimario { get; set; }

        [Display(Name = "Correo secundario")]
        [DataType(DataType.EmailAddress)]
        public string CorreoSecundario { get; set; }

        [Display(Name = "Tipo de identificacion*")]
        public string TipoIdentificacion { get; set; }

        [Display(Name = "Numero de identificacion*")]
        public string NumeroIdentificacion { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Celular { get; set; }

        [Display(Name = "Telefono primario*")]
        [DataType(DataType.PhoneNumber)]
        public string TelefonoPrimario { get; set; }

        [Display(Name = "Telefono secundario")]
        [DataType(DataType.PhoneNumber)]
        public string TelefonoSecundario { get; set; }

        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Contrasena { get; set; }

        public List<Direccion> Direccions { get; set; }
    }
}
