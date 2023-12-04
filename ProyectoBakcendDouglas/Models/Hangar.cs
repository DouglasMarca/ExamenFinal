using System.ComponentModel.DataAnnotations;

namespace ProyectoBackendDouglas.ModelsHangar
{
    public class Hangar
    {
        [Key]
        public int IdHangar { get; set; }
        public int Capacity { get; set; }
        public string Location { get; set; }
    }
}
