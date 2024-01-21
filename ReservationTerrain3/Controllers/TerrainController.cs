using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationHamza_Amine.Controllers
{
    [Authorize]
    public class TerrainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
