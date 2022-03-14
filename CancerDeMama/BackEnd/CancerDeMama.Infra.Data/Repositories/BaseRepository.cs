using CancerDeMama.Domain.Core.Entities;
using CancerDeMama.Domain.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CancerDeMama.Infra.Data.Repositories
{
    public class BaseRepository<TEntity,TContext> : IBaseRepository<TEntity> 
        where TEntity : BaseEntity
        where TContext : DbContext
    {
        protected readonly TContext _context;

        public BaseRepository(TContext context)
        {
            _context = context;
        }

        public virtual void Adicionar(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
        }

        public virtual void Atualizar(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
        }

        public virtual void Deletar(TEntity obj)
        {
            _context.Remove(obj);
        }

        public virtual TEntity ObterPorId(int id)
        {
            return _context.Set<TEntity>().FirstOrDefault(p => p.Id.Equals(id));
        }

        public virtual ICollection<TEntity> ListarTodos()
        {
            return _context.Set<TEntity>().ToList();
        }
    }
}
