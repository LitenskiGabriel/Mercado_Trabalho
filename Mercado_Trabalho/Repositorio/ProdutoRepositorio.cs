using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercado_Trabalho.Entidade;
using Mercado_Trabalho.Interface;
using Newtonsoft.Json;

namespace Mercado_Trabalho.Repositorio
{
    public class ProdutoRepositorio : ICRUD<Produtos>
    {
        List<Produtos> _produtos = new List<Produtos>();
        private readonly string _caminhoBanco;
        public ProdutoRepositorio()
        {
            _caminhoBanco = Banco.BuscarCaminhoBanco("Produtos");
            CarregarLista();
        }

        private void CarregarLista()
        {
            string dados = File.ReadAllText(_caminhoBanco);

            _produtos = JsonConvert.DeserializeObject<List<Produtos>>(dados) ?? [];
        }

        private void Salvar()
        {
            string dados = JsonConvert.SerializeObject(_produtos);

            File.WriteAllText(_caminhoBanco, dados);
        }

        public Cliente BuscarPeloCpf(string cpf)
        {
            throw new NotImplementedException();

        }

        public void Atualizar(Produtos produtoAtualizando)
        {
            Produtos produtos = BuscarPeloCodigo(produtoAtualizando.CodigoProduto);

            if (produtos is not null)
            {
                produtos.Nome = produtoAtualizando.Nome;
                produtos.Peso = produtoAtualizando.Peso;
                produtos.CodigoProduto = produtoAtualizando.CodigoProduto;
            }
            else { Console.WriteLine("Produto não encontrado!"); }

            Salvar();
        }

        public Produtos BuscarPeloId(Guid id)
        {
            return _produtos.FirstOrDefault(produtos => produtos.Id == id);
        }

        public Produtos BuscarPeloCodigo(string codigo)
        {
            return _produtos.FirstOrDefault(produtos => produtos.CodigoProduto == codigo);
        }

        public List<Produtos> BuscarTodos()
        {
            return _produtos;
        }

        public void Criar(Produtos produtosRegistrando)
        {
            produtosRegistrando.Id = Guid.NewGuid();
            _produtos.Add(produtosRegistrando);
            Salvar();
        }

        public void Excluir(Produtos produtosExcluindo)
        {
            _produtos.Remove(produtosExcluindo);
            Salvar();
        }
    }
}
