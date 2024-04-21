using ALQUILER_VIDEOJUEGOS_BACK.Context;
using ALQUILER_VIDEOJUEGOS_BACK.DTO;
using ALQUILER_VIDEOJUEGOS_BACK.Interfaces;
using ALQUILER_VIDEOJUEGOS_BACK.Models;
using Microsoft.EntityFrameworkCore;

namespace ALQUILER_VIDEOJUEGOS_BACK.Services
{
    public class PagoService : IPagoService
    {
        private readonly AlquilerVideoJuegoContext _Context;
        public PagoService(AlquilerVideoJuegoContext Context)
        {
            this._Context = Context;
        }
        public Task<Response<GetPagoDTO>> GetPago()
        {
            throw new NotImplementedException();
        }

        public async Task<Response> SetPago(SetPago model)
        {
            var result = new Response();
            try
            {
                _Context.Database.
                    ExecuteSqlInterpolated($"dbo.SetPago {model.IdAlquiler},{model.IdUsuario},{model.Monto},{model.FechaPago},{model.MetodoPago},{model.EstatusPago}");

                result.Message = "Los datos fueron ingresados exitosamente!";
            }
            catch (Exception ex)
            {
                result.Errors.Add(ex.Message);

            }

            return result;
        }
    }
}
