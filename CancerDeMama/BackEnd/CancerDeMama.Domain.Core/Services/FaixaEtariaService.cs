using CancerDeMama.Domain.Core.Entities;
using CancerDeMama.Domain.Core.Interfaces.Repositories;
using CancerDeMama.Domain.Core.Interfaces.Services;

namespace CancerDeMama.Domain.Core.Services
{
    public class FaixaEtariaService : BaseService<FaixaEtariaEntity>, IFaixaEtariaService
    {
        private readonly IFaixaEtariaRepository _faixaEtariaRepository;

        public FaixaEtariaService(IFaixaEtariaRepository faixaEtariaRepository)
            : base(faixaEtariaRepository)
        {
            _faixaEtariaRepository = faixaEtariaRepository;
        }
    }
}
