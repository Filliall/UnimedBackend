using Microsoft.EntityFrameworkCore;
using UnimedBackend.Models;

namespace UnimedBackend.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        public DbSet<TarefaModel> Tarefas { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TarefaModel>().ToTable("Tarefas");
            base.OnModelCreating(modelBuilder);
        }
    }
}
