using curso.api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace curso.api.Configurations
{
    public class DbFactoryDbContext : IDesignTimeDbContextFactory<CursoDbContext>
    {
        public CursoDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CursoDbContext>();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-MNKOETH;Initial Catalog=DB_CURSO;Integrated Security=True");
            CursoDbContext context = new CursoDbContext(optionsBuilder.Options);

            return context;
        }
    }
}
