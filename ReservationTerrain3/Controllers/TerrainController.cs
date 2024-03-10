using BLL;
using DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.Terrain;

namespace ReservationTerrain3.Controllers
{
    [Authorize]
    public class TerrainController : Controller
    {
        public readonly MyDbContext _context;

        public TerrainController(MyDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var terrains = _context.Terrains.ToList();
            return View(terrains);
        }
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TerrainController/Create
        public ActionResult Create()
        {
            


            return View();
        }

        // POST: TerrainController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AdminTerrainAjouter model)
        {



            try
            {
                TerrainService service = new TerrainService();
                service.Create(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TerrainController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TerrainController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: TerrainController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TerrainController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
