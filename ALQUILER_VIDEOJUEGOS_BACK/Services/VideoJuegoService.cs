using ALQUILER_VIDEOJUEGOS_BACK.Context;
using ALQUILER_VIDEOJUEGOS_BACK.DTO;
using ALQUILER_VIDEOJUEGOS_BACK.Interfaces;
using ALQUILER_VIDEOJUEGOS_BACK.Models;
using Microsoft.EntityFrameworkCore;

namespace ALQUILER_VIDEOJUEGOS_BACK.Services
{
    public class VideoJuegoService : IVideoJuegoService
    {
        private readonly AlquilerVideoJuegoContext _Context;

        public VideoJuegoService(AlquilerVideoJuegoContext Context)
        {
            this._Context = Context;
        }
        public async Task<Response<GetVideoJuegoDTO>> GetVideoJuegos()
        {
            var result = new Response<GetVideoJuegoDTO>();
            try
            {
                result.DataList = _Context.GetVideoJuegoDTO.FromSqlInterpolated($"dbo.GetVideoJuegoInfo").ToList();
            }
            catch (Exception ex)
            {
                result.Errors.Add(ex.Message);
            }

            return result;
        }

        public async Task<Response> SetVideoJuegos(SetVideoJuego setVideoJuegos)
        {
            var resultado = new Response();

            try
            {
                await _Context.SetVideoJuego.FromSqlRaw("dbo.SetVideoJuegoInfo {0},{1},{2},{3},{4}",
                         setVideoJuegos.Nombre,setVideoJuegos.Descripcion,setVideoJuegos.Precio,setVideoJuegos.Cantidad,setVideoJuegos.IdCategoriaVJ).ToListAsync();

                resultado.Message = "Los datos fueron ingresados exitosamente!!!";
            }
            catch (Exception ex)
            {
                resultado.Errors.Add(ex.Message);
            }

            return resultado;
        }

        public async Task<Response> UpdateVideoJuego(UpdateVideoJuego model)
        {
            var resultado = new Response();

            try
            {
                await _Context.UpdateVideoJuego.FromSqlRaw("dbo.UpdateVideoJuegoInfo {0},{1},{2},{3},{4},{5},{6}",
                         model.IdVideoJuego,model.Nombre,model.Descripcion,model.Precio,model.Cantidad, model.IdCategoriaVJ, model.Estatus).ToListAsync();

                resultado.Message = "Los datos fueron actualizados exitosamente!!!";
            }
            catch (Exception ex)
            {
                resultado.Errors.Add(ex.Message);
            }

            return resultado;
        }
    }
}
