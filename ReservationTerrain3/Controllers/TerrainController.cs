using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ReservationTerrain3.Controllers
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
