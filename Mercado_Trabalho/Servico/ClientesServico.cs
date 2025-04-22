using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercado_Trabalho.Entidade;
using Mercado_Trabalho.Interface;
using Mercado_Trabalho.Repositorio;

namespace Mercado_Trabalho.Servico
{
    public class ClientesServico : ICRUD<Cliente>
    {
        private ClienteRepositorio _clienteRepositorio = new ClienteRepositorio();

        public Cliente BuscarPeloCpf(string cpf)
        {
            return _clienteRepositorio.BuscarPeloCpf(cpf);
        }

        public void Atualizar(Cliente entidade)
        {
           _clienteRepositorio.Atualizar(entidade);
        }
        public Cliente BuscarPeloId(Guid id)
        {
          return  _clienteRepositorio.BuscarPeloId(id);
        }

        public List<Cliente> BuscarTodos()
        {
           return _clienteRepositorio.BuscarTodos();
        }

        public void Criar(Cliente entidade)
        {
            _clienteRepositorio.Criar(entidade);
        }

        public string ValidarCriacao(Cliente cliente)
        {
            if (cliente is null)
                return "Cliente não informado";
            if (cliente.Sobrenome == "")
                return "Sobrenome não informado";

            return "";
        }

        public void Excluir(Cliente entidade)
        {
            throw new NotImplementedException();
        }
    }
}
