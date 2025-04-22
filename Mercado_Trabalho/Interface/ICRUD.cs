using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado_Trabalho.Interface
{
    public interface ICRUD<T>
    {
        public void Criar(T entidade);
        public void Atualizar(T entidade);
        public List<T> BuscarTodos();
        public T BuscarPeloId(Guid id);
        public void Excluir(T entidade);


    }
}