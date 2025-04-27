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
    public class ClienteRepositorio : ICRUD<Cliente>
    {
        List<Cliente> _clientes = new List<Cliente>();
        private readonly string _caminhoBanco;
        public ClienteRepositorio()
        {
            _caminhoBanco = Banco.BuscarCaminhoBanco("Clientes");
            CarregarLista();
        }

        private void CarregarLista()
        {
            string dados = File.ReadAllText(_caminhoBanco);

            _clientes = JsonConvert.DeserializeObject<List<Cliente>>(dados) ?? [];
        }

        private void Salvar()
        {
            string dados = JsonConvert.SerializeObject(_clientes);

            File.WriteAllText(_caminhoBanco, dados);
        }

        public Cliente BuscarPeloCpf(string cpf)
        {

            return _clientes.FirstOrDefault(cliente => cliente.Cpf == cpf, null);
        }

        public void Atualizar(Cliente clienteAtualizando)
        {
            Cliente cliente = BuscarPeloId(clienteAtualizando.Id);

            if (cliente is not null)
            {
                cliente.Nome = clienteAtualizando.Nome;
                cliente.Sobrenome = clienteAtualizando.Sobrenome;
            }
            Salvar();
        }

        public Cliente BuscarPeloId(Guid id)
        {
            return _clientes.FirstOrDefault(cliente => cliente.Id == id);
        }

        public List<Cliente> BuscarTodos()
        {
            return _clientes;
        }

        public void Criar(Cliente clienteRegistrando)
        {
            clienteRegistrando.Id = Guid.NewGuid();
            _clientes.Add(clienteRegistrando);
            Salvar();
        }   

        public void Excluir(Cliente clienteExcluindo)
        {
            _clientes.Remove(clienteExcluindo);
            Salvar();
        }
    }
}
