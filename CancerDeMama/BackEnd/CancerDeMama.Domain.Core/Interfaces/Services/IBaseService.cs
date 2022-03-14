using System.Collections.Generic;

namespace CancerDeMama.Domain.Core.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        ICollection<TEntity> ListarTodos();
        TEntity ObterPorId(int id);
        void Adicionar(TEntity obj);
        void Atualizar(TEntity obj);
        void Deletar(TEntity obj);
    }
}
