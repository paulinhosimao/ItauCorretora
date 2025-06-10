using System.Collections.Generic;
using Investimentos.Core.Models;

namespace Investimentos.Core.Interfaces
{
    public interface IPosicaoService
    {
        decimal CalcularPrecoMedio(List<Operacao> operacoes);
        decimal CalcularPL(Posicao posicao, decimal precoAtual);
    }
}