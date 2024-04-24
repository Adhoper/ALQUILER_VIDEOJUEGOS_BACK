using System.ComponentModel.DataAnnotations;

namespace ALQUILER_VIDEOJUEGOS_BACK.DTO
{
    public class GetRolDTO
    {
        [Key]
        public int IdRol {  get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Estatus { get; set; }
    }
}
