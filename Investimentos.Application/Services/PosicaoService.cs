using System;
using System.Collections.Generic;
using Investimentos.Core.Interfaces;
using Investimentos.Core.Models;

namespace Investimentos.Application.Services
{
    public class PosicaoService : IPosicaoService
    {
        public decimal CalcularPrecoMedio(List<Operacao> operacoes)
        {
            if (operacoes == null || operacoes.Count == 0)
                throw new ArgumentException("A lista de operações está vazia ou inválida.");

            decimal totalInvestido = 0;
            int totalQuantidade = 0;

            foreach (var operacao in operacoes)
            {
                if (operacao.TipoOperacao == "COMPRA" && operacao.Quantidade > 0)
                {
                    totalInvestido += operacao.PrecoUnitario * operacao.Quantidade;
                    totalQuantidade += operacao.Quantidade;
                }
            }

            if (totalQuantidade == 0)
                throw new ArgumentException("Quantidade total é zero. Não é possível calcular o preço médio.");

            return totalInvestido / totalQuantidade;
        }

        public decimal CalcularPL(Posicao posicao, decimal precoAtual)
        {
            return (precoAtual - posicao.PrecoMedio) * posicao.Quantidade;
        }
    }
}