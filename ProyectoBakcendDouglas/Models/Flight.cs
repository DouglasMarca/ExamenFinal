using System.ComponentModel.DataAnnotations;

namespace ProyectoBackendDouglas.ModelsFlight
{
    public class Flight
    {
        [Key]
        public DateTime DateofFlight { get; set; }
        public int LicenseNumber { get; set; }
        public int IdPlane { get; set; }
        public int IdFlight { get; set; }
    }
}
