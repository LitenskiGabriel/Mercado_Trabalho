using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercado_Trabalho.Entidade;
using Mercado_Trabalho.Servico;

namespace Mercado_Trabalho.UI
{
    enum MenuAcoes
    {
        NaoInformado,
        Criar,
        Atualizar,
        Deletar,
        Buscar,
        Encerrar
    }
    public class ClienteUI
    {

        ClientesServico clienteFunc = new();
        static ClientesServico _clientesServico = new ClientesServico();
        public void RegistrarCliente(Cliente cliente)
        {
            string resultadoValidacao = _clientesServico.ValidarCriacao(cliente);
            if (resultadoValidacao == "")
            {
                _clientesServico.Criar(cliente);
                return;
            }

            Console.WriteLine(resultadoValidacao);
        }


        public static string MenuDeOpcoes()
        {
            bool encerramento = false;
            
            
                Console.WriteLine(
                "Digite 1 para criar um cadastro\n"
                + "Digite 2 para Atualizar informações de cadastro\n"
                + "Digite 3 para Apagar seu cadastro\n"
                + "Digite 4 para Buscar cadastro" +
                "5 para encerrar processo"
                );
                MenuAcoes menuAcoes = (MenuAcoes)int.Parse(Console.ReadLine());




                

                return "";
        }

        public static void DadosParaCadastro()
        {
            Cliente cliente = new();

            Console.WriteLine("Precisamos de seu Nome, Sobrenome, data de nascimento e cpf.");

            Console.WriteLine("Nome:");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("Sobrenome:");
            cliente.Sobrenome = Console.ReadLine();

            Console.WriteLine("Data de nascimento(dd/mm/aaaa):");
            cliente.DataNascimento = Console.ReadLine();
        }
        public static void PerguntaCadastro()
        {
            ClientesServico clientesServico = new ClientesServico();
            Cliente clientes = new();

            List<Cliente> clientesLista = new();

            bool cadastro;
            bool cadastrar;


            Console.WriteLine("Para concluirmos sua compra, você possui um cadastro?");
            string perguntaCadastro = Console.ReadLine().ToLower();

            if (perguntaCadastro == "s" || perguntaCadastro == "sim")
            {

                ClientesServico clienteServico = new();


                Console.WriteLine("Informe seu CPF");
                string cpf = Console.ReadLine();

                Cliente cliente = _clientesServico.BuscarPeloCpf(cpf);
                if (cliente == null)
                {
                    Console.WriteLine("Cadastro inexistente");
                }

                else
                {
                    Console.WriteLine("Olá, seu cadrasto foi encontrado!");
                }


                Console.WriteLine("Olá " + cliente.Nome);

                ///
                ///
                ///


                Console.WriteLine("Você deseja se cadastrar?");
                string perguntaCadastrar = Console.ReadLine().ToLower();

                if (perguntaCadastrar == "s" || perguntaCadastrar == "sim")
                {
                    cadastro = true;

                    Console.WriteLine("Qual seu nome e sobrenome?");
                    clientes.Nome = Console.ReadLine();
                    clientes.Sobrenome = Console.ReadLine();

                    Console.WriteLine("Informe seu CPF e sua data de nascimento:");
                    clientes.Cpf = Console.ReadLine();
                    clientes.DataNascimento = Console.ReadLine();

                    clientes.Id = new Guid();

                }
                else
                {
                    Console.Write("O preço total da sua compra foi: "); //colocar variavel contendo preco da compra
                }

            }

        }

        public void AdicionarCliente(Cliente cliente)
        {
            List<Cliente> _listaClientes = new List<Cliente>();

            _listaClientes.Add(cliente);


        }

    }
}
