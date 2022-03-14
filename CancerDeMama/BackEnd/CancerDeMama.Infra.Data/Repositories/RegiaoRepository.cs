using CancerDeMama.Domain.Core.Entities;
using CancerDeMama.Domain.Core.Interfaces.Repositories;
using CancerDeMama.Infra.Data.Contexts;

namespace CancerDeMama.Infra.Data.Repositories
{
    public sealed class RegiaoRepository : BaseRepository<RegiaoEntity, CancerDeMamaContext>, IRegiaoRepository
    {
        public RegiaoRepository(CancerDeMamaContext context) 
            : base(context)
        {
        }
    }
}
