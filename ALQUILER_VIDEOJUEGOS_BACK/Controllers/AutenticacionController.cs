using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ALQUILER_VIDEOJUEGOS_BACK.Models;
using ALQUILER_VIDEOJUEGOS_BACK.DTO;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using ALQUILER_VIDEOJUEGOS_BACK.Interfaces;

namespace ALQUILER_VIDEOJUEGOS_BACK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacionController : ControllerBase
    {
        private readonly IAutenticacionService _Service;

        public AutenticacionController(IAutenticacionService Service)
        {
            
            this._Service = Service;

        }

        [HttpPost]
        [Route("ValidarAutenticacion")]
        public async Task<Response> ValidarAutenticacion(string correo, string contrasena)
        {
            return await _Service.ValidarAutenticacion(correo, contrasena);
        }
    }
}
