using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercado_Trabalho.Entidade;
using Mercado_Trabalho.Interface;
using Mercado_Trabalho.Repositorio;

namespace Mercado_Trabalho.Servico
{
    public class ProdutosServico : ICRUD<Produtos>
    {
        ProdutoRepositorio _produtoRepositorio = new ProdutoRepositorio();
        public void Atualizar(Produtos entidade)
        {
            _produtoRepositorio.Atualizar(entidade);
        }

        public Produtos BuscarPeloId(Guid id)
        {
           return  _produtoRepositorio.BuscarPeloId(id);
        }

        public List<Produtos> BuscarTodos()
        {
            return _produtoRepositorio.BuscarTodos();
        }
        public Produtos BuscarPeloCodigo(string codigo)
        {

            return _produtoRepositorio.BuscarPeloCodigo(codigo);
        }
        public void Criar(Produtos entidade)
        {
            _produtoRepositorio.Criar(entidade);
        }

        public void Excluir(Produtos entidade)
        {
            _produtoRepositorio.Excluir(entidade);
        }
    }
}
