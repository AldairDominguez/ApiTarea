using Application.DTO;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiGestionarTarea.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TareaController : ControllerBase
    {
        private readonly ITareaService _tareaService;

        public TareaController(ITareaService tareaService)
        {
            _tareaService = tareaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TareaDto>>> GetAllTareas()
        {
            var tareas = await _tareaService.GetAllTareasAsync();
            return Ok(tareas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TareaDto>> GetTareaById(int id)
        {
            var tarea = await _tareaService.GetTareaByIdAsync(id);
            if (tarea == null)
            {
                return NotFound($"No se encuentra la tarea con ID {id}");
            }
            return Ok(tarea);
        }

        [HttpPost]
        public async Task<ActionResult> AddTarea(TareaDto tareaDto)
        {
            await _tareaService.AddTareaAsync(tareaDto);
            //var message = $"Se añadió la tarea con ID {tareaDto.Id}";
            return CreatedAtAction(nameof(GetTareaById), new { id = tareaDto.Id }, tareaDto);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateTarea(TareaDto tareaDto)
        {
           
            await _tareaService.UpdateTareaAsync(tareaDto);

            var message = $"Se actualizó la tarea con ID {tareaDto.Id}";

            return Ok(new { mensaje = message });
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTarea(int id)
        {
            var tarea = await _tareaService.GetTareaByIdAsync(id);
            if (tarea == null)
            {
                return NotFound($"No se encuentra la tarea con ID {id}");
            }
            await _tareaService.DeleteTareaAsync(id);
            var message = $"Se eliminó la tarea con ID {id}";
            return Ok(new { mensaje = message });
        }

        [HttpGet("pendientes")]
        public async Task<ActionResult<IEnumerable<TareaDto>>> GetTareasPendientes()
        {
            var tareasPendientes = await _tareaService.GetTareasPendientesAsync();
            return Ok(tareasPendientes);
        }


        [HttpGet("terminadas")]
        public async Task<ActionResult<IEnumerable<TareaDto>>> GetTareasTerminadas()
        {
            var tareasTerminadas = await _tareaService.GetTareasTerminadasAsync();
            return Ok(tareasTerminadas);
        }
    }
}
