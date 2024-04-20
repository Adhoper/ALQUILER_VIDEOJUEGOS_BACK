using ALQUILER_VIDEOJUEGOS_BACK.DTO;
using ALQUILER_VIDEOJUEGOS_BACK.Models;

namespace ALQUILER_VIDEOJUEGOS_BACK.Interfaces
{
    public interface ICategoriaVideoJuegoService
    {
        Task<Response<GetCategoriaVideojuegoDTO>> GetCategoriaVideojuego();
        Task<Response> SetCategoriaVideoJuego(SetCategoriaVideoJuego setCategoriaVideoJuego);
        Task<Response> UpdateCategoriaVideoJuego(UpdateCategoriaVideoJuego updateCategoriaVideoJuego);
    }
}
