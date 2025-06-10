using System;
using System.Collections.Generic;
using System.Text;

namespace Investimentos.Core.Models
{
    public class Operacao
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int AtivoId { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public string TipoOperacao { get; set; } // "COMPRA" ou "VENDA"
        public decimal Corretagem { get; set; }
        public DateTime DataHora { get; set; }
    }
}

