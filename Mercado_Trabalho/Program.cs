using Mercado_Trabalho;
using Mercado_Trabalho.Entidade;
using Mercado_Trabalho.Servico;
using Mercado_Trabalho.UI;

namespace Mercado_Trabalho
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("------------------------- Bem-vindo ao mercado baratão! -------------------------");

            //ClienteUI.MenuDeOpcoes();

            //teste
            bool executar = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Informe o menu desejado");
                Console.WriteLine("1 para produto");
                Console.WriteLine("2 para cliente");
                Console.WriteLine("3 para sair");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            ProdutoUI.Executar();
                            break;
                        }
                    case 2:
                        {

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