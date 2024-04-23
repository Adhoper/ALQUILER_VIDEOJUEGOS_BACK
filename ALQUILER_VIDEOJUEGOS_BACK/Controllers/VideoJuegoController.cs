using ALQUILER_VIDEOJUEGOS_BACK.Interfaces;
using ALQUILER_VIDEOJUEGOS_BACK.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ALQUILER_VIDEOJUEGOS_BACK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class VideoJuegoController : Controller
    {
        private readonly IVideoJuegoService _videoJuegosService;

        public VideoJuegoController(IVideoJuegoService videoJuegosService)
        {
            this._videoJuegosService = videoJuegosService;
        }

        
        [HttpGet("get-all-videogames")]
        public async Task<IActionResult> GetVideoJuegos()
        {
            return Ok(await _videoJuegosService.GetVideoJuegos());
        }

        [HttpPost("set-videogames")]
        public async Task<IActionResult> SetVideoJuegos(SetVideoJuego setVideoJuegos)
        {
            return Ok(await _videoJuegosService.SetVideoJuegos(setVideoJuegos));
        }

        [HttpPut("update-videogames")]
        public async Task<IActionResult> UpdateVideoJuegos(UpdateVideoJuego updateVideoJuego)
        {
            return Ok(await _videoJuegosService.UpdateVideoJuego(updateVideoJuego));
        }
    }
}
