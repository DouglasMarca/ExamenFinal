using System.ComponentModel.DataAnnotations;

namespace ProyectoBackendDouglas.ModelsPilot
{
    public class Pilot
    {
        [Key]
        public int LicenseNumber { get; set; }
        public string Restrictions { get; set; }
        public float Salary { get; set; }
        public string Shift { get; set; }
    }
}
