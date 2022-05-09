using Domain.Constantes;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data
{
    public class Contexto : DbContext
    {
        public Contexto() {}
        public Contexto(DbContextOptions<Contexto> options): base(options) {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable(BaseConstante.ConnectionString));
            }
        }

        public DbSet<Automacao> Automacao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Automacao>(entity => {
                entity.HasKey(e => e.Id);
                entity.ToTable("Automacoes");
            });
        }
    }
}
