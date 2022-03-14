using CancerDeMama.Domain.Core.Entities;
using CancerDeMama.Domain.Core.Interfaces.Repositories;
using CancerDeMama.Infra.Data.Contexts;

namespace CancerDeMama.Infra.Data.Repositories
{
    public sealed class FaixaEtariaRepository : BaseRepository<FaixaEtariaEntity, CancerDeMamaContext>, IFaixaEtariaRepository
    {
        public FaixaEtariaRepository(CancerDeMamaContext context) 
            : base(context)
        {
        }
    }
}
