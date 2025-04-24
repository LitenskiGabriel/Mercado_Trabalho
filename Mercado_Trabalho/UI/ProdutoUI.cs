using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercado_Trabalho.Entidade;
using Mercado_Trabalho.Servico;

namespace Mercado_Trabalho.UI
{
    public static class ProdutoUI
    {
        public static void ExecutarProduto()
        {
            Console.Clear();
            ProdutosServico produtosServico = new ProdutosServico();
            bool executar = true;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Informe o menu desejado");
                Console.WriteLine("1 para cadastrar");
                Console.WriteLine("2 para listar");
                Console.WriteLine("3 para sair");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            Console.Clear();
                            Produtos produto = new Produtos();
                           
                            Console.WriteLine("Informe a unidade de medida");
                            produto.UnidadeMedida = Console.ReadLine();

                            Console.WriteLine("Informe o peso");
                            produto.Peso = double.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o nome");
                            produto.Nome = Console.ReadLine();

                            Console.WriteLine("Informe a validade");
                            produto.Validade = Console.ReadLine();

                            //Console.WriteLine("Informe o codigo");
                            produto.CodigoProduto = Guid.NewGuid();

                            produtosServico.Criar(produto);
                            Console.Clear();

                            break;
                        }
                    case 2:
                        {
                            List<Produtos> produtos = produtosServico.BuscarTodos();

                            produtos.ForEach(produto =>
                            {
                                Console.WriteLine();
                                Console.WriteLine("Nome: " + produto.Nome);
                                Console.WriteLine("Peso: " + produto.Peso + produto.UnidadeMedida);
                                Console.WriteLine("Codigo " + produto.CodigoProduto);
                                Console.WriteLine("Validade: " + produto.Validade);
                            });

                            break;
                        }
                    case 3:
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
