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
            ProdutosServico produtosServico = new ProdutosServico();
            Produtos desejos = new Produtos();

            List<Produtos> produtos = produtosServico.BuscarTodos();

            produtos.ForEach(produto =>
            {
                Console.WriteLine();
                Console.WriteLine("Nome: " + produto.Nome);
                Console.WriteLine("Peso: " + produto.Peso + produto.UnidadeMedida);
            });

            produtos.ForEach(produto =>
            {
                
                Console.WriteLine("Quais são os itens que você deseja comprar?");

                int itens = int.Parse(Console.ReadLine());

                for (int i = 0; i < itens; i++)
                {
                    Console.Write($"Nome do {i+1}° produto: ");
                    desejos.Nome = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write($"Peso: ");
                    desejos.Peso = Double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Console.Write($"Quantidade: ");
                    int quant = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine();
                }
            });
        }
    }
}
