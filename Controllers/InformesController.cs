using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using WebAdminPortal.Models;

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
        public IActionResult Create(int a)
        {

            return View();

        }

    }
}
