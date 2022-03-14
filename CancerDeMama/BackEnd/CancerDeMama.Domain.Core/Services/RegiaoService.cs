using CancerDeMama.Domain.Core.Entities;
using CancerDeMama.Domain.Core.Interfaces.Repositories;
using CancerDeMama.Domain.Core.Interfaces.Services;

namespace CancerDeMama.Domain.Core.Services
{
    public class RegiaoService : BaseService<RegiaoEntity>, IRegiaoService
    {
        private readonly IRegiaoRepository _regiaoRepository;

        public RegiaoService(IRegiaoRepository regiaoRepository)
            : base(regiaoRepository)
        {
            _regiaoRepository = regiaoRepository;
        }
    }
}
