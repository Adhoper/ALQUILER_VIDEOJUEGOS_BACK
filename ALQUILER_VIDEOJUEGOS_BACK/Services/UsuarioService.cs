using ALQUILER_VIDEOJUEGOS_BACK.Context;
using ALQUILER_VIDEOJUEGOS_BACK.DTO;
using ALQUILER_VIDEOJUEGOS_BACK.Interfaces;
using ALQUILER_VIDEOJUEGOS_BACK.Models;
using Microsoft.EntityFrameworkCore;

namespace ALQUILER_VIDEOJUEGOS_BACK.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly AlquilerVideoJuegoContext _context;
        public UsuarioService(AlquilerVideoJuegoContext context)
        {
            this._context = context;
        }
        public async Task<Response<GetUsuarioDTO>> GetUsuario()
        {
            var result = new Response<GetUsuarioDTO>();
            try
            {
                result.DataList = _context.GetUsuarioDTO.FromSqlInterpolated($"dbo.GetUsuario").ToList();
            }
            catch (Exception ex)
            {
                result.Errors.Add(ex.Message);
            }

            return result;
        }

        public async Task<Response> SetUsuario(SetUsuario model)
        {
            var result = new Response();
            var passHash = Utilidades.HashPassword(model.Contrasena);
            try
            {

                _context.Database.
                    ExecuteSqlInterpolated($"dbo.SetUsuario {model.Nombre},{model.Apellido},{model.Correo},{passHash},{model.Direccion},{model.Telefono},{model.IdRol}");

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
