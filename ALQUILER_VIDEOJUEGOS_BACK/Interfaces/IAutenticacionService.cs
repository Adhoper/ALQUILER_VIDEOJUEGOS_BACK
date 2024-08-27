using ALQUILER_VIDEOJUEGOS_BACK.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ALQUILER_VIDEOJUEGOS_BACK.Interfaces
{
    public interface IAutenticacionService
    {
        Task<Response<LoginUsuarioInfo>> LoginUsuario(string identificadorUsuario);
        Task<Response> ValidarAutenticacion([FromBody] UsuarioLoginDTO data);
    }
}
