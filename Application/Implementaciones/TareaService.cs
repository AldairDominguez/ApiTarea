using Application.DTO;
using Application.Interfaces;
using Repositorio.Entities;
using Repositorio.Interfaces;


namespace Application.Implementaciones
{
    public class TareaService : ITareaService
    {
        private readonly ITareaRepository _tareaRepository;

        public TareaService(ITareaRepository tareaRepository)
        {
            _tareaRepository = tareaRepository;
        }

        public async Task<IEnumerable<TareaDto>> GetAllTareasAsync()
        {
            var tareas = await _tareaRepository.GetAllTareasAsync();
            return tareas.Select(t => new TareaDto
            {
                Id = t.Id,
                FechaInicio = t.FechaInicio,
                FechaFin = t.FechaFin,
                Estado = t.Estado,
                Descripcion = t.Descripcion
            });
        }

        public async Task<TareaDto> GetTareaByIdAsync(int id)
        {
            var tarea = await _tareaRepository.GetTareaByIdAsync(id);
            if (tarea == null)
            {
                return null;
            }

            return new TareaDto
            {
                Id = tarea.Id,
                FechaInicio = tarea.FechaInicio,
                FechaFin = tarea.FechaFin,
                Estado = tarea.Estado,
                Descripcion = tarea.Descripcion
            };
        }

        public async Task AddTareaAsync(TareaDto tareaDto)
        {
            var tarea = new Tarea
            {
                FechaInicio = tareaDto.FechaInicio,
                FechaFin = tareaDto.FechaFin,
                Estado = tareaDto.Estado,
                Descripcion = tareaDto.Descripcion
            };

            await _tareaRepository.AddTareaAsync(tarea);
        }

        public async Task UpdateTareaAsync(TareaDto tareaDto)
        {
            var tarea = new Tarea
            {
                Id = tareaDto.Id,
                FechaInicio = tareaDto.FechaInicio,
                FechaFin = tareaDto.FechaFin,
                Estado = tareaDto.Estado,
                Descripcion = tareaDto.Descripcion
            };

            await _tareaRepository.UpdateTareaAsync(tarea);
        }

        public async Task DeleteTareaAsync(int id)
        {
            await _tareaRepository.DeleteTareaAsync(id);
        }


        public async Task<IEnumerable<TareaDto>> GetTareasPendientesAsync()
        {
            var tareas = await _tareaRepository.GetTareasPendientesAsync();
            return tareas.Select(t => new TareaDto
            {
                Id = t.Id,
                FechaInicio = t.FechaInicio,
                FechaFin = t.FechaFin,
                Estado = t.Estado,
                Descripcion = t.Descripcion
            });
        }

        public async Task<IEnumerable<TareaDto>> GetTareasTerminadasAsync()
        {
            var tareas = await _tareaRepository.GetTareasTerminadasAsync();
            return tareas.Select(t => new TareaDto
            {
                Id = t.Id,
                FechaInicio = t.FechaInicio,
                FechaFin = t.FechaFin,
                Estado = t.Estado,
                Descripcion = t.Descripcion
            });
        }
    }

}
