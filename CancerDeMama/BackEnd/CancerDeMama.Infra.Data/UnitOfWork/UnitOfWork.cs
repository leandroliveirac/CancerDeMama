using CancerDeMama.Domain.Core.Interfaces.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace CancerDeMama.Infra.Data.UnitOfWork
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : DbContext 
    {
        private readonly TContext _context;

        public UnitOfWork(TContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
