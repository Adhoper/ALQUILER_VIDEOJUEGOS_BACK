using ALQUILER_VIDEOJUEGOS_BACK.Interfaces;
using ALQUILER_VIDEOJUEGOS_BACK.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ALQUILER_VIDEOJUEGOS_BACK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly IRolService _service;
        public RolController(IRolService service)
        {
            this._service = service;
        }

        [HttpGet("get-all-rol")]
        public async Task<IActionResult> GetUsuario()
        {
            return Ok(await _service.GetRol());
        }

        [HttpPost("set-rol")]
        public async Task<IActionResult> SetUsuario(SetRol model)
        {
            return Ok(await _service.SetRol(model));
        }

        [HttpPut("update-rol")]
        public async Task<IActionResult> UpdateUsuario(UpdateRol model)
        {
            return Ok(await _service.UpdateRol(model));
        }
    }
}
