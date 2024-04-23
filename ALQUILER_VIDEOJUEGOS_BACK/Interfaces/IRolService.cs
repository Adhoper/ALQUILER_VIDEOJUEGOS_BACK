using ALQUILER_VIDEOJUEGOS_BACK.DTO;
using ALQUILER_VIDEOJUEGOS_BACK.Models;

namespace ALQUILER_VIDEOJUEGOS_BACK.Interfaces
{
    public interface IRolService
    {
        Task<Response<GetRolDTO>> GetRol();
        Task<Response> SetRol(SetRol setRol);
        Task<Response> UpdateRol(UpdateRol updateRol);
    }
}
