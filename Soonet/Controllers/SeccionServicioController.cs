using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Soonet.Data;
using Soonet.Models;

namespace Soonet.Controllers
{
    public class SecciónServicioController : Controller
    {
        private readonly AppDbContext _context;
        public SecciónServicioController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var modelo = await _context.SeccionServicio.ToListAsync();

            return View(modelo);
        }
        // GET: SeccionServicioController1/Details/5
        public async Task<IActionResult> Detalles(int? id)
        {
            if (id is null)
                return RedirectToAction(nameof(Index));

            if (!await _context.SeccionServicio.AnyAsync(x => x.ID == id))
                return RedirectToAction(nameof(Index));

            var modelo = await _context.SeccionServicio.FirstAsync(x => x.ID == id);

            return View(modelo);
        }

        // GET: SeccionServicioController1/Create
        public ActionResult Crear()
        {
            return View();
        }

        // POST: SeccionServicioController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear(SeccionServicio modelo)
        {
            if (!ModelState.IsValid)
                return View(modelo);

            await _context.SeccionServicio.AddAsync(modelo);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        // GET: SeccionServicioController1/Edit/5
        public async Task<IActionResult> Editar(int? id)
        {
            if (id is null)
                return RedirectToAction(nameof(Index));

            if (!await _context.SeccionServicio.AnyAsync(x => x.ID == id))
                return RedirectToAction(nameof(Index));

            var modelo = await _context.SeccionServicio.FirstAsync(x => x.ID == id);

            return View(modelo);
        }

        // POST: SeccionServicioController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(SeccionServicio modelo)
        {
            if (!ModelState.IsValid)
                return View(modelo);

            _context.SeccionServicio.Update(modelo);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // GET: SeccionServicioController1/Delete/5
        public async Task<IActionResult> Eliminar(int? id)
        {
            if (id is null)
                return RedirectToAction(nameof(Index));

            if (!await _context.SeccionServicio.AnyAsync(x => x.ID == id))
                return RedirectToAction(nameof(Index));

            var modelo = await _context.SeccionServicio.FirstAsync(x => x.ID == id);

            return View(modelo);
        }

        // POST: SeccionServicioController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Eliminar(SeccionServicio modelo)
        {
            _context.SeccionServicio.Remove(modelo);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
