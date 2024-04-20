namespace ALQUILER_VIDEOJUEGOS_BACK.Models
{
    public class SetAlquiler
    {
        public int IdUsuario { get; set; }
        public int IdVideoJuego { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal PrecioTotal { get; set; }
        public string EstatusPago { get; set; }
        public int CantidadAlquilado { get; set; }
    }
}
