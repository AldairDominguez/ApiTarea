using Microsoft.EntityFrameworkCore;
using Repositorio.Entities;


namespace Repositorio.Contexts
{
    public class TareaDbContext : DbContext
    {
        public TareaDbContext(DbContextOptions<TareaDbContext> options) : base(options)
        {
        }

        public DbSet<Tarea> Tareas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarea>().ToTable("Tarea");
        }
    }
}
