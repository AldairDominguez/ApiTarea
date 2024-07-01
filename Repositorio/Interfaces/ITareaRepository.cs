using Repositorio.Entities;


namespace Repositorio.Interfaces
{
    public interface ITareaRepository
    {
        Task<IEnumerable<Tarea>> GetAllTareasAsync();
        Task<Tarea> GetTareaByIdAsync(int id);
        Task AddTareaAsync(Tarea tarea);
        Task UpdateTareaAsync(Tarea tarea);
        Task DeleteTareaAsync(int id);


        Task<IEnumerable<Tarea>> GetTareasPendientesAsync();
        Task<IEnumerable<Tarea>> GetTareasTerminadasAsync();
    }
}
