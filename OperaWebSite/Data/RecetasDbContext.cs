using Microsoft.EntityFrameworkCore;
using SistemaWebMisRecetas.Models;

namespace SistemaWebMisRecetas.Data
{
    public class RecetasDbContext:DbContext
    {
        public RecetasDbContext(DbContextOptions<RecetasDbContext> options) : base(options) { }

        public DbSet<Receta> Recetas { get; set; }
    }
}
