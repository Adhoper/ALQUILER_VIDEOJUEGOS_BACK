namespace ALQUILER_VIDEOJUEGOS_BACK.Models
{
    public class UpdateUsuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Estatus { get; set; }
        public int IdRol { get; set; }
    }
}
