using System.ComponentModel.DataAnnotations;

namespace ALQUILER_VIDEOJUEGOS_BACK.DTO
{
    public class GetCategoriaVideojuegoDTO
    {
        [Key]
        public int IdCategoriaVJ { get; set; }
        public int Nombre { get; set; }
        public int Descripcion { get; set; }
    }
}
