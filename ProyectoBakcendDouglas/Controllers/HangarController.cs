using Microsoft.AspNetCore.Mvc;
using ProyectoBackendDouglas.Context;
using ProyectoBackendDouglas.ModelsHangar;

namespace ProyectoBackendDouglas.ControllersHangar
{
    [ApiController]
    [Route("[controller]")]
    public class HangarController : ControllerBase
    {
    
        private readonly ILogger<HangarController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public HangarController(
            ILogger<HangarController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear hangares
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Hangar hangar)
        {
            _aplicacionContexto.Hangar.Add(hangar);
            _aplicacionContexto.SaveChanges();
            return Ok(hangar);
        }
        //READ: Obtener lista de hangares

        [Route("")]
        [HttpGet]
        public IEnumerable<Hangar> GetHangar()
        {
            return _aplicacionContexto.Hangar.ToList();
        }

        //Update: Modificar hangares
        [Route("plane")]
        [HttpPut]
        public IActionResult PutHangar(
            [FromBody] Hangar hangar)
        {
            _aplicacionContexto.Hangar.Update(hangar);
            _aplicacionContexto.SaveChanges();
            return Ok(hangar);
        }
        //Delete: Eliminar hangar
        [Route("hangar/{hangarId}")]
        [HttpDelete]
        public IActionResult DeleteHangar(int hangarId)
        {
            _aplicacionContexto.Hangar.Remove(
                _aplicacionContexto.Hangar.ToList()
                .Where(x => x.IdHangar == hangarId)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(hangarId);
        }
}
}
