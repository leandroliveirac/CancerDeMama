using CancerDeMama.Domain.Core.Interfaces.Repositories;
using CancerDeMama.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace CancerDeMama.Domain.Core.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public void Adicionar(TEntity obj)
        {
            _repository.Adicionar(obj);
        }

        public void Atualizar(TEntity obj)
        {
            _repository.Atualizar(obj);
        }

        public void Deletar(TEntity obj)
        {
            _repository.Deletar(obj);
        }

        public ICollection<TEntity> ListarTodos()
        {
            return _repository.ListarTodos();
        }

        public TEntity ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }
    }
}
