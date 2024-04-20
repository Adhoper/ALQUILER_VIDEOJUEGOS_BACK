using ALQUILER_VIDEOJUEGOS_BACK.Interfaces;
using ALQUILER_VIDEOJUEGOS_BACK.Models;
using ALQUILER_VIDEOJUEGOS_BACK.Services;
using Microsoft.AspNetCore.Mvc;

namespace ALQUILER_VIDEOJUEGOS_BACK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlquilerController : Controller
    {
        private readonly IAlquilerService _service;
        public AlquilerController(IAlquilerService service)
        {
            this._service = service;
        }


        [HttpGet("get-all-alquileres")]
        public async Task<IActionResult> GetVideoJuegos()
        {
            return Ok(await _service.GetAlquiler());
        }

        [HttpPost("set-alquiler")]
        public async Task<IActionResult> SetVideoJuegos(SetAlquiler model)
        {
            return Ok(await _service.SetAlquiler(model));
        }

        [HttpPut("update-alquiler")]
        public async Task<IActionResult> UpdateVideoJuegos(UpdateAlquiler model)
        {
            return Ok(await _service.UpdateAlquiler(model));
        }
    }
}
