using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using WebAdminPortal.Models;
using WebAdminPortal.Models.ViewModels;

namespace WebAdminPortal.Controllers
{
    public class InformesController : Controller
    {

        private readonly PRE_ALTIUS_00_INTERMEDIAContext _context;

        public InformesController(PRE_ALTIUS_00_INTERMEDIAContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            return View(await _context._90InformesParametros.ToListAsync());

        }

        public IActionResult Create()
        {

            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(InformesViewModels model)
        {
            if (ModelState.IsValid) 
            {

                var inf = new _90InformesParametro() { 
                
                    NombreInforme = model.NombreInforme,
                    TipoInforme=model.TipoInforme,
                    Observaciones=model.Observaciones                    
                
                };
                _context.Add(inf);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);

        }

    }
}
