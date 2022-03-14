namespace CancerDeMama.Domain.Core.Interfaces.UnitOfWork
{
    public interface IUnitOfWork<TContext> where TContext : class
    {
        void Commit();
    }
}
