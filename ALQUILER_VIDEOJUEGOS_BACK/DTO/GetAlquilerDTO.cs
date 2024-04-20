using System.ComponentModel.DataAnnotations;

namespace ALQUILER_VIDEOJUEGOS_BACK.DTO
{
    public class GetAlquilerDTO
    {
        [Key]
        public int IdAlquiler { get; set; }
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public int IdVideoJuego { get; set; }
        public string NombreVideoJuego { get; set; }
        public string DescripcionVideoJuego { get; set; }
        public decimal PrecioVideoJuego { get; set; }
        public int CantidadAlquilado { get; set; }
        public string NombreCategoriaVJ { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal PrecioTotal { get; set; }
        public string EstatusPago { get; set; }
    }
}
