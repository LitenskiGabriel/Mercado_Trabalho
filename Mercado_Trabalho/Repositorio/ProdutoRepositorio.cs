using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercado_Trabalho.Entidade;
using Mercado_Trabalho.Interface;

namespace Mercado_Trabalho.Repositorio
{
    public class ProdutoRepositorio : ICRUD<Produtos>
    {
        List<Produtos> _produtos = new List<Produtos>();

        public void Atualizar(Produtos entidade)
        {
            throw new NotImplementedException();
        }

        public Produtos BuscarPeloId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Produtos> BuscarTodos()
        {
            return _produtos;
        }

        public void Criar(Produtos entidade)
        {
            entidade.Id = _produtos.Any() ? _produtos.Max(x => x.Id) + 1 : 1;
            _produtos.Add(entidade);
        }

        public void Excluir(Produtos entidade)
        {
            throw new NotImplementedException();
        }
    }
}
