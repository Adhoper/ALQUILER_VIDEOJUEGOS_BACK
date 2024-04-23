using ALQUILER_VIDEOJUEGOS_BACK.DTO;
using ALQUILER_VIDEOJUEGOS_BACK.Models;

namespace ALQUILER_VIDEOJUEGOS_BACK.Interfaces
{
    public interface IUsuarioService
    {
        Task<Response<GetUsuarioDTO>> GetUsuario();
        Task<Response> SetUsuario(SetUsuario setUsuario);
        Task<Response> UpdateUsuario(UpdateUsuario updateUsuario);
    }
}
