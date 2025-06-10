using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Investimentos.Core.Models;

namespace Investimentos.Core.Interfaces
{
    public interface IOperacaoRepository
    {
        Task<List<Operacao>> GetOperacoesPorUsuarioAsync(int usuarioId);
        Task<List<Operacao>> GetOperacoesPorAtivoAsync(int ativoId);
        Task AddOperacaoAsync(Operacao operacao);
    }
}
