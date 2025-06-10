using Microsoft.EntityFrameworkCore;
using Investimentos.Core.Models;

namespace Investimentos.Infrastructure.Data
{
    public class InvestimentosDbContext : DbContext
    {
        public InvestimentosDbContext(DbContextOptions<InvestimentosDbContext> options) : base(options) { }

        public DbSet<Operacao> Operacoes { get; set; }
        public DbSet<Posicao> Posicoes { get; set; }
        public DbSet<Ativo> Ativos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cotacao> Cotacoes { get; set; }
    }
}