using System.ComponentModel.DataAnnotations;

namespace ALQUILER_VIDEOJUEGOS_BACK.DTO
{
    public class GetVideoJuegoDTO
    {
        [Key]
        public int IdVideoJuego { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public int IdCategoriaVJ { get; set; }
        public string NombreCategoria { get; set; }
        public string Estatus { get; set; }
    }
}
