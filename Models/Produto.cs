using System;
using System.Collections.Generic;

#nullable disable

namespace projeto_mini_curso.Models
{
    public partial class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal? Preco { get; set; }
    }
}
