using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admisiones.Data;
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

            var _provincia = _context.Provincia.ToList();

            ViewBag.Provincia = new SelectList(_provincia, "ProvinciaId", "Nombre");

            return View();
        }

        public JsonResult Sectores(int provincia)
        {
            var _sectores = new SelectList(_context.Provincia.Where(s => s.ProvinciaId.Equals(provincia)), "SectorId", "Nombre");

            return Json(_sectores);
        }



        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}