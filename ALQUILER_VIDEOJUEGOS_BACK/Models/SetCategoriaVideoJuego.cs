using Microsoft.EntityFrameworkCore;

namespace ALQUILER_VIDEOJUEGOS_BACK.Models
{
    [Keyless]
    public class SetCategoriaVideoJuego
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
