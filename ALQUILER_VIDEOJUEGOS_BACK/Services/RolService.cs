using ALQUILER_VIDEOJUEGOS_BACK.Context;
using ALQUILER_VIDEOJUEGOS_BACK.DTO;
using ALQUILER_VIDEOJUEGOS_BACK.Interfaces;
using ALQUILER_VIDEOJUEGOS_BACK.Models;
using Microsoft.EntityFrameworkCore;

namespace ALQUILER_VIDEOJUEGOS_BACK.Services
{
    public class RolService : IRolService
    {
        private readonly AlquilerVideoJuegoContext _context;
        public RolService(AlquilerVideoJuegoContext context)
        {
            this._context = context;
        }
        public async Task<Response<GetRolDTO>> GetRol()
        {
            var result = new Response<GetRolDTO>();
            try
            {
                result.DataList = _context.GetRolDTO.FromSqlInterpolated($"dbo.GetRol").ToList();
            }
            catch (Exception ex)
            {
                result.Errors.Add(ex.Message);
            }

            return result;
        }

        public async Task<Response> SetRol(SetRol model)
        {
            var result = new Response();
            try
            {
                _context.Database.
                    ExecuteSqlInterpolated($"dbo.SetRol {model.Nombre},{model.Descripcion}");

                result.Message = "Los datos fueron ingresados exitosamente!";
            }
            catch (Exception ex)
            {
                result.Errors.Add(ex.Message);

            }

            return result;
        }

        public async Task<Response> UpdateRol(UpdateRol model)
        {
            var resultado = new Response();

            try
            {
                _context.Database.
                   ExecuteSqlInterpolated($"dbo.UpdateCategoriaVideoJuego {model.IdRol},{model.Nombre},{model.Descripcion}");

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
