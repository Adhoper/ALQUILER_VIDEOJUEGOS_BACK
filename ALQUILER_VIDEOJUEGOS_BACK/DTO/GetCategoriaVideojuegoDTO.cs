using System.ComponentModel.DataAnnotations;

namespace ALQUILER_VIDEOJUEGOS_BACK.DTO
{
    public class GetCategoriaVideojuegoDTO
    {
        [Key]
        public int IdCategoriaVJ { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
