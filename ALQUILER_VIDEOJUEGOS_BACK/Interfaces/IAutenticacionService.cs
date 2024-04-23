using ALQUILER_VIDEOJUEGOS_BACK.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ALQUILER_VIDEOJUEGOS_BACK.Interfaces
{
    public interface IAutenticacionService
    {
        Task<Response<LoginUsuarioInfo>> LoginUsuario(string correo);
        Task<Response> ValidarAutenticacion([FromBody] UsuarioLoginDTO data);
    }
}
