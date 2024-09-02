namespace ALQUILER_VIDEOJUEGOS_BACK.DTO
{
    public class TokenGot
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Correo { get; set; }
        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public string Token { get; set; }
    }
}
