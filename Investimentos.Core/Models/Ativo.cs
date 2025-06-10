using System;
using System.Collections.Generic;
using System.Text;

namespace Investimentos.Core.Models
{
    public class Ativo
    {
        public int Id { get; set; }
        public string Codigo { get; set; } // Exemplo: ITSA3
        public string Nome { get; set; }
    }
}
