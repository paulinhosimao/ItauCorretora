using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Investimentos.Core.Interfaces;
using Investimentos.Core.Models;
using Microsoft.EntityFrameworkCore;
using Investimentos.Infrastructure.Data;

namespace Investimentos.Infrastructure.Repositories
{
    public class OperacaoRepository : IOperacaoRepository
    {
        private readonly InvestimentosDbContext _dbContext;

        public OperacaoRepository(InvestimentosDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Operacao>> GetOperacoesPorUsuarioAsync(int usuarioId)
        {
            return await _dbContext.Operacoes
                .Where(o => o.UsuarioId == usuarioId)
                .ToListAsync();
        }

        public async Task<List<Operacao>> GetOperacoesPorAtivoAsync(int ativoId)
        {
            return await _dbContext.Operacoes
                .Where(o => o.AtivoId == ativoId)
                .ToListAsync();
        }

        public async Task AddOperacaoAsync(Operacao operacao)
        {
            await _dbContext.Operacoes.AddAsync(operacao);
            await _dbContext.SaveChangesAsync();
        }
    }
}