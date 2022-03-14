using CancerDeMama.Application.Interfaces;
using CancerDeMama.Domain.Core.Entities;
using CancerDeMama.Domain.Core.Interfaces.Services;

namespace CancerDeMama.Application.Services
{
    public class RegiaoAppService : AppBaseService<RegiaoEntity>, IRegiaoAppService
    {
        private readonly IRegiaoService _regiaoService;

        public RegiaoAppService(IRegiaoService regiaoService)
            : base(regiaoService)
        {
            _regiaoService = regiaoService;
        }
    }
}
