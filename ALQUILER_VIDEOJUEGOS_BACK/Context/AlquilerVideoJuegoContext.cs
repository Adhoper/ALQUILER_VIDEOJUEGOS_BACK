using ALQUILER_VIDEOJUEGOS_BACK.DTO;
using ALQUILER_VIDEOJUEGOS_BACK.Models;
using Microsoft.EntityFrameworkCore;

namespace ALQUILER_VIDEOJUEGOS_BACK.Context
{
    public class AlquilerVideoJuegoContext:DbContext
    {
        public AlquilerVideoJuegoContext(DbContextOptions options) :base (options)
        {
            
        }

        public DbSet<GetVideoJuegoDTO> GetVideoJuegoDTO {  get; set; }
        public DbSet<SetVideoJuego> SetVideoJuego { get; set; }
        public DbSet<UpdateVideoJuego> UpdateVideoJuego { get; set; }
        public DbSet<GetAlquilerDTO> GetAlquilerDTO { get; set; }
        public DbSet<GetCategoriaVideojuegoDTO> GetCategoriaVideojuegoDTO { get; set; }
        public DbSet<GetUsuarioDTO> GetUsuarioDTO { get; set; }
        public DbSet<LoginUsuarioInfo> LoginUsuario { get; set; }
    }
}
