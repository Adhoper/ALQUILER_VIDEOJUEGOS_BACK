using ALQUILER_VIDEOJUEGOS_BACK.DTO;

namespace ALQUILER_VIDEOJUEGOS_BACK.Interfaces
{
    public interface IAutenticacionService
    {
        Task<Response<LoginUsuarioInfo>> LoginUsuario(string correo);
        Task<Response> ValidarAutenticacion(string correo, string contrasena);
    }
}
