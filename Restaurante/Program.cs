using System;
using System.Collections.Generic;



namespace Restaurante
{
    class Principal
    {
        static void Main(string[] args)
        {
            List<Cozinha> cozinha = new List<Cozinha>();
            int n = 0;
            Console.Write("Informe quantos restaurantes ira Cadastrar: ");
            int numeroRestaurantes = int.Parse(Console.ReadLine());

            while (n < numeroRestaurantes)
            {
                Console.WriteLine("\n\nCadastrando Restaurante\n");
                Console.Write("Informe o tipo de cozinha: ");
                string tipoCozinha = Console.ReadLine();
                Console.Write("Infome a quantidade de funcionarios: ");
                int numeroFuncioarios = int.Parse(Console.ReadLine());
                Console.Write("Infome a quantidade de ingredientes:  ");
                int numeroIngredientes = int.Parse(Console.ReadLine());
                Console.Write("Infome o tempo de espera: ");
                int tempoEspera = int.Parse(Console.ReadLine());
                Console.Write("Infome a hora de abertura ");
                int horaAbertura = int.Parse(Console.ReadLine());
                Console.Write("Infome a hora de fechamento: ");
                int horaFechamento = int.Parse(Console.ReadLine());
                Console.Write("Infome o prato principal: ");
                string pratoPrincipal = Console.ReadLine();
                cozinha.Add(new Cozinha(
                    numeroIngredientes,
                    numeroFuncioarios,
                    tempoEspera,
                    horaAbertura,
                    horaFechamento,
                    tipoCozinha,
                    pratoPrincipal
                    ));
                Console.WriteLine("\nCadastrando ingredientes\n");
                for (int i = 0; i < cozinha[n].numeroIngredientes(); i++)
                {
                    Console.Write("Entre com o nome do ingrediente: ");
                    string nome = Console.ReadLine();
                    Console.Write("Entre com a data de Vencimento: ");
                    string data = Console.ReadLine();
                    cozinha[n].AdicionarIngredientes(nome, data);
                }
                Console.WriteLine("\nCadastrando Funcionarios\n");
                for (int i = 0; i < cozinha[n].NumeroFuncionarios(); i++)
                {
                    Console.Write("Infome o nome do funcionario: ");
                    string nome = Console.ReadLine();
                    Console.Write("Infome a atividade do funcionario: ");
                    string atividade = Console.ReadLine();
                    cozinha[n].AdicionarFuncionarios(nome, atividade);
                }
                n++;
            }
            Console.Clear();
            foreach (var item in cozinha)
            {
                Console.WriteLine($"<><><><><><><><><><><><> Cozinha <><><><><><><><><><><>\n");
                Console.WriteLine(item);
                Console.WriteLine("\n<><><><><><><><><><><> Ingredientes <><><><><><><><><><>\n");
                for (int i = 0; i < item.numeroIngredientes(); i++)
                {
                    Console.WriteLine(item.retornaIngrediente(i));
                }
                Console.WriteLine("\n<><><><><><><><><><><> Funcionario  <><><><><><><><><><>\n");
                for (int i = 0; i < item.NumeroFuncionarios(); i++)
                {
                    Console.WriteLine(item.RetornaFuncionarios(i));
                }
                Console.WriteLine("\n<><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                Console.WriteLine("////////////////////////////////////////////////////////");
                Console.WriteLine("\n");
            }

            Console.ReadLine();
        
        
        }
    }
}
