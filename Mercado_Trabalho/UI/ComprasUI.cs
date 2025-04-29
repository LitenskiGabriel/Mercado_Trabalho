using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercado_Trabalho.Entidade;
using Mercado_Trabalho.Servico;

namespace Mercado_Trabalho.UI
{
    internal class ComprasUI
    {
        public static void ExecutarCompras()
        {
            List<Produtos>  _produtosCarrinho = new List<Produtos>();
            List<int> itens = new List<int>();

            ProdutosServico produtosServico = new ProdutosServico();
            Produtos desejos = new Produtos();

            List<Produtos> produtos = produtosServico.BuscarTodos();

            produtos.ForEach(produto =>
            {
                Console.WriteLine();
                Console.WriteLine("Nome: " + produto.Nome);
                Console.WriteLine("Peso: " + produto.Peso + produto.UnidadeMedida);
                Console.WriteLine("Código: "+ produto.CodigoProduto);
            });

            produtos.ForEach(produto =>
            {
                Console.WriteLine();   
                Console.WriteLine("Digite os códigos dos itens que você deseja comprar:");


                do
                {
                    int itensNum = int.Parse(Console.ReadLine());

                    Console.WriteLine("Mais algo?(n para parar, código para continuar.)");
                    
                    if ()
                    {

                    }
                }while()
                
            });
        }
    }
}
