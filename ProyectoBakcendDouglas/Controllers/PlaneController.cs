using Microsoft.AspNetCore.Mvc;
using ProyectoBackendDouglas.Context;
using ProyectoBackendDouglas.ModelsPlane;

namespace ProyectoBackendDouglas.ControllersPlane
{
    [ApiController]
    [Route("[controller]")]
    public class PlaneController : ControllerBase
    {
    
        private readonly ILogger<PlaneController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public PlaneController(
            ILogger<PlaneController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear aviones
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Plane plane)
        {
            _aplicacionContexto.Plane.Add(plane);
            _aplicacionContexto.SaveChanges();
            return Ok(plane);
        }
        //READ: Obtener lista de aviones

        [Route("")]
        [HttpGet]
        public IEnumerable<Plane> GetPlane()
        {
            return _aplicacionContexto.Plane.ToList();
        }

        //Update: Modificar aviones
        [Route("plane")]
        [HttpPut]
        public IActionResult PutPlane(
            [FromBody] Plane plane)
        {
            _aplicacionContexto.Plane.Update(plane);
            _aplicacionContexto.SaveChanges();
            return Ok(plane);
        }
        //Delete: Eliminar avion
        [Route("plane/{planeId}")]
        [HttpDelete]
        public IActionResult DeletePlane(int planeId)
        {
            _aplicacionContexto.Plane.Remove(
                _aplicacionContexto.Plane.ToList()
                .Where(x => x.IdPlane == planeId)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(planeId);
        }
}
}
