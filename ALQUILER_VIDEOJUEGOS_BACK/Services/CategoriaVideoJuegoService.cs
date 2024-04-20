using ALQUILER_VIDEOJUEGOS_BACK.Context;
using ALQUILER_VIDEOJUEGOS_BACK.DTO;
using ALQUILER_VIDEOJUEGOS_BACK.Interfaces;
using ALQUILER_VIDEOJUEGOS_BACK.Models;
using Microsoft.EntityFrameworkCore;

namespace ALQUILER_VIDEOJUEGOS_BACK.Services
{
    public class CategoriaVideoJuegoService : ICategoriaVideoJuegoService
    {
        private readonly AlquilerVideoJuegoContext _Context;
        public CategoriaVideoJuegoService(AlquilerVideoJuegoContext Context)
        {
            this._Context = Context;
        }
        public async Task<Response<GetCategoriaVideojuegoDTO>> GetCategoriaVideojuego()
        {
            var result = new Response<GetCategoriaVideojuegoDTO>();
            try
            {
                result.DataList = _Context.GetCategoriaVideojuegoDTO.FromSqlInterpolated($"dbo.GetCategoriaVideoJuego").ToList();
            }
            catch (Exception ex)
            {
                result.Errors.Add(ex.Message);
            }

            return result;
        }

        public async Task<Response> SetCategoriaVideoJuego(SetCategoriaVideoJuego model)
        {
            var result = new Response();
            try
            {
                _Context.Database.
                    ExecuteSqlInterpolated($"dbo.SetCategoriaVideoJuego {model.Nombre},{model.Descripcion}");

                result.Message = "Los datos fueron ingresados exitosamente!";
            }
            catch (Exception ex)
            {
                result.Errors.Add(ex.Message);

            }

            return result;
        }

        public async Task<Response> UpdateCategoriaVideoJuego(UpdateCategoriaVideoJuego model)
        {
            var resultado = new Response();

            try
            {
                _Context.Database.
                   ExecuteSqlInterpolated($"dbo.UpdateCategoriaVideoJuego {model.IdCategoriaVJ},{model.Nombre},{model.Descripcion}");

                resultado.Message = "Los datos fueron actualizados exitosamente!";
            }
            catch (Exception ex)
            {
                resultado.Errors.Add(ex.Message);
            }

            return resultado;
        }
    }
}
