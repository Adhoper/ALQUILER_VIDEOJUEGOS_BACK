using Microsoft.AspNetCore.Mvc;

namespace ALQUILER_VIDEOJUEGOS_BACK.Controllers
{
    public class AlquilerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
