using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Ingredientes{
        public string Nome { get; set; }
        public DateTime DataDeValidade{ get; set; }

        public Ingredientes(string nome, DateTime DtValidade)
        {
            this.Nome = nome;
            this.DataDeValidade = DtValidade;
        }

        public override string ToString()
        {
            return $"Ingrediente ={Nome}, Validade ={DataDeValidade.ToString("dd-MM yyy")}"; 
        }





    }
}
