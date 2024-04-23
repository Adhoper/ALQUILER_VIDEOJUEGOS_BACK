using ALQUILER_VIDEOJUEGOS_BACK.Interfaces;
using ALQUILER_VIDEOJUEGOS_BACK.Models;
using Microsoft.AspNetCore.Mvc;

namespace ALQUILER_VIDEOJUEGOS_BACK.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _Service;
        public UsuarioController(IUsuarioService Service)
        {
            this._Service = Service;
        }

        [HttpGet("get-all-usuario")]
        public async Task<IActionResult> GetUsuario()
        {
            return Ok(await _Service.GetUsuario());
        }

        [HttpPost("set-usuario")]
        public async Task<IActionResult> SetUsuario(SetUsuario model)
        {
            return Ok(await _Service.SetUsuario(model));
        }

        [HttpPut("update-usuario")]
        public async Task<IActionResult> UpdateUsuario(UpdateUsuario model)
        {
            return Ok(await _Service.UpdateUsuario(model));
        }

    }
}
