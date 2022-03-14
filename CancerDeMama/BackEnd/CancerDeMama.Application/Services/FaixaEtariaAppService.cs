using CancerDeMama.Application.Interfaces;
using CancerDeMama.Domain.Core.Entities;
using CancerDeMama.Domain.Core.Interfaces.Services;

namespace CancerDeMama.Application.Services
{
    public class FaixaEtariaAppService : AppBaseService<FaixaEtariaEntity>, IFaixaEtariaAppService
    {
        private readonly IFaixaEtariaService _faixaEtariaService;

        public FaixaEtariaAppService(IFaixaEtariaService faixaEtariaService)
            : base(faixaEtariaService)
        {
            _faixaEtariaService = faixaEtariaService;
        }
    }
}
