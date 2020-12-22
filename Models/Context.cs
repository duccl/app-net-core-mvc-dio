using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace app_net_core.Models
{
    public class Context: DbContext
    {
        public DbSet<Categoria> Categorias{ get; set;}
        public DbSet<Produto> Produtos{ get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString:$"{System.Environment.GetEnvironmentVariable("POSTGRES_LOCAL",System.EnvironmentVariableTarget.Machine)}");
        }
    }
}