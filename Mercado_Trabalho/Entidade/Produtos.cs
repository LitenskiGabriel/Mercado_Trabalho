using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado_Trabalho.Entidade
{
    public class Produtos
    {
        public string UnidadeMedida {  get; set; }
        public string Nome {  get; set; }
        public string Validade {  get; set; }
        public String CodigoProduto { get; set; }
        public Guid Id { get; set; }
        public double Peso {  get; set; }

    }
}
