using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Cozinha
    {
        public int NumeroDePratos { get; set; }
        public int NumeroTrabalhadores { get; set; }
        public int TempoPreparo { get; set; }
        public int HoraAbertura { get; set; }
        public int HoraFechamento { get; set; }
        public string TipoCozinha { get; set; }
        public string PratoPrincipal { get; set; }
        public List<Ingredientes> Ingred = new List<Ingredientes>();
        public List<Funcionario> Func = new List<Funcionario>();

        public Cozinha(int numerodepratos, int numerotrabalhadores, int tempopreparo, int hrabertura, int hrfechamento, string tipo, string pratoprincipal)
        {
            NumeroDePratos = numerodepratos;
            NumeroTrabalhadores = numerotrabalhadores;
            TempoPreparo = tempopreparo;
            HoraAbertura = hrabertura;
            HoraFechamento = hrfechamento;
            TipoCozinha = tipo;
            PratoPrincipal = pratoprincipal;
        }

        public void AdicionarFuncionarios(string nome, string atividade)
        {

            Func.Add(new Funcionario(nome, atividade));


        }
        public int NumeroFuncionarios()
        {

            return NumeroTrabalhadores;


        }
        public string RetornaFuncionarios(int n)
        {
            return Func[n].ToString();


        }





        public void AdicionarIngredientes(string nome, string validade)
        {
            var data = DateTime.Parse(validade);
            Ingred.Add(new Ingredientes(nome, data));


        }
        public int numeroIngredientes()
        {
            return NumeroDePratos;
        }





        public string retornaIngrediente(int n)
        {
            return Ingred[n].ToString();
        }


        public override string ToString()
        {
            return
                $"Cozinha = {TipoCozinha}" +
                $"\nInicio Funcionamento = {HoraAbertura} horas" +
                $"\nFim Funcionamento = {HoraFechamento} horas" +
                $"\nNumero Funcionarios = {NumeroTrabalhadores}" +
                $"\nPrato Principal = {PratoPrincipal}" +
                $"\nIngredientes = {NumeroDePratos}" +
                $"\nTempo Preparo = {TempoPreparo}";
        }
    }
}
