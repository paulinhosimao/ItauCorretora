using System;
using System.Collections.Generic;
using System.Text;

namespace Investimentos.Core.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public decimal CorretagemPercentual { get; set; } // Percentual de corretagem
    }
}
