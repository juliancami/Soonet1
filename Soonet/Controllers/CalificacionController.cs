using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Soonet.Data;

namespace Soonet.Controllers
{
    public class CalificacionController : Controller
    {
        private readonly AppDbContext _context;
        public CalificacionController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _context.Calificacion
                                        .Include(x => x.Usuario)
                                        .Include(x => x.ProveedorServicios)
                                        .ToListAsync();

            return View(model);
        }
        public async Task<IActionResult> Detalles(int? id)
        {
            if(id is null)
                return RedirectToAction(nameof(Index));

            if(!await _context.Calificacion.AnyAsync(x => x.ID == id))
                return RedirectToAction(nameof(Index));

            var modelo = await _context.Calificacion.FirstAsync(x => x.ID == id);

            return View(modelo);
        }

        public IActionResult Crear()
        {
            return View();
        }



    }
}
