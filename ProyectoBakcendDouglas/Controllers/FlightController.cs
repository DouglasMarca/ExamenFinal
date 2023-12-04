using Microsoft.AspNetCore.Mvc;
using ProyectoBackendDouglas.Context;
using ProyectoBackendDouglas.ModelsFlight;

namespace ProyectoBackendDouglas.ControllersFlight
{
    [ApiController]
    [Route("[controller]")]
    public class FlightController : ControllerBase
    {
    
        private readonly ILogger<FlightController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public FlightController(
            ILogger<FlightController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear vuelos
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Flight flight)
        {
            _aplicacionContexto.Flight.Add(flight);
            _aplicacionContexto.SaveChanges();
            return Ok(flight);
        }
        //READ: Obtener lista de vuelos

        [Route("")]
        [HttpGet]
        public IEnumerable<Flight> GetFlight()
        {
            return _aplicacionContexto.Flight.ToList();
        }

        //Update: Modificar vuelos
        [Route("flight")]
        [HttpPut]
        public IActionResult PutFlight(
            [FromBody] Flight flight)
        {
            _aplicacionContexto.Flight.Update(flight);
            _aplicacionContexto.SaveChanges();
            return Ok(flight);
        }
        //Delete: Eliminar vuelo
        [Route("flight/{flightId}")]
        [HttpDelete]
        public IActionResult DeleteFlight(int flightId)
        {
            _aplicacionContexto.Flight.Remove(
                _aplicacionContexto.Flight.ToList()
                .Where(x => x.IdFlight == flightId)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(flightId);
        }
}
}
