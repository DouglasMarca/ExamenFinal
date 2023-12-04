using Microsoft.AspNetCore.Mvc;
using ProyectoBackendDouglas.Context;
using ProyectoBackendDouglas.ModelsPilot;

namespace ProyectoBackendDouglas.ControllersPilot
{
    [ApiController]
    [Route("[controller]")]
    public class PilotController : ControllerBase
    {
    
        private readonly ILogger<PilotController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public PilotController(
            ILogger<PilotController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear pilotos
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Pilot pilot)
        {
            _aplicacionContexto.Pilot.Add(pilot);
            _aplicacionContexto.SaveChanges();
            return Ok(pilot);
        }
        //READ: Obtener lista de pilotos

        [Route("")]
        [HttpGet]
        public IEnumerable<Pilot> GetPilot()
        {
            return _aplicacionContexto.Pilot.ToList();
        }

        //Update: Modificar pilotos
        [Route("pilot")]
        [HttpPut]
        public IActionResult PutPilot(
            [FromBody] Pilot pilot)
        {
            _aplicacionContexto.Pilot.Update(pilot);
            _aplicacionContexto.SaveChanges();
            return Ok(pilot);
        }
        //Delete: Eliminar piloto
        [Route("pilot/{pilotId}")]
        [HttpDelete]
        public IActionResult DeletePilot(int pilotId)
        {
            _aplicacionContexto.Pilot.Remove(
                _aplicacionContexto.Pilot.ToList()
                .Where(x => x.LicenseNumber == pilotId)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(pilotId);
        }
}
}
