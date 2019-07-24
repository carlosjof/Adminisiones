using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Admisiones.Models;
using Admisiones.Data;

namespace Admisiones.Controllers
{
    public class PerfilUsuariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PerfilUsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PerfilUsuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.PerfilUsuarios.ToListAsync());
        }

        // GET: PerfilUsuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perfilUsuario = await _context.PerfilUsuarios
                .FirstOrDefaultAsync(m => m.PerfilusuarioId == id);
            if (perfilUsuario == null)
            {
                return NotFound();
            }

            return View(perfilUsuario);
        }

        // GET: PerfilUsuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PerfilUsuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PerfilusuarioId,PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,FechaNacimiento,LugarNacimiento,Genero,EstadoCivil,CorreoPrimario,CorreoSecundario,TipoIdentificacion,NumeroIdentificacion,Celular,TelefonoPrimario,TelefonoSecundario,Contrasena")] PerfilUsuario perfilUsuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(perfilUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(perfilUsuario);
        }

        // GET: PerfilUsuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perfilUsuario = await _context.PerfilUsuarios.FindAsync(id);
            if (perfilUsuario == null)
            {
                return NotFound();
            }
            return View(perfilUsuario);
        }

        // POST: PerfilUsuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PerfilusuarioId,PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,FechaNacimiento,LugarNacimiento,Genero,EstadoCivil,CorreoPrimario,CorreoSecundario,TipoIdentificacion,NumeroIdentificacion,Celular,TelefonoPrimario,TelefonoSecundario,Contrasena")] PerfilUsuario perfilUsuario)
        {
            if (id != perfilUsuario.PerfilusuarioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(perfilUsuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PerfilUsuarioExists(perfilUsuario.PerfilusuarioId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(perfilUsuario);
        }

        // GET: PerfilUsuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perfilUsuario = await _context.PerfilUsuarios
                .FirstOrDefaultAsync(m => m.PerfilusuarioId == id);
            if (perfilUsuario == null)
            {
                return NotFound();
            }

            return View(perfilUsuario);
        }

        // POST: PerfilUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var perfilUsuario = await _context.PerfilUsuarios.FindAsync(id);
            _context.PerfilUsuarios.Remove(perfilUsuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PerfilUsuarioExists(int id)
        {
            return _context.PerfilUsuarios.Any(e => e.PerfilusuarioId == id);
        }
    }
}
