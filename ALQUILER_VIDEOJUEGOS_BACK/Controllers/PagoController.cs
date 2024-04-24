using ALQUILER_VIDEOJUEGOS_BACK.Interfaces;
using ALQUILER_VIDEOJUEGOS_BACK.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ALQUILER_VIDEOJUEGOS_BACK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagoController : ControllerBase
    {
        private readonly IPagoService _service;
        public PagoController(IPagoService service)
        {
            this._service = service;
        }

        [HttpGet("get-all-pago")]
        public async Task<IActionResult> GetPago()
        {
            return Ok(await _service.GetPago());
        }

        [HttpPost("set-pago")]
        public async Task<IActionResult> SetPago(SetPago model)
        {
            return Ok(await _service.SetPago(model));
        }
    }
}
