using Microsoft.EntityFrameworkCore;

namespace Academico.Data
{
    public class Departamento : DbContext
    {
        public Departamento(DbContextOptions<Departamento> options) { }
        public DbSet<Departamento> Departamento { get; set; }
    }
}
