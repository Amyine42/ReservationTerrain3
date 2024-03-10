using Microsoft.AspNetCore.Mvc;
using BLL;
using Models.Utilisateur;
using Microsoft.AspNetCore.Authorization;

namespace ReservationTerrain3.Controllers
{
    public class UtilisateurController : Controller
    {



        [Authorize]
        // GET: UtilisateurController

        public IActionResult Index()
        {
            UtilisateurService utilisateurService = new UtilisateurService();
            return View(utilisateurService.GetListUtilisateur());
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: UtilisateurController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AdminCreateUtilisateur model)
        {
            try
            {
                UtilisateurService utilisateurService = new UtilisateurService();
                utilisateurService.AjouterUtilisateur(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UtilisateurController/Edit/5
        public ActionResult Edit(int id)
        {
            // Ajoutez la logique pour afficher le formulaire d'édition
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // Ajoutez la logique pour mettre à jour l'utilisateur
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                // Gérez l'exception selon vos besoins
                return View("Error");
            }
        }

        // GET: UtilisateurController/Delete/5
        public ActionResult Delete(int id)
        {
            // Ajoutez la logique pour afficher la page de confirmation de suppression
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // Ajoutez la logique pour supprimer l'utilisateur
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                // Gérez l'exception selon vos besoins
                return View("Error");
            }
        }
    }
}
