using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Models.Inscription;
using System.Security.Claims;
using BLL;

namespace ReservationTerrain3.Controllers
{
    public class LoginController : Controller
    {
       
        [HttpGet]
        public IActionResult Index()
        {
            ClaimsPrincipal claimUser = HttpContext.User;

            if (claimUser.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");
            return View();
        }

        [HttpPost]
        public IActionResult Index(InscriptionVM model)
        {


            UtilisateurService utilisateurService = new UtilisateurService();
            var us = utilisateurService.VerifierCompte(model);

            if (us != null)
            {
                List<Claim> claims = new List<Claim>() {
                    new Claim(ClaimTypes.Name, us.Email),
                    new Claim(ClaimTypes.NameIdentifier, us.Id.ToString()),
                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                    CookieAuthenticationDefaults.AuthenticationScheme);

                

                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));

                return RedirectToAction("Index", "Home");
            }



            ViewData["ValidateMessage"] = "user not found";
            return View();
        }
    }
}
