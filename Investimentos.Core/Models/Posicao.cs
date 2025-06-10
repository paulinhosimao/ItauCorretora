using System;
using System.Collections.Generic;
using System.Text;

namespace Investimentos.Core.Models
{
    public class Posicao
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int AtivoId { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoMedio { get; set; }
        public decimal PL { get; set; } // Profit & Loss (lucro ou prejuízo)
    }
}
