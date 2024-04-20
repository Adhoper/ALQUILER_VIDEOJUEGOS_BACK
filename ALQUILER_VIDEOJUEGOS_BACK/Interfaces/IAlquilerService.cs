using ALQUILER_VIDEOJUEGOS_BACK.DTO;
using ALQUILER_VIDEOJUEGOS_BACK.Models;

namespace ALQUILER_VIDEOJUEGOS_BACK.Interfaces
{
    public interface IAlquilerService
    {
        Task<Response<GetAlquilerDTO>> GetAlquiler();
        Task<Response> SetAlquiler(SetAlquiler setAlquiler);
        Task<Response> UpdateAlquiler(UpdateAlquiler updateAlquiler);
    }
}
