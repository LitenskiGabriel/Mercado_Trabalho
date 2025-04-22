using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado_Trabalho.Entidade
{
    public class Produtos
    {
        public double UnidadeMedida {  get; set; }
        public string Nome {  get; set; }
        public string Validade {  get; set; }
        public Guid CodigoProduto { get; set; }
        public int Id { get; set; }

    }
}
