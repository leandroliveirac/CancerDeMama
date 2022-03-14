using System.Collections.Generic;

namespace CancerDeMama.Application.Interfaces
{
    public interface IAppBaseService<TEntity> where TEntity : class
    {
        ICollection<TEntity> ListarTodos();
        TEntity ObterPorId(int id);
        void Adicionar(TEntity obj);
        void Atualizar(TEntity obj);
        void Deletar(TEntity obj);
    }
}
