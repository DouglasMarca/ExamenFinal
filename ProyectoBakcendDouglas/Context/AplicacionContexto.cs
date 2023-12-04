using Microsoft.EntityFrameworkCore;

namespace ProyectoBackendDouglas.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }

    }
}
