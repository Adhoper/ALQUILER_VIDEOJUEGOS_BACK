using ALQUILER_VIDEOJUEGOS_BACK.DTO;
using ALQUILER_VIDEOJUEGOS_BACK.Models;

namespace ALQUILER_VIDEOJUEGOS_BACK.Interfaces
{
    public interface IPagoService
    {
        Task<Response<GetPagoDTO>> GetPago();
        Task<Response> SetPago(SetPago setPago);
    }
}
