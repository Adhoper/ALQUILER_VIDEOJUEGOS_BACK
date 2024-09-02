using Microsoft.EntityFrameworkCore;

namespace ALQUILER_VIDEOJUEGOS_BACK.DTO
{
    [Keyless]
    public class SetUserResult
    {
        public string EstatusRegistro { get; set; }
        public string Result { get; set; }
    }
}
