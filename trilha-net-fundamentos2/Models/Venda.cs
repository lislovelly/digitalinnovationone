using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_net_fundamentos2.Models
{
    public class Venda(int id, string produto, decimal preco, DateTime dataVenda)
    {
        public int Id { get; set; } = id;
        public string Produto { get; set; } = produto;
        public decimal Preco { get; set; } = preco;

        public DateTime DataVenda { get; set; } = dataVenda;
    }   
}