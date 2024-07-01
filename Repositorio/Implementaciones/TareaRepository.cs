using Repositorio.Contexts;
using Repositorio.Entities;
using Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Repositorio.Implementaciones
{
    public class TareaRepository : ITareaRepository
    {
        private readonly TareaDbContext _dbContext;

        public TareaRepository(TareaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Tarea>> GetAllTareasAsync()
        {

            try
            {
                var tareas = await _dbContext.Tareas.ToListAsync();
                return tareas;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Tarea> GetTareaByIdAsync(int id)
        {
            try
            {
                var tareas = await _dbContext.Tareas.FindAsync(id);
                return tareas;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task AddTareaAsync(Tarea tarea)
        {
            
            try
            {
                _dbContext.Add(tarea);
                await _dbContext.SaveChangesAsync();
                
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public async Task UpdateTareaAsync(Tarea tarea)
        {
            try
            {
                _dbContext.Update(tarea);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task DeleteTareaAsync(int id)
        {

            try
            {
                var tarea = await _dbContext.Tareas.FindAsync(id);
                _dbContext.Remove(tarea);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<IEnumerable<Tarea>> GetTareasPendientesAsync()
        {
            try
            {
                var tareas = await _dbContext.Tareas.Where(x=> x.Estado == "Pendiente").ToListAsync();
                return tareas;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<IEnumerable<Tarea>> GetTareasTerminadasAsync()
        {
            try
            {
                var tareas = await _dbContext.Tareas.Where(x => x.Estado == "Terminado").ToListAsync();
                return tareas;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
