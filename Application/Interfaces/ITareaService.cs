using Application.DTO;


namespace Application.Interfaces
{
    public interface ITareaService
    {
        Task<IEnumerable<TareaDto>> GetAllTareasAsync();
        Task<TareaDto> GetTareaByIdAsync(int id);
        Task AddTareaAsync(TareaDto tareaDto);
        Task UpdateTareaAsync(TareaDto tareaDto);
        Task DeleteTareaAsync(int id);

        Task<IEnumerable<TareaDto>> GetTareasPendientesAsync();
        Task<IEnumerable<TareaDto>> GetTareasTerminadasAsync();
    }
}
