using System.ComponentModel.DataAnnotations;

namespace ProyectoBackendDouglas.ModelsPlane
{
    public class Plane
    {
        [Key]
        public int IdPlane { get; set; }
        public string Model { get; set; }
        public float Weight { get; set; }
        public int Capacity { get; set; }
        public int IdHangar { get; set; }
    }
}
