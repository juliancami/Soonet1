using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Soonet.Data;
using Soonet.Models;

namespace Soonet.Controllers
{
    public class ProveedorController : Controller
    {
        private readonly AppDbContext _context;
        public ProveedorController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var modelo = await _context.ProveedorServicios.ToListAsync();

            return View(modelo);
        }
        public async Task<IActionResult> Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear(ProveedorServicios modelo)
        {
            if (!ModelState.IsValid)
                return View(modelo);

            await _context.ProveedorServicios.AddAsync(modelo);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Eliminar(int? id)
        {
            if (id is null)
                return RedirectToAction(nameof(Index));

            if (!await _context.ProveedorServicios.AnyAsync(x => x.ID == id))
                return RedirectToAction(nameof(Index));

            var modelo = await _context.ProveedorServicios.FirstAsync(x => x.ID == id);

            return View(modelo);
        }

        [HttpPost]
        public async Task<IActionResult> Eliminar(ProveedorServicios modelo)
        {
            _context.ProveedorServicios.Remove(modelo);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detalles(int? id)
        {
            if (id is null)
                return RedirectToAction(nameof(Index));

            if (!await _context.ProveedorServicios.AnyAsync(x => x.ID == id))
                return RedirectToAction(nameof(Index));

            var modelo = await _context.ProveedorServicios.FirstAsync(x => x.ID == id);

            return View(modelo);
        }

        public async Task<IActionResult> Editar(int? id)
        {
            if (id is null)
                return RedirectToAction(nameof(Index));

            if (!await _context.ProveedorServicios.AnyAsync(x => x.ID == id))
                return RedirectToAction(nameof(Index));

            var modelo = await _context.ProveedorServicios.FirstAsync(x => x.ID == id);

            return View(modelo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(ProveedorServicios modelo)
        {
            if(!ModelState.IsValid)
                return View(modelo);

            _context.ProveedorServicios.Update(modelo);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
