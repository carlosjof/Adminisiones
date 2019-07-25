using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admisiones.Data;
using Admisiones.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Admisiones.Controllers
{
    public class RegistrousuarioController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegistrousuarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/registroadmision")]
        public ActionResult PerfilUsuario()
        {

            var _provincia = _context.Provincia.ToList();

            ViewBag.Provincia = new SelectList(_provincia, "ProvinciaId", "Nombre");

            return View();
        }

        [HttpPost]
        [Route("/registroadmision")]
        public ActionResult PerfilUsuario(PerfilUsuarioVM perfilUsuarioVM)
        {
            bool cedula = _context.PerfilUsuarios.Where(nCed => nCed.NumeroIdentificacion.Equals(perfilUsuarioVM.PerfilUsuario.NumeroIdentificacion)).Any();

            if (!cedula)
            {
                PerfilUsuario prfUsr = new PerfilUsuario();
                prfUsr.PrimerNombre = perfilUsuarioVM.PerfilUsuario.PrimerNombre;
                prfUsr.SegundoNombre = perfilUsuarioVM.PerfilUsuario.SegundoNombre;
                prfUsr.PrimerApellido = perfilUsuarioVM.PerfilUsuario.PrimerApellido;
                prfUsr.SegundoApellido = perfilUsuarioVM.PerfilUsuario.SegundoApellido;
                prfUsr.FechaNacimiento = perfilUsuarioVM.PerfilUsuario.FechaNacimiento;
                prfUsr.LugarNacimiento = perfilUsuarioVM.PerfilUsuario.LugarNacimiento;
                prfUsr.Genero = perfilUsuarioVM.PerfilUsuario.Genero;
                prfUsr.EstadoCivil = perfilUsuarioVM.PerfilUsuario.EstadoCivil;
                prfUsr.CorreoPrimario = perfilUsuarioVM.PerfilUsuario.CorreoPrimario;
                prfUsr.CorreoSecundario = perfilUsuarioVM.PerfilUsuario.CorreoSecundario;
                prfUsr.TipoIdentificacion = perfilUsuarioVM.PerfilUsuario.TipoIdentificacion;
                prfUsr.NumeroIdentificacion = perfilUsuarioVM.PerfilUsuario.NumeroIdentificacion;
                prfUsr.Celular = perfilUsuarioVM.PerfilUsuario.Celular;
                prfUsr.TelefonoPrimario = perfilUsuarioVM.PerfilUsuario.TelefonoPrimario;
                prfUsr.TelefonoSecundario = perfilUsuarioVM.PerfilUsuario.TelefonoSecundario;
                prfUsr.Contrasena = perfilUsuarioVM.PerfilUsuario.Contrasena;
                _context.Add(prfUsr);
                _context.SaveChanges();

                Direccion dir = new Direccion();
                dir.PerfilusuarioId = prfUsr.PerfilusuarioId;
                dir.PaisOrigen = perfilUsuarioVM.Direccion.PaisOrigen;
                dir.Residencial = perfilUsuarioVM.Direccion.Residencial;
                dir.Descripcion = perfilUsuarioVM.Direccion.Descripcion;
                dir.Numero = perfilUsuarioVM.Direccion.Numero;
                _context.Add(dir);
                _context.SaveChanges();

                Provincia prv = new Provincia();
                prv.DireccionId = dir.DireccionId;
                prv.Nombre = perfilUsuarioVM.Provincia.Nombre;
                _context.Add(prv);
                _context.SaveChanges();

                Sector sctr = new Sector();
                sctr.ProvinciaId = prv.ProvinciaId;
                sctr.Nombre = perfilUsuarioVM.Sector.Nombre;
                _context.Add(sctr);
                _context.SaveChanges();

                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                msg.To.Add(prfUsr.CorreoPrimario);
                msg.Subject = "Bienvenido al proceso de matriculacion UNAPEC";
                msg.SubjectEncoding = System.Text.Encoding.UTF8;
                msg.Body = "Bienvenido " + prfUsr.PrimerNombre + " " + prfUsr.SegundoNombre;
                msg.BodyEncoding = System.Text.Encoding.UTF8;
                msg.From = new System.Net.Mail.MailAddress(prfUsr.CorreoPrimario);

                System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
                client.Credentials = new System.Net.NetworkCredential("CORREO DE QUIEN LO ENVIA", "CONTRASENA");

                client.Port = 587;
                client.EnableSsl = true;

                client.Host = "smtp.gmail.com";

                try
                {
                    client.Send(msg);
                }
                catch (Exception)
                {

                    throw;
                }

                return View();
            }
            else
            {

                ViewBag.Nombre = "Existe";
                return View();

            }
        }

        public JsonResult Sectores(int provincia)
        {
            var _sectores = new SelectList(_context.Sector.Where(s => s.ProvinciaId.Equals(provincia)).ToList(), "SectorId", "Nombre");

            return Json(_sectores);
        }



        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}