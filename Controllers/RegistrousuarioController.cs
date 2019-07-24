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

        [Route("/registroadmision")]
        public ActionResult PerfilUsuario() {

            //var _provincia = _context.Provincia.ToList();

            //ViewBag.Provincia = new SelectList(_provincia, "ProvinciaId", "Nombre");

            return View();
        }

        [HttpPost]
        public ActionResult PerfilUsuario(PerfilUsuarioVM _perfilUsuarioVM)
        {

            return View();
        }

            public JsonResult Sectores(int provincia)
        {
            //var _sectores = new SelectList(_context.Provincia.Where(s => s.ProvinciaId.Equals(provincia)), "SectorId", "Nombre");
            var _sectores = "";
            return Json(_sectores);
        }



        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}