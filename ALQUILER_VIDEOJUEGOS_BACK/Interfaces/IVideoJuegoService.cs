using ALQUILER_VIDEOJUEGOS_BACK.DTO;
using ALQUILER_VIDEOJUEGOS_BACK.Models;

namespace ALQUILER_VIDEOJUEGOS_BACK.Interfaces
{
    public interface IVideoJuegoService
    {
        Task<Response<GetVideoJuegoDTO>> GetVideoJuegos();
        Task<Response> SetVideoJuegos(SetVideoJuego setVideoJuegos);
        Task<Response> UpdateVideoJuego(UpdateVideoJuego setVideoJuegos);
    }
}
