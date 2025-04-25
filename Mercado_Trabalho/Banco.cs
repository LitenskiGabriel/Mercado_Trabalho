using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercado_Trabalho.Servico;

namespace Mercado_Trabalho
{
    public static class Banco
    {
        public static string BuscarCaminhoBanco(string nome)
        {
            string diretorioBancoDados = Path.Combine(Environment.CurrentDirectory, "BancoDeDados");

            Directory.CreateDirectory(diretorioBancoDados);

            string caminhoCompleto = Path.Combine(diretorioBancoDados, $"{nome}.json");

            if (!Path.Exists(caminhoCompleto))
            {
                FileStream file = File.Create(caminhoCompleto);

                //Quando alguem abre um arquivo, ele não pode ser aberto por outra pessoa/programa
                //dessa forma precisamos fechar/encerrar o processo do arquivo.
                file.Dispose();
            }

            return caminhoCompleto;
        }
    }
}
