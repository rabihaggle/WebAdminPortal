using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAdminPortal.DBContext;
using WebAdminPortal.Models;

namespace WebAdminPortal.Controllers
{
    public class UsuarioInformeController : Controller
    {
        private readonly PRE_ALTIUS_00_INTERMEDIAContext _context;

        public UsuarioInformeController(PRE_ALTIUS_00_INTERMEDIAContext context)
        {
            _context = context;
        }

        // GET: UsuarioInforme
        public async Task<IActionResult> Index()
        {
            var pRE_ALTIUS_00_INTERMEDIAContext = _context._80UsuarioInformes.Include(_ => _.IdInformeNavigation);
            return View(await pRE_ALTIUS_00_INTERMEDIAContext.ToListAsync());
        }

        // GET: UsuarioInforme/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context._80UsuarioInformes == null)
            {
                return NotFound();
            }

            var _80UsuarioInforme = await _context._80UsuarioInformes
                .Include(_ => _.IdInformeNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (_80UsuarioInforme == null)
            {
                return NotFound();
            }

            return View(_80UsuarioInforme);
        }

        // GET: UsuarioInforme/Create
        public IActionResult Create()
        {
            ViewData["IdInforme"] = new SelectList(_context._90InformesParametros, "IdInforme", "NombreInforme");
            return View();
        }

        // POST: UsuarioInforme/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Email,IdInforme,Activo,UsuarioRelacion")] _80UsuarioInforme _80UsuarioInforme)
        {
            if (ModelState.IsValid)
            {
                _context.Add(_80UsuarioInforme);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdInforme"] = new SelectList(_context._90InformesParametros, "IdInforme", "NombreInforme", _80UsuarioInforme.IdInforme);
            return View(_80UsuarioInforme);
        }

        // GET: UsuarioInforme/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context._80UsuarioInformes == null)
            {
                return NotFound();
            }

            var _80UsuarioInforme = await _context._80UsuarioInformes.FindAsync(id);
            if (_80UsuarioInforme == null)
            {
                return NotFound();
            }
            ViewData["IdInforme"] = new SelectList(_context._90InformesParametros, "IdInforme", "NombreInforme", _80UsuarioInforme.IdInforme);
            return View(_80UsuarioInforme);
        }

        // POST: UsuarioInforme/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Email,IdInforme,Activo,UsuarioRelacion")] _80UsuarioInforme _80UsuarioInforme)
        {
            if (id != _80UsuarioInforme.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(_80UsuarioInforme);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_80UsuarioInformeExists(_80UsuarioInforme.Id))
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
            ViewData["IdInforme"] = new SelectList(_context._90InformesParametros, "IdInforme", "NombreInforme", _80UsuarioInforme.IdInforme);
            return View(_80UsuarioInforme);
        }

        // GET: UsuarioInforme/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context._80UsuarioInformes == null)
            {
                return NotFound();
            }

            var _80UsuarioInforme = await _context._80UsuarioInformes
                .Include(_ => _.IdInformeNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (_80UsuarioInforme == null)
            {
                return NotFound();
            }

            return View(_80UsuarioInforme);
        }

        // POST: UsuarioInforme/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context._80UsuarioInformes == null)
            {
                return Problem("Entity set 'PRE_ALTIUS_00_INTERMEDIAContext._80UsuarioInformes'  is null.");
            }
            var _80UsuarioInforme = await _context._80UsuarioInformes.FindAsync(id);
            if (_80UsuarioInforme != null)
            {
                _context._80UsuarioInformes.Remove(_80UsuarioInforme);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool _80UsuarioInformeExists(int id)
        {
          return _context._80UsuarioInformes.Any(e => e.Id == id);
        }
    }
}
