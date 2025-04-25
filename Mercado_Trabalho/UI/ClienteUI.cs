using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercado_Trabalho.Entidade;
using Mercado_Trabalho.Servico;

namespace Mercado_Trabalho.UI
{
    public class ClienteUI
    {

        ClientesServico clienteFunc = new();
        


        public static void ExecutarCliente(ClientesServico _clientesServico)
        {
            Console.Clear();
            bool executar = true;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Informe o menu desejado");
                Console.WriteLine("1 para cadastrar o cliente");
                Console.WriteLine("2 para atualizar cliente");
                Console.WriteLine("3 para deletar");
                Console.WriteLine("4 para buscar");
                Console.WriteLine("5 para sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {

                            Console.Clear();
                            Cliente clientes = new();

                            Console.WriteLine("Informe seu nome");
                            clientes.Nome = Console.ReadLine();

                            Console.WriteLine("Informe seu sobrenome");
                            clientes.Sobrenome = Console.ReadLine();

                            Console.WriteLine("Informe seu CPF.");
                            clientes.Cpf = Console.ReadLine();

                            Console.WriteLine("Informe sua data de nascimento:");
                            clientes.DataNascimento = Console.ReadLine();

                            _clientesServico.Criar(clientes);
                            Console.Clear();

                            break;
                        }
                    case 2:
                        {
                            Cliente clientes = new();

                            Console.WriteLine("Digite o CPF do cadastro que deseja atualizar.");
                            _clientesServico.BuscarPeloCpf(Console.ReadLine());


                            Console.WriteLine("Informe um novo nome");
                            clientes.Nome = Console.ReadLine();

                            Console.WriteLine("Informe um novo sobrenome");
                            clientes.Sobrenome = Console.ReadLine();

                            _clientesServico.Atualizar(clientes);
                            
                            Console.Clear();

                            break;
                        }
                    case 3:
                        {
                            Cliente clientes = new();
                            Console.WriteLine("Informe o cadastro que deseja deletar (informe o CPF):");
                            clientes.Cpf = Console.ReadLine();

                            _clientesServico.Excluir(clientes);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Qual cadastro você deseja consultar(Digite o CPF do cadastro desejado)?");
                            Cliente cpfDigitado = _clientesServico.BuscarPeloCpf(Console.ReadLine());
                            Console.WriteLine(
                                $"Nome completo: {cpfDigitado.Nome} {cpfDigitado.Sobrenome}\n" +
                                $"Data de Nascimento: {cpfDigitado.DataNascimento}\n" +
                                $"Cpf: {cpfDigitado.Cpf}");

                            break;
                        }
                    case 5:
                        {
                            executar = false;
                            break;
                        }
                    default:
                        break;
                }
            } while (executar);
        }
      
    }
}
