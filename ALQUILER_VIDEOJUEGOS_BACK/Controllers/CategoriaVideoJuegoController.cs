using ALQUILER_VIDEOJUEGOS_BACK.Interfaces;
using ALQUILER_VIDEOJUEGOS_BACK.Models;
using Microsoft.AspNetCore.Mvc;

namespace ALQUILER_VIDEOJUEGOS_BACK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaVideoJuegoController : Controller
    {
        private readonly ICategoriaVideoJuegoService _Service;
        public CategoriaVideoJuegoController(ICategoriaVideoJuegoService Service)
        {
            this._Service = Service;
        }

        [HttpGet("get-all-CategoriasVJ")]
        public async Task<IActionResult> GetCategoriaVideojuego()
        {
            return Ok(await _Service.GetCategoriaVideojuego());
        }

        [HttpPost("set-CategoriasVJ")]
        public async Task<IActionResult> SetVideoJuegos(SetCategoriaVideoJuego model)
        {
            return Ok(await _Service.SetCategoriaVideoJuego(model));
        }

        [HttpPut("update-CategoriasVJ")]
        public async Task<IActionResult> UpdateVideoJuegos(UpdateCategoriaVideoJuego model)
        {
            return Ok(await _Service.UpdateCategoriaVideoJuego(model));
        }
    }
}
