using CancerDeMama.Application.Interfaces;
using CancerDeMama.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace CancerDeMama.Application.Services
{
    public class AppBaseService<TEntity> : IAppBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseService<TEntity> _baseService;

        public AppBaseService(IBaseService<TEntity> baseService)
        {
            _baseService = baseService;
        }

        public void Adicionar(TEntity obj)
        {
            _baseService.Adicionar(obj);
        }

        public void Atualizar(TEntity obj)
        {
            _baseService.Atualizar(obj);
        }

        public void Deletar(TEntity obj)
        {
            _baseService.Deletar(obj);
        }

        public ICollection<TEntity> ListarTodos()
        {
            return _baseService.ListarTodos();
        }

        public TEntity ObterPorId(int id)
        {
            return _baseService.ObterPorId(id);
        }
    }
}
