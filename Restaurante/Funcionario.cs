using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Funcionario{
        public string Nome { get; set; }
        public string Atividade { get; set; }

        public Funcionario(string nome, string atividade) {
            this.Nome = nome;
            this.Atividade = atividade;
        }

        public override string ToString()
        {
            return $"Funcionario = { Nome}, Atividade ={Atividade}"; 
        }

    }
}
