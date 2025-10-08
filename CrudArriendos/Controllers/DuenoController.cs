using CrudArriendo.Application.DTOs;
using CrudArriendo.Application.UseCases.Dueno;
using CrudArriendo.Application.UseCases.DuenoU;
using CrudArriendos.Application.UseCases.DuenoU;
using Microsoft.AspNetCore.Mvc;

namespace CrudArriendos.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class DuenoController : ControllerBase
    {
        private readonly CrearDuenoUseCase _crearDuenoUseCase;
        private readonly ListarDuenosUseCase _listarDuenosUseCase;
        private readonly ActualizarDuenoUseCase _actualizarDuenoUseCase;
        private readonly EliminarDuenoUseCase _eliminarDuenoUseCase;
        private readonly ObtenerDuenoPorIdUseCase _obtenerDuenoPorIdUseCase;

        public DuenoController(
            CrearDuenoUseCase crearDuenoUseCase,
            ListarDuenosUseCase listarDuenosUseCase,
            ActualizarDuenoUseCase actualizarDuenoUseCase,
            EliminarDuenoUseCase eliminarDuenoUseCase,
            ObtenerDuenoPorIdUseCase obtenerDuenoPorIdUseCase)
        {
            _crearDuenoUseCase = crearDuenoUseCase;
            _listarDuenosUseCase = listarDuenosUseCase;
            _actualizarDuenoUseCase = actualizarDuenoUseCase;
            _eliminarDuenoUseCase = eliminarDuenoUseCase;
            _obtenerDuenoPorIdUseCase = obtenerDuenoPorIdUseCase;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var duenos = _listarDuenosUseCase.Execute();
            return Ok(duenos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var dueno = _obtenerDuenoPorIdUseCase.Execute(id);
            if (dueno == null)
                return NotFound("Dueño no encontrado");

            return Ok(dueno);
        }

        [HttpPost]
        public IActionResult Create([FromBody] DuenoDto dueno)
        {
            _crearDuenoUseCase.Execute(dueno);
            return Ok("Dueño creado exitosamente");
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] DuenoDto dueno)
        {
            _actualizarDuenoUseCase.Execute(id, dueno); // Pass both 'id' and 'dueno' as arguments
            return Ok("Dueño actualizado correctamente");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _eliminarDuenoUseCase.Execute(id);
            return Ok("Dueño eliminado");
        }
    }
}

