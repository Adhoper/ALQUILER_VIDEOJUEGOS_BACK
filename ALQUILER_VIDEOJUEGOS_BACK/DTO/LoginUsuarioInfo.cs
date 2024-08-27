using System.ComponentModel.DataAnnotations;

namespace ALQUILER_VIDEOJUEGOS_BACK.DTO
{
    public class LoginUsuarioInfo
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Usuario {  get; set; }
        public string Correo { get; set; }
        public Byte[] Contrasena { get; set; }
        public int IdRol {  get; set; }
        public string NombreRol { get; set; }
    }
}
