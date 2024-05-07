using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Soonet.Data;
using Soonet.Models;

namespace Soonet.Controllers
{
    public class ServicioController : Controller
    {

        private readonly AppDbContext _context;
        public ServicioController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var modelo = await _context.Servicio.ToListAsync();

            return View(modelo);
        }

        // GET: ServicioController/Details/5
        public async Task<IActionResult> Detalles(int? id)
        {
            if (id is null)
                return RedirectToAction(nameof(Index));

            if (!await _context.Servicio.AnyAsync(x => x.Id == id))
                return RedirectToAction(nameof(Index));

            var modelo = await _context.Servicio.FirstAsync(x => x.Id == id);

            return View(modelo);
        }


        // GET: ServicioController/Create
        public ActionResult Crear()
        {
            return View();
        }

        // POST: ServicioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear(Servicio modelo)
        {
            if (!ModelState.IsValid)
                return View(modelo);

            await _context.Servicio.AddAsync(modelo);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // GET: ServicioController/Edit/5
        public async Task<IActionResult> Editar(int? id)
        {
            if (id is null)
                return RedirectToAction(nameof(Index));

            if (!await _context.Servicio.AnyAsync(x => x.Id == id))
                return RedirectToAction(nameof(Index));

            var modelo = await _context.Servicio.FirstAsync(x => x.Id == id);

            return View(modelo);
        }

        // POST: ServicioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(Servicio modelo)
        {
            if (!ModelState.IsValid)
                return View(modelo);

            _context.Servicio.Update(modelo);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // GET: ServicioController/Delete/5
        public async Task<IActionResult> Eliminar(int? id)
        {
            if (id is null)
                return RedirectToAction(nameof(Index));

            if (!await _context.Servicio.AnyAsync(x => x.Id == id))
                return RedirectToAction(nameof(Index));

            var modelo = await _context.Servicio.FirstAsync(x => x.Id == id);

            return View(modelo);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Eliminar(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
