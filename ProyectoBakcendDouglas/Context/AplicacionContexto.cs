using Microsoft.EntityFrameworkCore;
using ProyectoBackendDouglas.ModelsPlane;
using ProyectoBackendDouglas.ModelsPilot;
using ProyectoBackendDouglas.ModelsFlight;
using ProyectoBackendDouglas.ModelsHangar;

namespace ProyectoBackendDouglas.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }
        public DbSet<Plane> Plane { get; set; }
        public DbSet<Pilot> Pilot { get; set; }
        public DbSet<Flight> Flight { get; set; }
        public DbSet<Hangar> Hangar { get; set; }

    }
}
