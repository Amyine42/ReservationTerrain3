using Microsoft.AspNetCore.Mvc;
using BLL;
using Models.Utilisateur;
using Microsoft.AspNetCore.Authorization;

namespace ReservationTerrain3.Controllers
{
    
    public class UtilisateurController : Controller
    {
        public IActionResult Index()
        {
            UtilisateurService utilisateurService= new UtilisateurService();
            return View(utilisateurService.GetListUtilisateur());
        }
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientController/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AdminCreateUtilisateur model)
        {
            try
            {
                UtilisateurService UtilisateurService = new UtilisateurService();
                UtilisateurService.AjouterUtilisateur(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientController/Edit/5
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

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientController/Delete/5
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